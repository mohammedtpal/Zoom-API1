using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_API1
{
    public partial class meetinges : Form
    {
        String json;
      public static  string token;//= "eyJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiIyNjIwMDg5Yi0xMjcxLTQxMGQtODBjMi0zMDIyNGNhZGU4NDAifQ.eyJ2ZXIiOjcsImF1aWQiOiJhNTI2NWJlYzA1ZjIzNWIwYzAzNGRlMzI0NDdmODhiYiIsImNvZGUiOiI1QUhOUTB5TG40X210UlNlbjFiU2xHTG5NclpVNlVhdkEiLCJpc3MiOiJ6bTpjaWQ6b1piYjRDUGlROGVLeHZwdjJNMHVRIiwiZ25vIjowLCJ0eXBlIjowLCJ0aWQiOjAsImF1ZCI6Imh0dHBzOi8vb2F1dGguem9vbS51cyIsInVpZCI6Im10UlNlbjFiU2xHTG5NclpVNlVhdkEiLCJuYmYiOjE2MTY0NDI2ODEsImV4cCI6MTYxNjQ0NjI4MSwiaWF0IjoxNjE2NDQyNjgxLCJhaWQiOiJFdE1PMnlBMFRuTzB2M1FoYnBBeVFBIiwianRpIjoiY2Y4ZWZiYmMtMWI3My00ODE4LTllOTMtMmIxMDk1MGYzZTQ1In0.l7SGdp6F4Q2cafkBjW-UwTYUyYnMzfcQdE_vCsI4ka2Jtr0ug0ZM69RHuj7zeA0x9jhXgBqK-F8UrR6QeJ2t6w";
        ListBox logList;
        ZoomAPI api;
       string SqlConnectionString;

        public meetinges()
        {
            InitializeComponent();
            
            logList = new ListBox();
            SqlConnectionString = "Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True";
            
            api = new ZoomAPI();
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            //DateTime from = FromdateTimePicker1.Value;
            //DateTime to = TodateTimePicker2.Value;
            ////MessageBox.Show(from.ToString("yyyy-MM-dd")+"to "+ to.ToString("yyyy-MM-DD"));

            //var client = new RestClient("https://api.zoom.us/v2/metrics/meetings?type=past&from=" + from.ToString("yyyy-MM-dd") + "&to=" + to.ToString("yyyy-MM-dd") + "&page_size=300");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("Authorization", "Bearer " + token);
            //IRestResponse response = client.Execute(request);
            ////MessageBox.Show(response.Content);

            ////MessageBox.Show(next_page_token.Length.ToString());
            ////Console.WriteLine(response.Content);
            //System.Net.HttpStatusCode statusCode = response.StatusCode;
            //int numericStatusCode = (int)statusCode;
            //if (numericStatusCode == 200)
            //{

            //    json = response.Content;
            //    Save_Meetinges();//save
            //    var data = JObject.Parse(json);
            //    int page_count = Convert.ToInt32(data.SelectToken("page_count"));
            //    progressBar1.Maximum = page_count;
            //    label3.Text = "Pages: " + page_count.ToString();
            //    string next_page_token = Convert.ToString(data.SelectToken("next_page_token"));




            //    progressBar1.Value = 1;


            //    //MessageBox.Show(numericStatusCode.ToString());
            //    while (next_page_token.Length != 0)
            //    {
            //        progressBar1.Value += 1;
            //        client = new RestClient("https://api.zoom.us/v2/metrics/meetings?type=past&from=" + from.ToString("yyyy-MM-dd") + "&to=" + to.ToString("yyyy-MM-dd") + "&page_size=300&next_page_token=" + next_page_token);
            //        client.Timeout = -1;
            //        request = new RestRequest(Method.GET);
            //        request.AddHeader("Authorization", "Bearer " + token);
            //        response = client.Execute(request);
            //        json = response.Content;
            //        Console.WriteLine(json);
            //        Save_Meetinges();//save
            //        data = JObject.Parse(json);
            //        next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

            //    }


            //}
            //else
            //    MessageBox.Show(response.Content, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //MessageBox.Show(from.ToString("yyyy-mm-dd"));


        }
        private void Save_Meetinges()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Save_Meetinges", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JSON", json);

                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                listBox1.Items.Add(ex.Message);
            }

            catch (System.Exception ex)
            {
               System.Windows.Forms.MessageBox.Show(ex.Message);
               Console.WriteLine(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
                //SqlCommand cmd = new SqlCommand("delete_Meetinges", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                //con.Open();
                //int rowAffected = cmd.ExecuteNonQuery();
                //con.Close();
                int result;
                result = api.deleteMeetinges();
                  if (result == 1)
                    MessageBox.Show("Delete Done");
                  else
                    MessageBox.Show("Delete Done","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void meetinges_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zoomDataSet1.instructors' table. You can move, or remove it, as needed.
            this.instructorsTableAdapter.Fill(this.zoomDataSet1.instructors);
            comboBox1.AutoCompleteCustomSource = api.GetInstructorData();
            comboBox2.AutoCompleteCustomSource = api.GetInstructorData();
            

        }
        //private void updateToken()
        //{
        //    if (tokentxt.Text != "")
        //    {
        //        //this.token = tokentxt.Text;
        //        api.updateToken(tokentxt.Text);
        //    }
        //}
        private void button3_Click(object sender, EventArgs e)
        {
           // updateToken();
            HostProgressBar2.Value = 0;
            HostListBox2.Items.Clear();
            api.ImportMeetingesDtl(comboBox1.SelectedValue.ToString(),HostProgressBar2);
            HostListBox2.Items.AddRange(api.GetLogList());
            Application.DoEvents();


            //try
            //{
               
            //    logList.Items.Clear();
            //    listBox2.Items.Clear();
            //    var uuids = new List<string>();
            //    int errorCode = 0;
            //    string email = comboBox1.SelectedValue.ToString();
            //    uuids.Clear();
            //    uuids = getUuids(email);
            //    Console.WriteLine(email);
            //    errorCode = get_SaveMeetingesDtl(uuids);
            //    listBox2.Items.AddRange(logList.Items);
            //    Application.DoEvents();
            //    //var uuids = new List<string>();
            //    //string uuidEncode;
            //    //SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
            //    //SqlCommand cmd = new SqlCommand("Get_instructor_meeting", con);
            //    //cmd.CommandType = CommandType.StoredProcedure;
            //    //cmd.Parameters.AddWithValue("@email", comboBox1.SelectedValue);

            //    //con.Open();
            //    //int rowAffected = cmd.ExecuteNonQuery();
            //    //SqlDataReader dr = cmd.ExecuteReader();
            //    //while (dr.Read())
            //    //{

            //    //    uuids.Add(dr["uuid"].ToString());
            //    //}
            //    //con.Close();

            //    //if (uuids.Count != 0)
            //    //{
            //    //    progressBar2.Maximum = uuids.Count;
            //    //    int i = 0;
            //    //    progressBar2.Value = 0;
            //    //    while (i < uuids.Count)
            //    //    {
            //    //        progressBar2.Value += 1;

            //    //        uuidEncode = System.Web.HttpUtility.UrlEncode(uuids[i]);
            //    //        uuidEncode = System.Web.HttpUtility.UrlEncode(uuidEncode);

            //    //        var client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuidEncode + "/participants?page_size=300&include_fields=<string>");
            //    //        client.Timeout = -1;
            //    //        var request = new RestRequest(Method.GET);
            //    //        //for zoom api

            //    //        request.AddHeader("Authorization", "Bearer " + token);
            //    //        IRestResponse response = client.Execute(request);

            //    //        //MessageBox.Show(next_page_token.Length.ToString());
            //    //        //Console.WriteLine(response.Content);
            //    //        System.Net.HttpStatusCode statusCode = response.StatusCode;
            //    //        int numericStatusCode = (int)statusCode;
            //    //        if (numericStatusCode == 200)
            //    //        {
            //    //            json = response.Content;
            //    //            Save_Meeting_Participants(uuids[i]);//save
            //    //            var data = JObject.Parse(json);
            //    //            string next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

            //    //            Console.WriteLine(json);
            //    //            //MessageBox.Show(numericStatusCode.ToString());
            //    //            while (next_page_token.Length != 0)
            //    //            {

            //    //                client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuidEncode + "/participants?page_size=300&next_page_token=" + next_page_token + "&include_fields=<string>");
            //    //                client.Timeout = -1;
            //    //                request = new RestRequest(Method.GET);
            //    //                request.AddHeader("Authorization", "Bearer " + token);
            //    //                response = client.Execute(request);

            //    //                json = response.Content;
            //    //                Save_Meeting_Participants(uuids[i]);//save
            //    //                data = JObject.Parse(json);
            //    //                next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

            //    //            }

            //    //        }
            //    //        else if (numericStatusCode == 404)
            //    //            MessageBox.Show("لا يوجد معلومات عن المحاضرة" + "\n" + response.Content);
            //    //        else if (numericStatusCode == 401)
            //    //        {
            //    //            MessageBox.Show(response.Content, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    //            break;
            //    //        }
            //    //        else
            //    //            MessageBox.Show(response.Content, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //        i++;
            //    //    }

            //    //}
            //    //else
            //    //    MessageBox.Show("لا يوجد محاضرات للمدرس منذ فترة طويله");
            //}
            //catch (System.Data.SqlClient.SqlException ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
        private void Save_Meeting_Participants(string uuid)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Save_Meeting_Participants", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JSON", json);
                cmd.Parameters.AddWithValue("@meeting_uuid", uuid);
                con.Open();
                int rowAffected = cmd.ExecuteNonQuery();
                logList.Items.Add(rowAffected +" rows Affected");
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(instructorsTableAdapter.GetData().Count.ToString());//)Rows[0].ItemArray[1].ToString());
            int progMax = 0;
            int progValue = 0;
            //logList.Items.Clear();
            HostListBox2.Items.Clear();
            int i = 0;
            var uuids = new List<string>();
            int errorCode = 0;
            progressBar_users.Maximum = instructorsTableAdapter.GetData().Count;

            progressBar_users.Value = 0;

            while (i < instructorsTableAdapter.GetData().Count)
            {
                progressBar_users.Value += 1;
              
                string email = instructorsTableAdapter.GetData().Rows[i].ItemArray[1].ToString();
                //uuids.Clear();
                //uuids = getUuids(email);
                //Console.WriteLine(email);
                //errorCode= get_SaveMeetingesDtl(uuids);
                errorCode=api.ImportMeetingesDtl(email,progressBar_user_meetinges);
                listBox1.Items.AddRange(api.GetLogList());
                Application.DoEvents();

                if (errorCode == 0)
                {
                    break;

                }






                i++;
            }

        }
        private List<string> getUuids(string email)
        {
            var uuids = new List<string>();
            //string uuidEncode;
            SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
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
        private int get_SaveMeetingesDtl(List<string> uuids)
        {
            try
            {
                string uuidEncode;
                if (uuids.Count != 0)
                {
                    progressBar_user_meetinges.Maximum = uuids.Count;
                    int i = 0;
                    progressBar_user_meetinges.Value = 0;
                    while (i < uuids.Count)
                    {
                        progressBar_user_meetinges.Value += 1;

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
                            Application.DoEvents();
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
                            // MessageBox.Show("لا يوجد معلومات عن المحاضرة" + "\n" + response.Content);
                            Console.WriteLine("لا يوجد معلومات عن المحاضرة" + "\n" + response.Content);
                        else if (numericStatusCode == 401)
                        {
                            MessageBox.Show(response.Content, "Token ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 0;

                        }
                        else
                        {
                            MessageBox.Show(response.Content, "General ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return 1;
                        }
                        i++;
                       
                    }

                }
                else
                    //MessageBox.Show("لا يوجد محاضرات للمدرس منذ فترة طويله");
                    Console.WriteLine("لا يوجد محاضرات للمدرس منذ فترة طويله"); return 1;
            }
           
            catch (System.Data.SqlClient.SqlException ex)
            {
                //System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
                listBox1.Items.Add(ex.Message);
                return 1;
            }

            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 1;
            }
         


        }

       

        private void button5_Click_1(object sender, EventArgs e)
        {
 MessageBox.Show("test");
           
          //  System.Windows.Forms.Application.Exit();            //System.Windows.Forms.Application.Exit();
            //System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            api.ImportMeetingesIDs(FromdateTimePicker1.Value, TodateTimePicker2.Value, progressBar1);
           

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //this.hostMeetingsAggregateReportTableAdapter.Fill()
                // this.meetingesTableAdapter.Fill(this.zoomDataSet.meetinges, comboBox1.SelectedValue.ToString());
                this.hostMeetingsAggregateReportTableAdapter.Fill(this.zoomDataSet2.HostMeetingsAggregateReport, FromTimePicker1.Value,comboBox2.SelectedValue.ToString(), TodateTimePicker1.Value);
                this.hostMeetingsDtlReportTableAdapter.Fill(this.zoomDataSet3.HostMeetingsDtlReport,comboBox2.SelectedValue.ToString(), FromTimePicker1.Value,  TodateTimePicker1.Value);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FromdateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TodateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void HostListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HostProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
