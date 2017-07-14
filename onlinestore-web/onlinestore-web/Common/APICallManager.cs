using Newtonsoft.Json.Linq;
using onlinestore_web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using static onlinestore_web.Common.Types;

namespace onlinestore_web.Common
{
    public class APICallManager
    {
        public APICallManager()
        {

        }

        public string CallAPI(string URL, APIMethod Method, string InputJson, Boolean AddHeader = false)
        {
            try
            {
                WebClient client = new WebClient();
                if (AddHeader)
                {
                    
                    IPHostEntry HostInfo = Dns.GetHostEntry(Dns.GetHostName());
                    Guid GUID = Guid.NewGuid();
                    client.Headers.Add("Content-Type", "application/xml");
                    client.Headers.Add("Accept-Charset", "utf-8");
                    client.Headers.Add("Token", GUID.ToString());
                    client.Headers.Add("Server", HostInfo.ToString());
                }
                string webResponse="";
                if (Method == APIMethod.GET)
                {
                    webResponse = client.DownloadString(URL);
                }
                return webResponse;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }



    }
}
