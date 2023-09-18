using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpressCreditDemo.BizModel;
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
    public partial class UcStatMonthlyDiff : DevExpress.XtraEditors.XtraUserControl
    {
        public UcStatMonthlyDiff()
        {
            InitializeComponent();
        }

        private void PrepareSeries()
        {
            IDataLayer dataLayer = ConnectionHelper.GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption.DatabaseAndSchema); ;
            Session session = new Session(dataLayer);

            // TODO: Póki co założenie, że jeden klient ma jedną umowę!
            //var agreements = session.Query<Agreement>();
            //DateTime dateReportStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            //dateReportStart = dateReportStart.AddMonths(-6);
            //var repements = session.Query<Repayments>().Where(r=>r.DateOfPay>=dateReportStart);

            //var gr = repements.GroupBy(r => r.Date);

            List<MontlyPeyment> mont = new List<MontlyPeyment>();
            mont.Add(new MontlyPeyment() { Month = "stycze", Excepted = 100, Paid = 590 });
            mont.Add(new MontlyPeyment() { Month = "luty", Excepted = 1000, Paid = 903 });
            mont.Add(new MontlyPeyment() { Month = "marzec", Excepted = 4500, Paid = 780 });
            mont.Add(new MontlyPeyment() { Month = "kwiecień", Excepted = 300, Paid = 490 });
            mont.Add(new MontlyPeyment() { Month = "maj", Excepted = 1560, Paid = 9045 });
            mont.Add(new MontlyPeyment() { Month = "czerwiec", Excepted = 4700, Paid = 650 });


            // Ustaw źródło danych dla serii
            chartControlMontlyPaid.Series[0].DataSource = mont; // Wpłaty
            chartControlMontlyPaid.Series[1].DataSource = mont; // Oczekiwane

            // Ustaw pola danych
            chartControlMontlyPaid.Series[0].ArgumentDataMember = "Month";
            chartControlMontlyPaid.Series[0].ValueDataMembers.AddRange(new string[] { "Excepted" });
            chartControlMontlyPaid.Series[1].ArgumentDataMember = "Month";
            chartControlMontlyPaid.Series[1].ValueDataMembers.AddRange(new string[] { "Paid" });

            // Ustaw typ serii na słupki
            chartControlMontlyPaid.Series[0].View = new SideBySideBarSeriesView();
            chartControlMontlyPaid.Series[1].View = new SideBySideBarSeriesView();

            // Dostosuj osie
            //chartControlMontlyPaid.Diagram.AxisX.Title.Text = "Miesiące";
            //chartControlMontlyPaid.Diagram.AxisY.Title.Text = "Kwota";

            // Ustaw etykiety
            chartControlMontlyPaid.Series[0].Label.Visible = true;
            chartControlMontlyPaid.Series[0].Label.PointOptions.PointView = PointView.Values;
            chartControlMontlyPaid.Series[1].Label.Visible = true;
            chartControlMontlyPaid.Series[1].Label.PointOptions.PointView = PointView.Values;

        }

        private void UcStatMonthlyDiff_Load(object sender, EventArgs e)
        {
            PrepareSeries();
        }
    }
}
