using DataCreditGenerator;
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
            Clients c = new Clients(50);
            var l = c.ClientList();
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);
            session.Connect();
            // var clients = RandomedPerson.GenrateClients(session, 10);         

            //var agreements = RandomedAgreement.Generate(session);

            //var repeyments = RandomedPeyment.Generate(session);

            // foreach (var agr in repeyments) { session.Save(agr); }

            session.Disconnect();
            ;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}