using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpressCreditDemo.credit;
using DevExpressCreditDemo.DataGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DevExpressCreditDemo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);
            session.Connect();

            var clients = RandomedPerson.GenrateClients(session, 10);
            

            foreach (var client in clients) { session.Save(client); }

            session.Disconnect();
            ;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}