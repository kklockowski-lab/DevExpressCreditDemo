using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpressCreditDemo.credit;
using DevExpressCreditDemo.Helpers;
using DevExpressCreditDemo.ORMCreditDBModelCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCreditDemo.UI.Modules
{
    public partial class UcClients : BaseViewControl
    {
        public UcClients()
        {
            InitializeComponent();
        }

        private void UcClients_Load(object sender, EventArgs e)
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);

          //  gridControlClients.DataSource = session.Query<Client>();
            gridControlClients.DataSource = session.Query<VM_REPAID_BY_AGREEMENT>();
        }

        private void gridViewClients_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isDebet = CalcDebet(view, e.RowHandle);
                if (isDebet)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private bool CalcDebet(GridView view, int rowHandle)
        {            
            DateTime startDate = DateTime.Parse(view.GetRowCellValue(rowHandle, "StartDate").ToString());
            double installment = double.Parse(view.GetRowCellValue(rowHandle, "Installment").ToString());
            double repaid= double.Parse(view.GetRowCellValue(rowHandle, "Repaid").ToString());
            int cnt = DateTimeHelper.GetMonthDiff(startDate, DateTime.Now);

            double sum = cnt * installment;


            return repaid < sum;

        }
    }
}
