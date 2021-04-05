using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Zoom_API1
{
    class ZoomAPI
    {
        static string token;
        String json;
        System.Windows.Forms.ListBox logList;
        SqlConnection con;
        public ZoomAPI()
        {
            var connection = System.Configuration.ConfigurationManager.
   ConnectionStrings["Zoom_API1.Properties.Settings.ZoomConnectionString"].ConnectionString;

            logList = new System.Windows.Forms.ListBox();
            con = new SqlConnection(connection);
        }
        public static void SaveToken(string t)
        {
            token = t;
        }

        public System.Windows.Forms.ListBox.ObjectCollection GetLogList()
        {
            return logList.Items;
        }
        public int deleteMeetinges()
        {



            try
            {
                SqlCommand cmd = new SqlCommand("delete_Meetinges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JSON", json);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                logList.Items.Add(rowAffected + " meetinges deleted...");
                con.Close();
                return 1;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                logList.Items.Add(ex.Message);
                return 0;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                logList.Items.Add(ex.Message);
                return 0;
            }
        }
        public void ImportMeetingesIDs(DateTime from, DateTime to, ProgressBar p)
        {
            try
            {
                logList.Items.Clear();
                //it is used to import the meetigs details such as the meeting id, uuid, host name, strat date ....ect, for a gived period of time                
                //MessageBox.Show(from.ToString("yyyy-MM-dd")+"to "+ to.ToString("yyyy-MM-DD"));

                var client = new RestClient("https://api.zoom.us/v2/metrics/meetings?type=past&from=" + from.ToString("yyyy-MM-dd") + "&to=" + to.ToString("yyyy-MM-dd") + "&page_size=300");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("Authorization", "Bearer " + token);
                IRestResponse response = client.Execute(request);
                //MessageBox.Show(response.Content);

                //MessageBox.Show(next_page_token.Length.ToString());
                //Console.WriteLine(response.Content);
                System.Net.HttpStatusCode statusCode = response.StatusCode;
                int numericStatusCode = (int)statusCode;
                if (numericStatusCode == 200)
                {

                    json = response.Content;
                    Save_Meetinges();//save
                    var data = JObject.Parse(json);
                    int page_count = Convert.ToInt32(data.SelectToken("page_count"));
                    p.Maximum = page_count;
                    // label3.Text = "Pages: " + page_count.ToString();
                    string next_page_token = Convert.ToString(data.SelectToken("next_page_token"));




                    p.Value = 1;


                    //MessageBox.Show(numericStatusCode.ToString());
                    while (next_page_token.Length != 0)
                    {
                        p.Value += 1;
                        client = new RestClient("https://api.zoom.us/v2/metrics/meetings?type=past&from=" + from.ToString("yyyy-MM-dd") + "&to=" + to.ToString("yyyy-MM-dd") + "&page_size=300&next_page_token=" + next_page_token);
                        client.Timeout = -1;
                        request = new RestRequest(Method.GET);
                        request.AddHeader("Authorization", "Bearer " + token);
                        response = client.Execute(request);
                        json = response.Content;
                        Console.WriteLine(json);
                        Save_Meetinges();//save
                        data = JObject.Parse(json);
                        next_page_token = Convert.ToString(data.SelectToken("next_page_token"));
                        System.Threading.Thread.Sleep(100);

                    }


                }
                else
                {
                    MessageBox.Show(response.Content, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logList.Items.Add("ERROR  "+ response.Content);
                }
                  
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                logList.Items.Add(ex.Message);
            }

            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                logList.Items.Add(ex.Message);
            }



        }
        private void Save_Meetinges()
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Save_Meetinges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JSON", json);

                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                logList.Items.Add( " Saved");
                con.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                logList.Items.Add(ex.Message);
            }

            catch (System.Exception ex)
            {
               // System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                logList.Items.Add(ex.Message);
            }
            finally
            {

                con.Close();
            }
        }
        public AutoCompleteStringCollection GetInstructorData()
        {
            //to return name of hosts for quick serach in the combobox 
            SqlCommand cmd = new SqlCommand("select first_name+' '+last_name name,email from instructors", con);
            cmd.CommandType = CommandType.Text;
            // cmd.Parameters.AddWithValue("@email", email);
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            con.Open();

            int rowAffected = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                collection.Add(dr["name"].ToString());


            }
            con.Close();

            return collection;
        }

        public int ImportMeetingesDtl(string email, ProgressBar p)
        {

            logList.Items.Clear();
            var uuids = new List<string>();
            int errorCode = 0;

            // uuids.Clear();
            uuids = getUuids_formDB(email);

            p.Maximum = uuids.Count;
            Console.WriteLine(email);
            errorCode = Import_and_Save_MeetingesDtl(uuids, p);
            return errorCode;
            //listBox2.Items.AddRange(logList.Items);
            // Application.DoEvents();

        }
        private List<string> getUuids_formDB(string email)
        {
            var uuids = new List<string>();
            //string uuidEncode;
            SqlCommand cmd = new SqlCommand("Get_instructor_meeting", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);

            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                uuids.Add(dr["uuid"].ToString());
            }
            con.Close();

            return uuids;
        }
        private int Import_and_Save_MeetingesDtl(List<string> uuids, ProgressBar p)
        {
            try
            {
                string uuidEncode;
                if (uuids.Count != 0)
                {
                    // progressBar_user_meetinges.Maximum = uuids.Count;
                    int i = 0;

                    p.Value = 0;
                    while (i < uuids.Count)
                    {

                        p.Value += 1;

                        uuidEncode = System.Web.HttpUtility.UrlEncode(uuids[i]);
                        uuidEncode = System.Web.HttpUtility.UrlEncode(uuidEncode);

                        var client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuidEncode + "/participants?page_size=300&include_fields=<string>");
                        client.Timeout = -1;
                        var request = new RestRequest(Method.GET);
                        //for zoom api

                        request.AddHeader("Authorization", "Bearer " + token);
                        IRestResponse response = client.Execute(request);

                        //MessageBox.Show(next_page_token.Length.ToString());
                        //Console.WriteLine(response.Content);
                        System.Net.HttpStatusCode statusCode = response.StatusCode;
                        int numericStatusCode = (int)statusCode;
                        if (numericStatusCode == 200)
                        {
                            json = response.Content;
                            Save_Meeting_Participants(uuids[i]);//save
                            //listBox1.Items.AddRange (logList.Items);
                            //Application.DoEvents();
                            var data = JObject.Parse(json);
                            string next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

                            Console.WriteLine(json);
                            //MessageBox.Show(numericStatusCode.ToString());
                            while (next_page_token.Length != 0)
                            {

                                client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuidEncode + "/participants?page_size=300&next_page_token=" + next_page_token + "&include_fields=<string>");
                                client.Timeout = -1;
                                request = new RestRequest(Method.GET);
                                request.AddHeader("Authorization", "Bearer " + token);
                                response = client.Execute(request);

                                json = response.Content;
                                Save_Meeting_Participants(uuids[i]);//save
                                data = JObject.Parse(json);
                                next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

                            }

                        }
                        else if (numericStatusCode == 404)
                        {
 // MessageBox.Show("لا يوجد معلومات عن المحاضرة" + "\n" + response.Content);
                            Console.WriteLine("لا يوجد معلومات عن المحاضرة" + "\n" + response.Content);
                            logList.Items.Add("لا يوجد معلومات عن المحاضرة " + response.Content);
                        }
                           
                        else if (numericStatusCode == 401)
                        {
                            MessageBox.Show(response.Content, "Token ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            logList.Items.Add("Token ERROR " + response.Content);
                            return 0;

                        }
                        else
                        {
                            MessageBox.Show(response.Content, "General ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            logList.Items.Add("General ERROR " + response.Content);
                            return 1;
                        }
                        i++;

                    }

                }
                else
                {
                    //MessageBox.Show("لا يوجد محاضرات للمدرس منذ فترة طويله");
                    Console.WriteLine("لا يوجد محاضرات للمدرس منذ فترة طويله");
                    logList.Items.Add("لا يوجد محاضرات للمدرس منذ فترة طويله");
                }
                return 1;



            }

            catch (System.Data.SqlClient.SqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                //  listBox1.Items.Add(ex.Message);
                return 1;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 1;
            }


        }
        private void Save_Meeting_Participants(string uuid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Save_Meeting_Participants", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JSON", json);
                cmd.Parameters.AddWithValue("@meeting_uuid", uuid);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                logList.Items.Add(uuid + " Saved");
                con.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                // listBox1.Items.Add(ex.Message);
                logList.Items.Add(ex.Message);
                Application.DoEvents();//Refresh the GUI to shw the new items in the list box
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
