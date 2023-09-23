using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpressCreditDemo.credit;
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
    public partial class UcRepayment : DevExpress.XtraEditors.XtraUserControl
    {
        public UcRepayment()
        {
            InitializeComponent();
        }

        private void UcRepeyment_Load(object sender, EventArgs e)
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);
            gridControlRepeyment.DataSource = session.Query<View_ClientRepayments>();
        }

        private void gridViewRepeyment_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                bool isAfter = PaidAfter(view, e.RowHandle);
                if (isAfter)
                {
                    e.Appearance.BackColor = Color.DeepPink;
                    e.Appearance.BackColor2 = Color.White;
                }
            }
        }

        private bool PaidAfter(GridView view, int rowHandle)
        {
            DateTime paidDate = DateTime.Parse(view.GetRowCellValue(rowHandle, "Date").ToString());
            int  shouldDay = int.Parse(view.GetRowCellValue(rowHandle, "DayOfPement").ToString());

            return paidDate.Day > shouldDay;
        }
    }
}
