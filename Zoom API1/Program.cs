using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
    // Reference to CodeGrantFlow DLL
using Newtonsoft.Json;

namespace Zoom_API1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static string _clientId = "oZbb4CPiQ8eKxvpv2M0uQ";

        private static string _storedRefreshToken = null;
        private static CodeGrantOauth _tokens = null;
        private static DateTime _tokenExpiration;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            try
            {
                // TODO: Add logic to get the logged on user's refresh token 
                // from secured storage. 

                //_tokens = GetOauthTokens(_storedRefreshToken, _clientId);


                //Console.WriteLine("access token:" + _tokens.AccessToken.Substring(0, 15) + "...");
                //Console.WriteLine("refresh token: " + _tokens.RefreshToken.Substring(0, 15) + "...");
                //Console.WriteLine("token expires: " + _tokens.Expiration);
                Application.Run(new mainForm());
            }
            catch (Exception e)
            {
                Console.WriteLine("\n" + e.Message);
            }
        }
        private static CodeGrantOauth GetOauthTokens(string refreshToken, string clientId)
        {
            CodeGrantOauth auth = new CodeGrantOauth(clientId);

            if (string.IsNullOrEmpty(refreshToken))
            {
                auth.GetAccessToken();
            }
            else
            {
                auth.RefreshAccessToken(refreshToken);

                // Refresh tokens can become invalid for several reasons
                // such as the user's password changed.

                if (!string.IsNullOrEmpty(auth.Error))
                {
                    auth = GetOauthTokens(null, clientId);
                }
            }

            // TODO: Store the new refresh token in secured storage
            // for the logged on user.

            if (!string.IsNullOrEmpty(auth.Error))
            {
                throw new Exception(auth.Error);
            }
            else
            {
                _storedRefreshToken = auth.RefreshToken;
                _tokenExpiration = DateTime.Now.AddSeconds(auth.Expiration);
            }

            return auth;
        }
    }
}
