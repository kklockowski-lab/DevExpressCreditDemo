using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    public partial class UcRepeyment : DevExpress.XtraEditors.XtraUserControl
    {
        public UcRepeyment()
        {
            InitializeComponent();
        }

        private void UcRepeyment_Load(object sender, EventArgs e)
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);
            gridControlRepeyment.DataSource = session.Query<Repayments>();
        }
    }
}
