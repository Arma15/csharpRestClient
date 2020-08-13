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
        [DataMember(Name = "Report")]
        public List<Rreport> Report { get; set; }

        public Rreports()
        {
            Report = new List<Rreport>();
        }
    }

    public class Rreport
    {
        [DataMember(Name = "FileExtensionName")]
        public string FileExtensionName { get; set; }

        [DataMember(Name = "FileName")]
        public string FileName { get; set; }

        [DataMember(Name = "FileContent")]
        public string FileContent { get; set; }
    }

    public class RerrorDetails
    {
        [DataMember(Name = "ErrorCode")]
        public string ErrorCode { get; set; }

        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class RresponseDetails
    {
        [DataMember(Name = "ResponseCode")]
        public string ResponseCode { get; set; }

        [DataMember(Name = "ResponseMessage")]
        public string ResponseMessage { get; set; }
    }

    public class OACResponse
    {
        [DataMember(Name = "OrderNumber")]//
        public string OrderNumber { get; set; }

        [DataMember(Name = "JobNumber")]//
        public string JobNumber { get; set; }

        [DataMember(Name = "SerialNumber")]//
        public string SerialNumber { get; set; }

        [DataMember(Name = "ReportTypes")]//
        public string ReportTypes { get; set; }

        [DataMember(Name = "Reports")]//
        public Rreports Reports { get; set; }

        [DataMember(Name = "ErrorDetails")]//
        public RerrorDetails ErrorDetails { get; set; }

        [DataMember(Name = "ResponseDetails")]//
        public RresponseDetails ResponseDetails { get; set; }

        public OACResponse()
        {
            Reports = new Rreports();
            ErrorDetails = new RerrorDetails();
            ResponseDetails = new RresponseDetails();
        }
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
    public class OACRequest
    {
        /// <summary> Required </summary>
        [DataMember(Name = "OrderNumber")]
        public string OrderNumber { get; set; }

        /// <summary> Required </summary>
        [DataMember(Name = "JobNumber")]
        public string JobNumber { get; set; }

        /// <summary> Required </summary>
        [DataMember(Name = "SerialNumber")]
        public string SerialNumber { get; set; }

        /// <summary> Required -> Static Value: "xml" </summary>
        [DataMember(Name = "ReportTypes")]
        public string ReportTypes { get; set; }

        /*  GE Removed from request json
         * 
         * /// <summary> Not Required </summary>
        [DataMember(Name = "EsetNumber")]
        public string EsetNumber { get; set; }

        /// <summary> Required -> Static Value: "BOP" </summary>
        [DataMember(Name = "OrganizationCode")]
        public string OrganizationCode { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember(Name = "MACAddress")]
        public string MacAddress { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember(Name = "SoftwareExtension")]
        public string SoftwareExtension { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember(Name = "OperatorName")]
        public string OperatorName { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember(Name = "ClientName")]
        public string ClientName { get; set; }

        /// <summary> Required -> Static Value: "3DInfotech" </summary>
        [DataMember(Name = "ClientType")]
        public string ClientType { get; set; }

        /// <summary> Not Required: Null </summary>
        [DataMember(Name = "OrderType")]
        public string OrderType { get; set; }

        /// <summary> Required -> Static Value: "Upgrade" </summary>
        [DataMember(Name = "TransactionType")]
        public string TransactionType { get; set; }

        /// <summary>  Not Required: Null </summary>
        [DataMember(Name = "ForkliftSerialNumber")]
        public string ForkliftSerialNumber { get; set; }
*/
        /// <summary>
        /// Per GE, these fields values are defaulted
        /// </summary>
        public OACRequest()
        {
            OrderNumber = "";
            JobNumber = "";
            SerialNumber = "";
            ReportTypes = "xmL";
        }

        public override string ToString()
        {
            string s = $"{{\"OrderNumber\": \"{OrderNumber}\","
                + $"\"JobNumber\": \"{JobNumber}\","
                + $"\"SerialNumber\": \"{SerialNumber}\","
                + $"\"ReportTypes\": \"{ReportTypes}\"}}";
            return s;
        }
        /*
          
        Input Json  -- New
        {
            "OrderNumber": "4782158",            Varies ********
            "JobNumber": "BOP18078613",          Varies ********
            "SerialNumber": "SPX19300147SA",     Varies ********
            "ReportTypes": "xml"                 Static
        }
          
        Request json -- Old
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