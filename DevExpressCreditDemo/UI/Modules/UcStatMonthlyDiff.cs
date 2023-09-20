using DevExpress.Xpo;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpressCreditDemo.BizModel;
using DevExpressCreditDemo.credit;
using DevExpressCreditDemo.Helpers;
using DevExpressCreditDemo.ORMCreditDBModelCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

            // Lista wpłat i oczekiwań wg. miesięcy
            List<MontlyPeyment> monthValues = new List<MontlyPeyment>();

            DateTime dateReportStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateReportStart = dateReportStart.AddMonths(-5);

            // ToList, ponieważ w SQLLite datay jako stringi i parsowanie w "locie" nie działa,
            // zatem kopia i użycie dodatkowego pola DateOfPaid.
            // Na normalnej bazie, zapytanie byłoby łatwiesze (ew. pricedura skłądowana).
            var allRepements = session.Query<Repayments>().ToList();
            var allAgrements = session.Query<Agreement>().ToList();

            var repementsInDate = allRepements.Where(p => p.DateOfPaid >= dateReportStart && p.DateOfPaid<=DateTime.Now).OrderBy(o => o.DateOfPaid);
            var groupPaid = repementsInDate.GroupBy(r => r.DateOfPaid.Month);


            // Sumowanie wpłaconych rat
            foreach ( var group in groupPaid ) 
            {
                var sum = group.Sum(s => s.Value);
                string monthName = DateTimeHelper.MonthName(group.First().DateOfPaid.Month);
                monthValues.Add(new MontlyPeyment() { Month = monthName, Paid = sum });
            }

            // Wyliczenie wpłat oczekiwanych
            // Umowy w obowiązujące w okresie ost.6 miesięcy 
            // TODO: docelowo warunek na Active=1
            var agreementsInDate = allAgrements.Where(a => a.DateEndToPaid >= dateReportStart && a.DateStartToPaid <= DateTime.Now).OrderBy(o => o.DateStartToPaid.Month);
            var groupAgrement = agreementsInDate.GroupBy(g => g.DateStartToPaid.Month);
            
            // TODO: Założenie, że rata jest stała.
            foreach (var group in groupAgrement)
            {
                double sum = 0;
                foreach(var agr in group)
                {
                    // Wyliczenie ilości mieisęcy w zakresie raportu:

                    int monthCount = DateTimeHelper.MonthCountBetween(agr.DateStartToPaid, agr.DateEndToPaid, dateReportStart, DateTime.Now); ;
                    sum += monthCount * agr.Installment;
                }

                string monthName = DateTimeHelper.MonthName(group.Key);
                MontlyPeyment mp = monthValues.Where(m => m.Month.Equals(monthName)).FirstOrDefault();
                if(mp != null ) 
                {
                    mp.Excepted = sum; 
                }
                else
                {
                    monthValues.Add(new MontlyPeyment (){ Month = monthName, Excepted = sum });
                }
            }

            // Ustaw źródło danych dla serii
            chartControlMontlyPaid.Series[0].DataSource = monthValues; // Wpłaty
            chartControlMontlyPaid.Series[1].DataSource = monthValues; // Oczekiwane

            // Ustaw pola danych
            chartControlMontlyPaid.Series[0].ArgumentDataMember = "Month";
            chartControlMontlyPaid.Series[0].ValueDataMembers.AddRange(new string[] { "Excepted" });
            chartControlMontlyPaid.Series[1].ArgumentDataMember = "Month";
            chartControlMontlyPaid.Series[1].ValueDataMembers.AddRange(new string[] { "Paid" });

            // Ustaw typ serii na słupki
            chartControlMontlyPaid.Series[0].View = new SideBySideBarSeriesView();
            chartControlMontlyPaid.Series[1].View = new SideBySideBarSeriesView();

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
