using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        //public OAuthToken rslt = new OAuthToken();
        //public OACResponse rslt2 = new OACResponse();
        OACRequest req = new OACRequest();
        OACResponse rslt2 = new OACResponse();
        public List<string> itemNumbers;

        string localHost = "https://localhost:44334/api/Response";
        public Form1()
        {
            InitializeComponent();
            //RequestURI.Text = localHost;
            itemNumbers = new List<string>();
            OrderNumbertxt.Text = req.OrderNumber;
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
                LogBox.Text += "Request URI: " + requestURI + Environment.NewLine;
                string clientID = ClientID.Text.Trim();
                LogBox.Text += "Client ID: " + clientID + Environment.NewLine;
                string clientSecret = ClientSecret.Text.Trim();
                LogBox.Text += "Client Secret: " + ClientSecret + Environment.NewLine;
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
                LogBox.Text += "RestClient Created" + Environment.NewLine;
                oacRequest.AddQueryParameter(clientID, clientSecret);
                LogBox.Text += "Query params added " + Environment.NewLine;
                //oacRequest.AddHeader("ClientSecret", "password");

                IRestResponse responseJson = oacClient.Execute(oacRequest);
                LogBox.Text += "RestClient executed " + Environment.NewLine;
                if (!responseJson.IsSuccessful)
                {
                    MessageBox.Show($"Request not successful, Exception: {responseJson.ErrorMessage}");
                    ResponseCode.Text = responseJson.StatusCode.ToString();
                    LogBox.Text += "Execution request not successful" + Environment.NewLine;
                    return;
                }
                else
                {
                    LogBox.Text += "Execution request successful" + Environment.NewLine;
                    LogBox.Text += "Response details: " + Environment.NewLine;
                    LogBox.Text += "Status Code: " + responseJson.StatusCode + Environment.NewLine;
                    LogBox.Text += "Headers: " + responseJson.Headers.ToString() + Environment.NewLine;
                }

                OAuthToken rslt = new OAuthToken();

                try
                {
                    rslt = JsonConvert.DeserializeObject<OAuthToken>(responseJson.Content);
                    LogBox.Text += "deserializing completed " + Environment.NewLine;
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
                LogBox.Text += "Request URI: " + requestURI  + Environment.NewLine;

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
                LogBox.Text += "Added Header Name/Value: " + HeaderNametxt.Text + " " + HeaderValuetxt.Text + Environment.NewLine;

                oacRequest.AddJsonBody(req);
                LogBox.Text += "Added Json body: " + req.ToString() + Environment.NewLine + Environment.NewLine;

                IRestResponse responseJson = oacClient.Execute(oacRequest);
                LogBox.Text += "Request sent" + Environment.NewLine;

                if (!responseJson.IsSuccessful)
                {
                    MessageBox.Show($"Request not successful, Exception: {responseJson.ErrorMessage}");
                    ResponseCode.Text = responseJson.StatusCode.ToString();
                    LogBox.Text += "Execution request not successful" + Environment.NewLine;
                    return;
                }
                else
                {
                    LogBox.Text += "Execution request successful" + Environment.NewLine;
                    LogBox.Text += "Response details: " + Environment.NewLine;
                    LogBox.Text += "Status Code: " + responseJson.StatusCode + Environment.NewLine;
                    LogBox.Text += "Headers: " + responseJson.Headers.ToString() + Environment.NewLine;
                }
                LogBox.Text += "Response content: " + Environment.NewLine;
                LogBox.Text += responseJson.Content.ToString() + Environment.NewLine + Environment.NewLine;
                try
                {
                    LogBox.Text += "Deserializing response " + Environment.NewLine;
                    rslt2 = JsonConvert.DeserializeObject<OACResponse>(responseJson.Content);
                }
                catch (Exception Ex)
                {
                    LogBox.Text += "Deserializing response failed: " + Ex.Message.ToString() + Environment.NewLine;
                    MessageBox.Show("Deserializing issue..response is defaulted.\n" + Ex.Message.ToString());
                }

                ResponseCode.Text = responseJson.StatusCode.ToString();
                txtResponse.Text += "Serial Number: " + rslt2.SerialNumber + Environment.NewLine;
                txtResponse.Text += "Error Details.ErrorCode: " + rslt2.ErrorDetails.ErrorCode + Environment.NewLine;
                txtResponse.Text += "Error Details.ErrorMessage: " + rslt2.ErrorDetails.ErrorMessage + Environment.NewLine;
                txtResponse.Text += "ResponseDetails.ResponseCode: " + rslt2.ResponseDetails.ResponseCode + Environment.NewLine;
                txtResponse.Text += "ResponseDetails.ResponseMessage: " + rslt2.ResponseDetails.ResponseMessage + Environment.NewLine;

                try
                {
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileExtensionName: " + rslt2.Reports.Report[index].FileExtensionName + Environment.NewLine;
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileName: " + rslt2.Reports.Report[index].FileName + Environment.NewLine;
                    txtResponse.Text += $"ResponseDetails.Reports.Report[{index}].FileContent: " + rslt2.Reports.Report[index].FileContent + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception ex)
                {
                    LogBox.Text += "Indexing exception: " + ex.Message.ToString() + Environment.NewLine;
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            catch (Exception ex)
            {
                LogBox.Text += "Main exception: " + ex.Message.ToString() + Environment.NewLine;
                MessageBox.Show(ex.Message.ToString());
            }
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
            catch (Exception ex)
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
                if (rslt2 == null || rslt2.Reports == null || rslt2.Reports.Report == null || rslt2.Reports.Report[0].FileContent == null)
                {
                    // Error OAC response or member is null
                    LogBox.Text += "Error: OAC response or member is null.." + Environment.NewLine;
                }

                // File content contains base 64 encoded xml to retrieve info
                string encoded = rslt2.Reports.Report[0].FileContent;

                LogBox.Text += "File Content: " + Environment.NewLine;
                LogBox.Text += encoded + Environment.NewLine + Environment.NewLine;

                // Decode the message into byte array
                var decoded = Convert.FromBase64String(encoded);

                // Convert byte array to string
                string xmlMessage = Encoding.Default.GetString(decoded);
                if (xmlMessage.Trim() == "")
                {
                    LogBox.Text += "**** xml message is empty ****" + Environment.NewLine;
                }
                LogBox.Text += "xml message decoded is: " + Environment.NewLine;
                LogBox.Text += xmlMessage + Environment.NewLine + Environment.NewLine;

                // Parse the message (in XML) MAKE SURE xmlMessage is NOT NULL
                try
                {
                    XElement str = XElement.Parse(xmlMessage);
                    LogBox.Text += "xml parsed." + Environment.NewLine;
                    // find specific tag
                    foreach (XElement XE in str.Elements("LABEL"))
                    {
                        string number = XE.Descendants("ITEM_NUMBER").FirstOrDefault()?.Value;
                        string xmltag = XE.Descendants("XML_TAG").FirstOrDefault()?.Value;
                        itemNumbers.Add(number);
                    }

                    txtResponse.Text += "Item numbers found: " + (itemNumbers.Count == 0 ? "None" : "") + Environment.NewLine;
                    foreach (string item in itemNumbers)
                    {
                        txtResponse.Text += item + Environment.NewLine;
                    }
                }
                catch (Exception ex)
                {
                    LogBox.Text += Environment.NewLine + "Exception thrown when parsing. Message: " + ex.Message.ToString() + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception when deserializing. Message: " + ex.Message.ToString());
            }
        }

        private void OrderNumbertxt_TextChanged(object sender, EventArgs e)
        {
            req.OrderNumber = OrderNumbertxt.Text;
        }

        private void SerialNumbertxt_TextChanged(object sender, EventArgs e)
        {
             req.SerialNumber = SerialNumbertxt.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LogBox.Text = "";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            RequestURI.Text = "";
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
