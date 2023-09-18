using DevExpress.Xpo;
using DevExpressCreditDemo.credit;
using DevExpressCreditDemo.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpressCreditDemo.DataGenerator
{
    internal class RandomedPeyment
    {
        private static Random random = new Random();

        public static List<Repayments> Generate(Session session)
        {
            List<Repayments> result = new List<Repayments>();

            var agrements = session.Query<Agreement>();
            var paymentsAgrementIds = session.Query<Repayments>().Select(c => c.IDAgreement.ID).ToList();
            var agreementNoPeyment = agrements.Where(c => !paymentsAgrementIds.Contains(c.ID));

            foreach (var agr in agreementNoPeyment)
            {
                // Wylosuj czy zadłużony klient czy nie (powyżej 80%)
                bool isDebet = random.Next(1, 100) < 80;

                List<Repayments> repList = isDebet ? GenerateDebet(session, agr) : GenerateNoDebet(session, agr);

                result.AddRange(repList);
            }


            return result;
        }

        private static List<Repayments> GenerateNoDebet(Session session, Agreement agr)
        {
            List<Repayments> res = new List<Repayments>();

            DateTime startDate = DateTime.Parse(agr.StartDate);
            DateTime date = new DateTime (startDate.Year, startDate.Month, (int)agr.DayOfPement);

            for (int i = 0; date < DateTime.Now; ++i)
            {
                date = date.AddMonths(i);
                Repayments rep = new Repayments(session)
                {
                    IDAgreement = agr,
                    Value = agr.Installment,
                    Date = date.ToString("yyyy-MM-dd")
                };
                res.Add(rep);
            }


            return res;

        }

        private static List<Repayments> GenerateDebet(Session session, Agreement agr)
        {
            List<Repayments> res = new List<Repayments>();

            DateTime date = DateTime.Parse(agr.StartDate);

            int mountDebet = random.Next(1, DateTimeHelper.GetMonthDiff(date,DateTime.Now));

            for (int i = 0; date.AddMonths(i) < DateTime.Now.AddMonths(mountDebet); ++i)
            {
                Repayments rep = new Repayments(session)
                {
                    IDAgreement = agr,
                    Value = agr.Installment,
                    Date = date.ToString("yyyy-MM-dd")
                };
                res.Add(rep);
            }


            return res;
        }

    }
}
