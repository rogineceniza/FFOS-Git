using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FFOSproj
{
    public partial class forgotPassword : Form
    {
        private string randomCode;
        public static string to;

        public forgotPassword()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            var forgotPassword = new adminLogin();
            forgotPassword.ShowDialog();

            forgotPassword.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Scopes = { GmailService.Scope.GmailSend };
            string ApplicationName = "Pizzeria System";
            string ClientId = "16583251568-77b1rlaoh81ec8qqt255aba2g4057hle.apps.googleusercontent.com";
            string ClientSecret = "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";
            string UserEmail = "cenizamahinay@gmail.com";
            string ToEmail = "cenizamahinay@gmail.com";
            string Subject = "Verification Code";
            randomCode = GenerateRandomCode();
            string Body = "Your Verification Code is: " + randomCode;

            try
            {
                UserCredential credential;

                using (var stream = new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
                {
                    string credPath = "token.json";
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                        GoogleClientSecrets.Load(stream).Secrets,
                        Scopes,
                        UserEmail,
                        CancellationToken.None,
                        new FileDataStore(credPath, true)).Result;
                    Console.WriteLine("Credential file saved to: " + credPath);
                }

                var service = new GmailService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = ApplicationName,
                });

                Google.Apis.Gmail.v1.Data.Message message = CreateEmail(ToEmail, UserEmail, Subject, Body);
                message = service.Users.Messages.Send(message, UserEmail).Execute();
                MessageBox.Show("Email sent!");
            }
            catch (GoogleApiException ex)
            {
                MessageBox.Show($"Gmail API error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private static string GenerateRandomCode()
        {
            Random randomCode = new Random();
            return randomCode.Next(100000, 999999).ToString();
        }

        public static Google.Apis.Gmail.v1.Data.Message CreateEmail(string to, string from, string subject, string body)
        {
            var msg = new Google.Apis.Gmail.v1.Data.Message();
            msg.Raw = Base64UrlEncode(string.Format("From: {0}\r\nTo: {1}\r\nSubject: {2}\r\n\r\n{3}", from, to, subject, body));
            return msg;
        }

        public static string Base64UrlEncode(string input)
        {
            var inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
            // Use the URL-safe base64 encoding without padding.
            return Convert.ToBase64String(inputBytes)
              .Replace('+', '-')
              .Replace('/', '_')
              .Replace("=", "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the verification code is correct
            if (textBox2.Text == randomCode)
            {
                // Reset the password
                // ...

                MessageBox.Show("Verification code is correct!");

                // Clear the verification code textbox
                textBox2.Clear();

                this.Hide();

                var forgotPassword = new changePassword();
                forgotPassword.ShowDialog();

                forgotPassword.Close();
            }
            else
            {
                MessageBox.Show("Verification code is incorrect!");
            }
        }
    }
    
}
