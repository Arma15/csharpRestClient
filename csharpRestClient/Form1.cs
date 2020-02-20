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
        public OAuthToken rslt = new OAuthToken();
        public OACResponse rslt2 = new OACResponse();
        OACRequest req = new OACRequest();

        string localHost = "https://localhost:44334/api/Response";
        public Form1()
        {
            InitializeComponent();
            //RequestURI.Text = localHost;




            OrderNumbertxt.Text = req.OrderNumber;
            JobNumbertxt.Text = req.JobNumber;
            SerialNumbertxt.Text = req.SerialNumber;

        }
        #region UI Event Methods
        private void cmdGO_Click(object sender, EventArgs e)
        {
            // string tokenUrl = "https://fssfed.ge.com/fss/as/token.oauth2?grant_type=client_credentials&client_id=OAC_3dInfotech&client_secret=OAC_3dInfotechSecret&scope=api";
            // string oacUrl = "https://fssfed.stage.ge.com/fss/as/token.oauth2?grant_type=client_credentials&client_id=clientidvalue&client_secret=clientsecreat&scope=api";
            // RestSharp library
            // RestClient tokenClient = new RestClient(tokenUrl);
            
            if (TokenRadio.Checked)
            {
                TokenRequest();
            }
            else if (MessageRadio.Checked)
            {
                MessageRequest();
            }

        }
        #endregion

        private void TokenRequest()
        {
            try
            {
                // ************************* Test Token Code ******************************************
                var oacRequest = new RestRequest(Method.POST);
                string requestURI = RequestURI.Text.Trim();
                string clientID = ClientID.Text.Trim();
                string clientSecret = ClientSecret.Text.Trim();
                if (!Int32.TryParse(ReportIndex.Text.Trim(), out int index))
                {
                    MessageBox.Show("Error Report Index invalid.");
                }

                if (requestURI == "")
                {
                    MessageBox.Show("Error Request URI not set.");
                    return;
                }

                if (clientID == "" || clientSecret == "")
                {
                    MessageBox.Show("Error Client ID or Client secret not set.");
                    return;
                }

                RestClient oacClient = new RestClient(requestURI);

                oacRequest.AddQueryParameter(clientID, clientSecret);
                //oacRequest.AddHeader("ClientSecret", "password");

                IRestResponse responseJson = oacClient.Execute(oacRequest);
                if (!responseJson.IsSuccessful)
                {
                    MessageBox.Show($"Request not successful, Exception: {responseJson.ErrorMessage}");
                    ResponseCode.Text = responseJson.StatusCode.ToString();
                    return;
                }

                try
                {
                    rslt = JsonConvert.DeserializeObject<OAuthToken>(responseJson.Content);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Deserializing issue..response is defaulted.\n" + Ex.Message.ToString());
                }

                ResponseCode.Text = responseJson.StatusCode.ToString();
                txtResponse.Text += "Access Token: " + rslt.Access_Token + Environment.NewLine;
                txtResponse.Text += "Token Type: " + rslt.Token_Type + Environment.NewLine;
                txtResponse.Text += "Expires in: " + rslt.Expires_In + Environment.NewLine + Environment.NewLine;
                HeaderValuetxt.Text = rslt.Token_Type + " " + rslt.Access_Token;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void MessageRequest()
        {
            try
            {
                // ************************* Test Message Code ******************************************
                var oacRequest = new RestRequest(Method.POST);
                string requestURI = RequestURI.Text.Trim();
                

                if (!Int32.TryParse(ReportIndex.Text.Trim(), out int index))
                {
                    MessageBox.Show("Error Report Index invalid.");
                }

                if (requestURI == "")
                {
                    MessageBox.Show("Error Request URI not set.");
                    return;
                }

                if (HeaderNametxt.Text.Trim() == "" || HeaderValuetxt.Text.Trim() == "")
                {
                    MessageBox.Show("Error Header name and/or value not set.");
                    return;
                }

                RestClient oacClient = new RestClient(requestURI);

                oacRequest.AddHeader(HeaderNametxt.Text.Trim(), HeaderValuetxt.Text.Trim());
                oacRequest.AddJsonBody(req.ToString());

                IRestResponse responseJson = oacClient.Execute(oacRequest);
                if (!responseJson.IsSuccessful)
                {
                    MessageBox.Show($"Request not successful, Exception: {responseJson.ErrorMessage}");
                    return;
                }

                try
                {
                    rslt2 = JsonConvert.DeserializeObject<OACResponse>(responseJson.Content);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Deserializing issue..response is defaulted.\n" + Ex.Message.ToString());
                }

                ResponseCode.Text = responseJson.StatusCode.ToString();
                txtResponse.Text += "Org Code: " + rslt2.OrganizationCode + Environment.NewLine;
                txtResponse.Text += "Serial Number: " + rslt2.SerialNumber + Environment.NewLine;
                txtResponse.Text += "Error Details.ErrorCode: " + rslt2.ErrorDetails.ErrorCode + Environment.NewLine;
                txtResponse.Text += "Error Details.ErrorMessage: " + rslt2.ErrorDetails.ErrorMessage + Environment.NewLine;
                txtResponse.Text += "ResponseDetails.ResponseCode: " + rslt2.ResponseDetails.ResponseCode + Environment.NewLine;
                txtResponse.Text += "ResponseDetails.ResponseMessage: " + rslt2.ResponseDetails.ResponseMessage + Environment.NewLine;
                txtResponse.Text += "Operator Name: " + rslt2.OperatorName + Environment.NewLine + Environment.NewLine;

                try
                {
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileExtensionName: " + rslt2.Reports.Report[index].FileExtensionName + Environment.NewLine;
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileName: " + rslt2.Reports.Report[index].FileName + Environment.NewLine;
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileContent: " + rslt2.Reports.Report[index].FileContent + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private string GetString()
        {
            string s = $"\"EsetNumber\": \"\","
                + $"\"OrderNumber\": \"4782158\","
                + $"\"OrganizationCode\": \"BOP\","
                + $"\"JobNumber\": \"BOP18078613\","
                + $"\"SerialNumber\": \"SPX19300147SA\","
                + $"\"MACAddress\": \"Null\","
                + $"\"SoftwareExtension\": \"Null\","
                + $"\"OperatorName\": \"3DInfotech\","
                + $"\"ClientName\": \"3DInfotech\","
                + $"\"ClientType\": \"3DInfotech\","
                + $"\"OrderType\": \"Null\","
                + $"\"TransactionType\": \"Upgrade\","
                + $"\"ForkliftSerialNumber\": \"null\","
                + $"\"ReportTypes\": \"xml\"";
            return s;
        }

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

        private void TokenRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (TokenRadio.Checked)
            {
                MessageRadio.Checked = false;
            }
        }

        private void MessageRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageRadio.Checked)
            {
                TokenRadio.Checked = false;
            }
        }

        private void Deserialize_Click(object sender, EventArgs e)
        {
            try
            {
                // File content contains base 64 encoded xml to retrieve info
                string encoded = rslt2.Reports.Report[0].FileContent;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when deserializing. Error: " + ex.Message.ToString());
            }
        }
    }
}

/*
                // File content contains base 64 encoded xml to retrieve info
                string encoded = rslt.Reports.Report[0].FileContent;
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



*/

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
