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
            CUSTOMERSERVICE = 0,
            PRODUCTSERVICE = 1,
            IDGENERATORSERVICE = 2,
            ORDERSERVICE = 3,
            PAYMENTSERVICE = 4,
            ONLINEWEBAPP = 5,
            MESSAGELOGGER = 6
        };
        //--------------------------------------------------------------------------------------------------------------
        //public enum MicroserviceApps
        //{
        //    CUSTOMERSERVICE = 0,
        //    S = 1,
        //    P = 2
        //};
        //--------------------------------------------------------------------------------------------------------------
    }
}