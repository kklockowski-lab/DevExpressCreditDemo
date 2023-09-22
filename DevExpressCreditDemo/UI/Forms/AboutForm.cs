using System;
using System.Reflection;
using System.Windows.Forms;

namespace DevExpressCreditDemo.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        private void AboutForm_Load(object sender, EventArgs e)
        {

            Version version = Assembly.GetEntryAssembly().GetName().Version;
            lblAppVeriosn.Text = version.ToString();
            linkControlRepo.Text = "<href=https://github.com/kklockowski-lab/DevExpressCreditDemo>Repozytorium github</href><br>";

            lblAboutNote.Text = "Aplikacja symuluje działania systemu kredytowego. Możliwość dodawania, edytowania klientów, doknowyania wpłat. Statystki, lista dłużników.";
        }

        private void linkControlRepo_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {

            try
            {
                System.Diagnostics.Process.Start(e.Link);
                linkControlRepo.LinkVisited = true;
            }
            catch { }
        }

    }
}
