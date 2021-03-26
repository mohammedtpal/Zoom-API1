using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Security.Cryptography;
using Intuit.Ipp.Core.Configuration;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace Zoom_API1
{
    public partial class Form1 : Form
    {
        String token;
        String uuid;
        string json;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://api.zoom.us/v2/users?status=active&page_size=1");
            client.Timeout = -1;
            token = textBox1.Text;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", "Bearer " + token);
            request.AddHeader("Cookie", "_ga=GA1.2.602023032.1615627572; _zm_lang=en-US; _zm_mtk_guid=678ceca35cff4d3bad9682a37b626b5f; _zm_page_auth=aw1_c_92stiNzOQsCwsSnwKB0sKg; _zm_ssid=aw1_c_sAGbTJcDTLSClprad5dwng; wULrMv6t=AMqP6Cp4AQAA8ys1wvVMt4Wjv9OmLxRlJKSzRn6fiSSwwDg1mIhZMfi6O6Pz|1|0|5f08f6a1f591ba7f7513952af5beaebb8ec69140; cred=5F2225B572FC6CE34AB51DEE1A2C995C");
            IRestResponse response = client.Execute(request);
            label1.Text = response.Content;
            Console.WriteLine(response.Content);
        }
        private static string _clientId = "oZbb4CPiQ8eKxvpv2M0uQ";
     
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String id = "PkcvQ1PST6UeDHo6KCwA";
            String secret = "8vQL6owVE2liRRhr1f6Y5AINWKtYqDXr";

            var client = new RestClient("https://zoom.us/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("https://zoom.us/oauth/authorize", "grant_type=client_credentials&scope=all&client_id=" + id +
                "&client_secret=" + secret, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            dynamic resp = JObject.Parse(response.Content);
            token = resp.access_token;

            label1.Text = token;
            client = new RestClient("https://api.zoom.us/v2/users?status=active&page_size=1");
            request = new RestRequest(Method.GET);
            request.AddHeader("authorization", "Bearer " + token);
            request.AddHeader("cache-control", "no-cache");
            response = client.Execute(request);
            label2.Text = response.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            var client = new RestClient("https://zoom.us/oauth/token?grant_type=authorization_code&code={code}&redirect_uri=https://portal.paluniv.edu.ps");
            //"https://zoom.us/oauth/token?grant_type=authorization_code&code=obBEe8ewaL_KdYKjnimT4KPd8KKdQt9FQ&redirect_uri=https://yourapp.com"
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            // Customer ID
            String customerKey = "oZbb4CPiQ8eKxvpv2M0uQ";
            // Customer secret
            String customerSecret = "cfckpaKiP6xDqYOYd34OUCQInd5arpCi";
            String plainCredentials = customerKey + ":" + customerSecret;
            var plainTextBytes = Encoding.UTF8.GetBytes(plainCredentials);
            string encodedCredential = Convert.ToBase64String(plainTextBytes);
            request.AddHeader("Authorization", "Basic " + encodedCredential);


            IRestResponse response = client.Execute(request);
            //dynamic resp = JObject.Parse(response.Content);
            //token = resp.access_token;
            //token = resp.access_token;
            Console.WriteLine(response.Content);
            label2.Text = token;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "yJhbGciOiJIUzUxMiIsInYiOiIyLjAiLCJraWQiOiJkYjJmYWJjNS1hOWRlLTQ3NjAtOTZkYS03NzE1MTVhM2QxNjcifQ.eyJ2ZXIiOjcsImF1aWQiOiJhNTI2NWJlYzA1ZjIzNWIwYzAzNGRlMzI0NDdmODhiYiIsImNvZGUiOiJjRHBoMkk1dDBwX210UlNlbjFiU2xHTG5NclpVNlVhdkEiLCJpc3MiOiJ6bTpjaWQ6b1piYjRDUGlROGVLeHZwdjJNMHVRIiwiZ25vIjowLCJ0eXBlIjowLCJ0aWQiOjAsImF1ZCI6Imh0dHBzOi8vb2F1dGguem9vbS51cyIsInVpZCI6Im10UlNlbjFiU2xHTG5NclpVNlVhdkEiLCJuYmYiOjE2MTYyMjEwMjIsImV4cCI6MTYxNjIyNDYyMiwiaWF0IjoxNjE2MjIxMDIyLCJhaWQiOiJFdE1PMnlBMFRuTzB2M1FoYnBBeVFBIiwianRpIjoiNGY2MWVhZTMtN2ZkZi00NzI3LTlhNDAtMTk5Nzc1M2YzY2M4In0.rb2WohHacyGqM1_8Zk5V7wKFJxSH0974Yt0JHoQmW6MagGMYsnjvZJa5tRQRQnPgO2C42gWElRZ4nLIKcZT_LA";
            this.instructorsTableAdapter.Fill(this.zoomDataSet1.instructors);
            // TODO: This line of code loads data into the 'zoomDataSet.meetinges' table. You can move, or remove it, as needed.
            //this.meetingesTableAdapter.Fill(this.zoomDataSet.meetinges);

        }









        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                this.meetingesTableAdapter.Fill(this.zoomDataSet.meetinges, comboBox1.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MST\\SQLEXPRESS;Initial Catalog=Zoom;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Save_Meeting_Participants", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@JSON", json);
            cmd.Parameters.AddWithValue("@meeting_uuid", uuid);
            con.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            con.Close();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
       dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                //System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {

                    uuid = (dataGridView1.SelectedRows[i].Cells[0].Value.ToString());

                }
                textBox2.Text = uuid;

                //  MessageBox.Show(uuid, "Selected Rows");
                var client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuid + "/participants?page_size=300&include_fields=<string>");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                token = textBox1.Text;

                request.AddHeader("Authorization", "Bearer " + token);
                IRestResponse response = client.Execute(request);

                //MessageBox.Show(next_page_token.Length.ToString());
                //Console.WriteLine(response.Content);
                System.Net.HttpStatusCode statusCode = response.StatusCode;
                int numericStatusCode = (int)statusCode;
                if (numericStatusCode == 200)
                {
                    json = response.Content;
                    Save_Meeting_Participants();//save
                    var data = JObject.Parse(json);
                    string next_page_token = Convert.ToString(data.SelectToken("next_page_token"));


                    MessageBox.Show(numericStatusCode.ToString());
                    while (next_page_token.Length != 0)
                    {
                        client = new RestClient("https://api.zoom.us/v2/report/meetings/" + uuid + "/participants?page_size=300&next_page_token=" + next_page_token + "&include_fields=<string>");
                        client.Timeout = -1;
                        request = new RestRequest(Method.GET);
                        request.AddHeader("Authorization", "Bearer " + token);
                        response = client.Execute(request);

                        json = response.Content;
                        Save_Meeting_Participants();//save
                        data = JObject.Parse(json);
                        next_page_token = Convert.ToString(data.SelectToken("next_page_token"));

                    }

                }
                else
                    MessageBox.Show(response.Content, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void Save_Meeting_Participants()
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
                con.Close();
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
    }
}
