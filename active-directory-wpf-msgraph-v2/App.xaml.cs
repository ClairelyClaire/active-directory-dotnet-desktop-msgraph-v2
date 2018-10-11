using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Identity.Client;

namespace active_directory_wpf_msgraph_v2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            // the common endpoint (supports AAD and MSA) doesn't permit integrated auth
            // you must use either a tenant (domain or GUID) or the AAD generic endpoint (organizations)
            //_clientApp = new PublicClientApplication(ClientId, "https://login.microsoftonline.com/common", TokenCacheHelper.GetUserCache());
            _clientApp = new PublicClientApplication(ClientId, "https://login.microsoftonline.com/organizations", TokenCacheHelper.GetUserCache());
        }
        //Below is the clientId of your app registration. 
        //You have to replace the below with the Application Id for your app registration
        private static string ClientId = "0b8b0665-bc13-4fdc-bd72-e0227b9fc011";

        private static PublicClientApplication _clientApp ;

        public static PublicClientApplication PublicClientApp { get { return _clientApp; } }
    }
}
