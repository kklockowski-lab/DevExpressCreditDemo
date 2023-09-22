using DataCreditGenerator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DataCreditGenerator.Heleprs;

namespace DataCreditGenerator
{
    public class Clients
    {

        private static List<string> mailHosts = new List<string>() { "gmail.com", "wp.pl", "poczta.pl", "firma.pl", "onet.pl", "mail.com" };
        private static List<string> _maleFirsNameList = new List<string>();
        private static List<string> _femaleFirstNameList = new List<string>();
        private static List<string> _maleLastNameList = new List<string>();
        private static List<string> _femaleLastNameList = new List<string>();

        private IList<Client> result;
        private readonly int _count;
        private static Random rand = new Random();
        private readonly List<string> peselList = new List<string>();

        public Clients(int count)
        {
            SetListNames("DataCreditGenerator.ResourcesCSV.imiona_meskie.csv", ref _maleFirsNameList);
            SetListNames("DataCreditGenerator.ResourcesCSV.imiona_zenskie.csv", ref _femaleFirstNameList);
            SetListNames("DataCreditGenerator.ResourcesCSV.nazwiska_meskie.csv", ref _maleLastNameList);
            SetListNames("DataCreditGenerator.ResourcesCSV.nazwiska_zenskie.csv", ref _femaleLastNameList);
            _count = count;
        }

        /// <summary>
        /// Lista wylosowanych klientów.
        /// </summary>
        /// <param name="forseReGenerate">true - wylosowanie nowych klientów</param>
        /// <param name="excludePeselList">lista PESELi, które mają być ominęte w wyniku.</param>
        /// <returns></returns>
        public IList<Client> ClientList(bool forseReGenerate = false, IList<string> excludePeselList = null)
        {

            if (result is null || forseReGenerate)
            {
                result = new List<Client>();
            }
            else if (excludePeselList != null)
            {
                result = result.Where(r => !excludePeselList.Contains(r.Pesel)).ToList();
                return result;
            }
            else
            {
                return result;
            }

            if(excludePeselList!=null) peselList.AddRange(excludePeselList);


            for (int i = 0; i < _count; i++)
            {
                Gender gender = rand.Next(0, 1) == 1 ? Gender.Female : Gender.Male;
                bool active = rand.Next(1, 100) < 80;

                string pesel = Pesel.Generate(gender);
                while (peselList.Contains(pesel))
                {
                    pesel = Pesel.Generate(gender);
                }
                peselList.Add(pesel);

                string firstName;
                string lastName;
                if (gender == Gender.Female)
                {
                    firstName = _femaleFirstNameList[rand.Next(0, _femaleFirstNameList.Count)];
                    lastName = _femaleLastNameList[rand.Next(0, _femaleLastNameList.Count)];
                }
                else
                {
                    firstName = _maleFirsNameList[rand.Next(0, _maleFirsNameList.Count)];
                    lastName = _maleLastNameList[rand.Next(0, _maleLastNameList.Count)];
                }

                Client client = new Client()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Gender = gender,
                    Pesel = pesel,
                    Active = active,
                    Email = $"{firstName.Replace(" ", "_")}.{lastName.Replace(" ", "_")}@{mailHosts[rand.Next(0, mailHosts.Count)]}",
                    PhoneNumber = rand.Next(400000000, 900000000).ToString()
                };

                result.Add(client);
            }


            return result;

        }

        public void ExcludePesels(IList<string> excludePeselList)
        {
            peselList.AddRange(excludePeselList);

            if (result != null)
            {
                result = result.Where(r => !excludePeselList.Contains(r.Pesel)).ToList();
            }
        }

        private void SetListNames(string csvFile, ref List<string> list)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(csvFile))
            using (StreamReader reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrEmpty(line))
                        list.Add((line.Substring(0, 1).ToUpper() + line.Substring(1).ToLower()).Trim());
                }
            }
        }
    }
}
