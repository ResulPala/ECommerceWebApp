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
        public static string ProductAdded = "Product Added.";
        public static string ProductNameInvalid = "Product Name is invalid.";
        public static string MaintenanceTime = "System is under Maintenance.";
        public static string ProductsListed = "Products listed.";

        public static string ProductCountofCategoryError = "Cok fazla urun var";

        public static string ProductNameAlreadyExistError = "Ayni isimde urun var";

        public static string CategoryCountError = "Cok fazla kategori var.";
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string UserRegistered = "User Registered";
        public static string UserNotFound = "User can not be found";
        public static string PasswordError = "Wrong Password";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "User already exist";
        public static string AccessTokenCreated = "Access Token Created";
    }
}
