using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpressCreditDemo.credit;
using DevExpressCreditDemo.ORMCreditDBModelCode;
using GeneralHelpers;
using System;
using System.Drawing;

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
         
            // TODO: Póki co założenie, że jeden klient ma jedną umowę!
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
            int cnt = DateTimeHelper.MonthCountBetween(startDate, DateTime.Now);

            double sum = cnt * installment;


            return repaid < sum;

        }
    }
}
