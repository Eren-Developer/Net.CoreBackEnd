using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "";
        public static string ProductNameInvalid = "";
        public static string MaintenanceTime="";
        public static string ProductsListed="";
        public static string AuthorizationDenied="";
        public static string UserRegistered="";
        public static string UserNotFound="";
        public static string PasswordError="";
        public static string SuccessfulLogin="";
        public static string UserAlreadyExists="";
        public static string AccessTokenCreated="";
    }
}
