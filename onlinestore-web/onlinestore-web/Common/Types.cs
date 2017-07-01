using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlinestore_web.Common
{
    public class Types
    {
        //public Type APIHeader()
        //{
        //    string ContentType;
        //    string AcceptCHarset;
        //    string Token;
        //    string Server;
        //}
        //--------------------------------------------------------------------------------------------------------------
        public enum APIMethod
        {
            POST = 0,
            PUT = 1,
            GET = 2
        };
        //--------------------------------------------------------------------------------------------------------------
        public enum CustomerAccountType
        {
            B = 0,
            S = 1,
            P = 2
        };
        //--------------------------------------------------------------------------------------------------------------
        public enum EurekaURLs
        {
            B = 0,
            S = 1,
            P = 2
        };
        //--------------------------------------------------------------------------------------------------------------

    }
}