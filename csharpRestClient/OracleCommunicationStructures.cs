using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace csharpRestClient
{
    public class Rreports
    {
        public List<Rreport> Report { get; set; }
        public Rreports()
        {
            Report = new List<Rreport>();
        }
    }

    public class Rreport
    {
        public string FileExtensionName { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
    }

    public class RerrorDetails
    {
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RresponseDetails
    {
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
    public class OACResponse
    {
        public int EsetNumber { get; set; }
        public string OrderNumber { get; set; }
        public string OrganizationCode { get; set; }
        public string JobNumber { get; set; }
        public string SerialNumber { get; set; }
        public string MACAddress { get; set; }
        public string SoftwareExtension { get; set; }
        public string OperatorName { get; set; }
        public string ClientName { get; set; }
        public string ClientType { get; set; }
        public string OrderType { get; set; }
        public string TransactionType { get; set; }
        public string ForkliftSerialNumber { get; set; }
        public string ReportTypes { get; set; }
        public Rreports Reports { get; set; }
        public RerrorDetails ErrorDetails { get; set; }
        public RresponseDetails ResponseDetails { get; set; }

        public OACResponse()
        {
            Reports = new Rreports();
            ErrorDetails = new RerrorDetails();
            ResponseDetails = new RresponseDetails();

        }

        /*public OACResponse()
        {
            EsetNumber = 69;
            OrderNumber = null;
            OrganizationCode = "HEL";
            JobNumber = "J16997582";
            SerialNumber = "SJ419030011WA";
            MACAddress = null;
            SoftwareExtension = null;
            OperatorName = "eDelivery";
            ClientName = "eDelivery";
            ClientType = "eDelivery";
            OrderType = null;
            TransactionType = "Upgrade";
            ForkliftSerialNumber = null;
            ReportTypes = "xml";
            Reports = new Rreports
            {
                Report = new List<Rreport>
                    {
                        new Rreport
                        {
                            FileExtensionName = "xml",
                            FileName = "SJ419030011WA_OAC.xml",
                            FileContent = "******"
                        }
                    }
            };
            ErrorDetails = new RerrorDetails
            {
                ErrorCode = null,
                ErrorMessage = null
            };
            ResponseDetails = new RresponseDetails
            {
                ResponseCode = 200,
                ResponseMessage = "Success"
            };
        }*/

        /*
        {
            "EsetNumber": "1",
            "OrderNumber": null,
            "OrganizationCode": "HEL",
            "JobNumber": "J16997582",
            "SerialNumber": "SJ419030011WA",
            "MACAddress": null,
            "SoftwareExtension": null,
            "OperatorName": "eDelivery",
            "ClientName": "eDelivery",
            "ClientType": "eDelivery",
            "OrderType": null,
            "TransactionType": "Upgrade",
            "ForkliftSerialNumber": null,
            "ReportTypes": "xml",
            "Reports": 
            {
                "Report": 
                [{
                    "FileExtensionName": "xml",
                    "FileName": "SJ419030011WA_OAC.xml",
                    "FileContent": ****** 
                }]
            },
            "ErrorDetails":    
            {
                "ErrorCode": null,
                "ErrorMessage": null
            },   
            "ResponseDetails":    
            {
                "ResponseCode": 200,
                "ResponseMessage": "Success"
            }
        }
        */
    }

    [DataContract]
    public class OAuthToken
    {
        [DataMember(Name = "access_token")]
        public string Access_Token { get; set; }
        [DataMember(Name = "token_type")]
        public string Token_Type { get; set; }
        [DataMember(Name = "expires_in")]
        public int Expires_In { get; set; }
    }

    /******************************************************************************************
    * OAC Request Class
    ******************************************************************************************/
    [DataContract]
    class OACRequest
    {
        /// <summary> Not Required </summary>
        [DataMember]
        public string EsetNumber { get; set; }

        /// <summary> Required </summary>
        [DataMember]
        public string OrderNumber { get; set; }

        /// <summary> Required -> Static Value: "BOP" </summary>
        [DataMember]
        public string OrganizationCode { get; set; }

        /// <summary> Required </summary>
        [DataMember]
        public string JobNumber { get; set; }

        /// <summary> Required </summary>
        [DataMember]
        public string SerialNumber { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember]
        public string MacAddress { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember]
        public string SoftwareExtension { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember]
        public string OperatorName { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember]
        public string ClientName { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember]
        public string ClientType { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember]
        public string OrderType { get; set; }

        /// <summary> Required -> Static Value: "Upgrade" </summary>
        [DataMember]
        public string TransactionType { get; set; }

        /// <summary>  Not Required: Null </summary>
        [DataMember]
        public string ForkliftSerialNumber { get; set; }

        /// <summary> Required -> Static Value: "xml" </summary>
        [DataMember]
        public string ReportTypes { get; set; }

        public OACRequest()
        {
            EsetNumber = "";
            OrderNumber = "A0659PA";
            OrganizationCode = "UMM";
            JobNumber = "";
            SerialNumber = "15012020OX1";
            MacAddress = "";
            SoftwareExtension = "";
            OperatorName = "3DInfotech";
            ClientName = "3DInfotech";
            ClientType = "3DInfotech";
            OrderType = "";
            TransactionType = "Upgrade";
            ForkliftSerialNumber = "";
            ReportTypes = "xmL";
        }

        public override string ToString()
        {
            string s = $"\"EsetNumber\": \"{EsetNumber}\","
                + $"\"OrderNumber\": \"{OrderNumber}\","
                + $"\"OrganizationCode\": \"{OrganizationCode}\","
                + $"\"JobNumber\": \"{JobNumber}\","
                + $"\"SerialNumber\": \"{SerialNumber}\","
                + $"\"MACAddress\": \"{MacAddress}\","
                + $"\"SoftwareExtension\": \"{SoftwareExtension}\","
                + $"\"OperatorName\": \"{OperatorName}\","
                + $"\"ClientName\": \"{ClientName}\","
                + $"\"ClientType\": \"{ClientType}\","
                + $"\"OrderType\": \"{OrderType}\","
                + $"\"TransactionType\": \"{TransactionType}\","
                + $"\"ForkliftSerialNumber\": \"{ForkliftSerialNumber}\","
                + $"\"ReportTypes\": \"{ReportTypes}\"";
            return s;
        }
        /*
         * 
Input Json
{
"EsetNumber": "",                    Not required
"OrderNumber": "4782158",            Varies ********
"OrganizationCode": "BOP",           Static
"JobNumber": "BOP18078613",          Varies ********
"SerialNumber": "SPX19300147SA",     Varies ********
"MACAddress": "Null",                Not required
"SoftwareExtension": "Null",         Not required
"OperatorName": "3DInfotech",        Static
"ClientName": "3DInfotech",          Static
"ClientType": "3DInfotech",          Static
"OrderType": "Null",                 Not required
"TransactionType": "Upgrade",        Static
"ForkliftSerialNumber": "null",      Not required
"ReportTypes": "xml"                 Static
}
         * 
         Request json
        {
            "EsetNumber" : "1",
            "OrderNumber" : null,
            "OrganizationCode" : "HEL",
            "JobNumber" : "J16997582",
            "SerialNumber" : "SJ419030011WA",
            "MACAddress" : null,
            "SoftwareExtension" : null,
            "OperatorName" : "eDelivery",
            "ClientName" : "eDelivery",
            "ClientType" : "eDelivery",
            "OrderType" : null,
            "TransactionType" : "Upgrade",
            "ForkliftSerialNumber" : null,
            "ReportTypes" : "xml"
        }
         */
    }
}