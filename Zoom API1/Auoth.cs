using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_API1
{
    public partial class Auoth : Form
    {
        public Auoth()
        {
            InitializeComponent();
        }
        WebBrowser _browser = null;
        string _uri = string.Format("https://zoom.us/oauth/authorize?response_type=code&client_id=oZbb4CPiQ8eKxvpv2M0uQ&redirect_uri=https://portal.paluniv.edu.ps");




        //private static AccessTokens GetTokens(string uri, string body)
        //{
        //    AccessTokens tokens = null;
        //    var request = (HttpWebRequest)WebRequest.Create(uri);
        //    request.Method = "POST";
        //    request.Accept = "application/json";
        //    request.ContentType = "application/x-www-form-urlencoded";

        //    request.ContentLength = body.Length;

        //    using (Stream requestStream = request.GetRequestStream())
        //    {
        //        StreamWriter writer = new StreamWriter(requestStream);
        //        writer.Write(body);
        //        writer.Close();
        //    }

        //    var response = (HttpWebResponse)request.GetResponse();

        //    using (Stream responseStream = response.GetResponseStream())
        //    {
        //        var reader = new StreamReader(responseStream);
        //        string json = reader.ReadToEnd();
        //        reader.Close();
        //        tokens = JsonConvert.DeserializeObject(json, typeof(AccessTokens)) as AccessTokens;
        //    }

        //    return tokens;
        //}

        private void Auoth_Load(object sender, EventArgs e)
        {

        }
        private string RedirectPath = "/oauth20_desktop.srf";
        private string _authorizationCode = null;
        private string _error = null;
        private string ErrorPath = "/err.srf";
        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Dictionary<string, string> parameters = null;

            if (!string.IsNullOrEmpty(e.Url.Query))
            {
                parameters = ParseFragment(e.Url.Query, new char[] { '&', '?' });
            }

            if (e.Url.AbsolutePath.Equals(RedirectPath))
            {
                if (parameters.ContainsKey("code"))
                {
                    this._authorizationCode = parameters["code"];
                }
                else if (parameters.ContainsKey("error_description"))
                {
                    this._error = WebUtility.UrlDecode(parameters["error_description"]);
                }

                this.Close();
            }
            else if (e.Url.AbsolutePath.Equals(ErrorPath))
            {
                if (parameters.ContainsKey("error_description"))
                {
                    this._error = WebUtility.UrlDecode(parameters["error_description"]);
                    this.Close(); ;
                }
            }
        }


        private Dictionary<string, string> ParseFragment(string queryString, char[] delimeters)
        {
            var parameters = new Dictionary<string, string>();

            string[] pairs = queryString.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);

            foreach (string pair in pairs)
            {
                string[] nameValaue = pair.Split(new char[] { '=' });
                parameters.Add(nameValaue[0], nameValaue[1]);
            }

            return parameters;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string token;
            var client = new RestClient("https://zoom.us/oauth/token?grant_type=authorization_code&code=" + textBox4.Text + "&redirect_uri=https://portal.paluniv.edu.ps");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            String customerKey = "oZbb4CPiQ8eKxvpv2M0uQ";
            String customerSecret = "cfckpaKiP6xDqYOYd34OUCQInd5arpCi";
            String plainCredentials = customerKey + ":" + customerSecret;
            var plainTextBytes = Encoding.UTF8.GetBytes(plainCredentials);
            string encodedCredential = Convert.ToBase64String(plainTextBytes);
            request.AddHeader("Authorization", "Basic " + encodedCredential);
            IRestResponse response = client.Execute(request);
            dynamic resp = JObject.Parse(response.Content);
            token = resp.access_token;
            //token = resp.access_token;
            Console.WriteLine(response.Content);
            textBox3.Text = token;
            ZoomAPI.SaveToken(token);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            this._browser = new WebBrowser();
            this._browser.Dock = DockStyle.Bottom;
            this._browser.Navigated += new WebBrowserNavigatedEventHandler(browser_Navigated);
            this._browser.Navigate(this._uri);
            Application.EnableVisualStyles();

            this.Controls.AddRange(new Control[] { this._browser });
        }

        private void Auoth_Load_1(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = ("https://zoom.us/oauth/authorize?response_type=code&client_id=oZbb4CPiQ8eKxvpv2M0uQ&redirect_uri=https://portal.paluniv.edu.ps");
            Process.Start(s);
        }
    }



}
