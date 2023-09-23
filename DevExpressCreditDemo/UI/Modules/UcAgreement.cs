using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpressCreditDemo.credit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCreditDemo.UI.Modules
{
    public partial class UcAgreement : BaseViewControl
    {
        public UcAgreement()
        {
            InitializeComponent();
        }

        private void UcAgreement_Load(object sender, EventArgs e)
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);
            var agreementsWithClients = from agreement in session.Query<Agreement>()
                                        join client in session.Query<Client>()
                                        on agreement.IDClient.ID equals client.ID
                                        select new
                                        {
                                            FirstName = client.FirstName,
                                            LastName = client.LastName,
                                            StartDate = agreement.StartDate,
                                            EndDate = agreement.EndDate,
                                            Amount = agreement.Amount,
                                            Active = agreement.Active,
                                            Percent = agreement.Percent,
                                            IinstallmentCount = agreement.IinstallmentCount,
                                            Installment = agreement.Installment,
                                            DayOfPement = agreement.DayOfPement,
                                        };

            gridControlAgreement.DataSource = agreementsWithClients;
        }

        private void gridViewAgrement_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                long active = long.Parse(view.GetRowCellValue(e.RowHandle, "Active").ToString());
                if (active != 1)
                {
                    e.Appearance.BackColor = Color.LightCyan;
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }
    }
}
