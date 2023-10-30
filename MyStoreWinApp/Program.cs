using BusinessObject;
using DataAccess;
using Microsoft.Data.SqlClient;
using Microsoft.Win32;
using System.Data;

namespace MyStoreWinApp
{    
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>       
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.                        
            ApplicationConfiguration.Initialize();
            var config = new AppConfig();
            IDbConnection db = new SqlConnection(config.GetConnectionString());
            Application.Run(new MainForm(db, config.GetAdminAccount()));            
            Application.Exit();            
        }
    }
}