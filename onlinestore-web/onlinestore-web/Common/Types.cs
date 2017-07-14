using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace onlinestore_web.Common
{
    public class Types
    {
        public string EurekaURL = @"http://tcs-poc-ms-eurekaserver.com/eureka/apps/";
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
        public enum MicroserviceApps
        {
            EUREKASERVER = 0,
            CUSTOMERSERVICE = 1,
            PRODUCTSERVICE = 2,
            IDGENERATORSERVICE = 3,
            ORDERSERVICE = 4,
            PAYMENTSERVICE = 5,
            ONLINEWEBAPP = 6,
            MESSAGELOGGER = 7
        };
        //--------------------------------------------------------------------------------------------------------------

        //--------------------------------------------------------------------------------------------------------------
    }
}