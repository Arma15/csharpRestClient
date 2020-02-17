using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Linq;
using RestSharp;

namespace csharpRestClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region UI Event Methods
        private void cmdGO_Click(object sender, EventArgs e)
        {
            string tokenUrl = "https://fssfed.ge.com/fss/as/token.oauth2?grant_type=client_credentials&client_id=OAC_3dInfotech&client_secret=OAC_3dInfotechSecret&scope=api";
            string oacUrl = "https://localhost:44334/api/Response";

            //RestSharp library
            var tokenClient = new RestClient(tokenUrl);
            var oacClient = new RestClient(oacUrl);
            
            try
            {
                // ************************* Test Code ******************************************
                var oacRequest = new RestRequest();
                oacRequest.Method = Method.POST;
                
                oacRequest.AddHeader("ClientID", "12345");
                //oacRequest.AddHeader("ClientSecret", "password");


                var responseJson = oacClient.Execute(oacRequest);
                var rslt = JsonConvert.DeserializeObject<OACResponse>(responseJson.Content);
                // File content contains base 64 encoded xml to retrieve info
                string encoded = rslt.Reports.Report[1].FileContent;
                // Decode the message into byte array
                var decoded = Convert.FromBase64String(encoded);
                // Convert byte array to string
                string xmlMessage = Encoding.Default.GetString(decoded);
                // Parse the message (in XML)
                var str = XElement.Parse(xmlMessage);
                // find specific tags
                var itemNumber = str.Element("ITEM_DETAILS").Element("ITEM_NUMBER");
                var serialNumber = str.Element("SERIAL_NUMBER");
                Console.WriteLine("ITEM_NUMBER = " + itemNumber.FirstNode);
                Console.WriteLine("SERIAL_NUMBER = " + serialNumber.FirstNode);

                /************************** Real code *******************************************
                var tokenRequest = new RestRequest();
                var oacRequest = new RestRequest();

                tokenRequest.Method = Method.POST;
                tokenRequest.AddHeader("ClientID", "ClientSecret");

                var tokenResponse = tokenClient.Execute(tokenRequest);
                var token = JsonConvert.DeserializeObject<OAuthToken>(tokenResponse.Content);

                oacRequest.Method = Method.POST;
                oacRequest.AddHeader("Authorization", token.Token_Type + " " + token.Access_Token);

                var responseJson = oacClient.Execute(oacRequest);
                var rslt = JsonConvert.DeserializeObject<OACResponse>(responseJson.Content);

                // File content contains base 64 encoded xml to retrieve info
                string encoded = rslt.Reports.Report[1].FileContent;
                // Decode the message into byte array
                var decoded = Convert.FromBase64String(encoded);
                // Convert byte array to string
                string xmlMessage = Encoding.Default.GetString(decoded);
                // Parse the message (in XML)
                var str = XElement.Parse(xmlMessage);
                // find specific tags
                var result = str.Element("ITEM_DETAILS").Element("ITEM_NUMBER");
                Console.WriteLine(result.FirstNode);
                */

                //debugOutput($"EsetNumber is: " + rslt.EsetNumber);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        #endregion

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtResponse.Text = txtResponse.Text + strDebugText + Environment.NewLine;
                txtResponse.SelectionStart = txtResponse.TextLength;
                txtResponse.ScrollToCaret();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

    }
}
