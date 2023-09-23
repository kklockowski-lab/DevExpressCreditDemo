using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpressCreditDemo.Forms;
using DevExpressCreditDemo.UI.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCreditDemo
{   
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {       
        bool shouldClose = false;
        public Main()
        {
            InitializeComponent();
            AddModules();
        }

        // TODO: dodawanie modułów (UserControls) z refleksji, a nie ręcznie jak AddModules
        //private void AddModulesAsync()
        //{
        //    Assembly assm = Assembly.GetExecutingAssembly();

        //    foreach (Type t in assm.GetTypes())
        //    {
        //        if (t.Equals(typeof(BaseViewControl)))
        //        {
        //            var obiekt = Activator.CreateInstance(t);

        //           // mainContainer.Controls.Add(obiekt);
        //        }
        //    }
        //}

        private void AddModules()
        {

            //XtraUserControl
            mainContainer.SuspendLayout();
            UcClients clients = new UcClients();
            UcAgreement agreement = new UcAgreement();
            UcRepayment repeyment = new UcRepayment();
            UcStatMonthlyDiff statMonthlyDiff = new UcStatMonthlyDiff();

            clients.Dock = DockStyle.Fill;
            clients.Visible = false;
            mainContainer.Controls.Add(clients);

            agreement.Dock = DockStyle.Fill;
            agreement.Visible = false;
            mainContainer.Controls.Add(agreement);

            repeyment.Dock = DockStyle.Fill;
            agreement.Visible = false;
            mainContainer.Controls.Add(repeyment);

            statMonthlyDiff.Dock = DockStyle.Fill;
            statMonthlyDiff.Visible = false;
            mainContainer.Controls.Add(statMonthlyDiff);

            
            mainContainer.ResumeLayout();
        }

        private void menuElementExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldClose && XtraMessageBox.Show("Czy na pewno zamknać aplikację?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;
        }

        private void ctrCustomers_Click(object sender, EventArgs e)
        {
            SwitchView(typeof(UcClients));
        }

        private void SwitchView(Type type)
        {
            mainContainer.SuspendLayout();

            foreach (Control ctr in mainContainer.Controls)
            {
                if (type.IsInstanceOfType(ctr)) ctr.Visible = true;
                else ctr.Visible = false;
            }

            mainContainer.ResumeLayout();
        }

        private void ctrAgreementActive_Click(object sender, EventArgs e)
        {
            SwitchView(typeof(UcAgreement));
        }

        private void ctrPeyemnts_Click(object sender, EventArgs e)
        {
            SwitchView(typeof(UcRepayment));
        }

        private void ctrStatMonhtlyDiff_Click(object sender, EventArgs e)
        {
            SwitchView(typeof(UcStatMonthlyDiff));
        }

        private void menuElementAbout_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.ShowDialog();
        }
    }
}
