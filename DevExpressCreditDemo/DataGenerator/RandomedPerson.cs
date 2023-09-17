using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpressCreditDemo.credit;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpressCreditDemo.DataGenerator
{
    internal class RandomedPerson
    {
        private static List<string> _maleFirsNameList = new List<string>();
        private static List<string> _femaleFirstNameList = new List<string>();
        private static List<string> _maleLastNameList = new List<string>();
        private static List<string> _femaleLastNameList = new List<string>();


        private static string _maleFirstNamePath;
        private static string _femaleFirstNamePath;
        private static string _maleLastNamePath;
        private static string _femaleLastNamePath;

        private static Random rand = new Random();
        public static List<Client> GenrateClients(Session session, int count)
        {
            List<Client> result = new List<Client>();
            var peselList = session.Query<Client>().Select(client => client.PESEL);
            try
            {
                ReadPathFromConfig();
                ReadData();

                for (int i = 0; i < count; i++)
                {

                    Gender gender = rand.Next(0, 1) == 1 ? Gender.Female : Gender.Male;
                    long active = rand.Next(1, 100) < 80 ? 1 : 0;

                    string pesel = Pesel.Generate(gender);
                    while (peselList.Contains(pesel))
                    {
                        pesel = Pesel.Generate(gender);
                    }


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

                    Client client = new Client(session)
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        PESEL = pesel,
                        Active = active,
                    };
                    result.Add(client);

                }
            }

            catch (Exception ex)
            {
                XtraMessageBox.Show($"Wystąpił błąd podczas generowania klientów.\n{ex}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private static void ReadPathFromConfig()
        {
            NameValueCollection generatorPath = ConfigurationManager.GetSection("GeneratorPath") as NameValueCollection;

            if (generatorPath != null)
            {
                _maleFirstNamePath = generatorPath["MaleFirstNamePath"];
                _femaleFirstNamePath = generatorPath["FemaleFirstNamePath"];
                _maleLastNamePath = generatorPath["MaleLastNamePath"];
                _femaleLastNamePath = generatorPath["FemaleLastNamePath"];
            }
        }

        private static void ReadData()
        {
            //TODO: sprawdzenie czy plik nie przekroczy rozmiaru listy
            if (File.Exists(_maleFirstNamePath))
            {
                _maleFirsNameList.AddRange(File.ReadAllLines(_maleFirstNamePath));
            }

            if (File.Exists(_femaleFirstNamePath))
            {
                _femaleFirstNameList.AddRange(File.ReadAllLines(_femaleFirstNamePath));
            }

            if (File.Exists(_maleLastNamePath))
            {
                _maleLastNameList.AddRange(File.ReadAllLines(_maleLastNamePath));
            }

            if (File.Exists(_femaleLastNamePath))
            {
                _femaleLastNameList.AddRange(File.ReadAllLines(_femaleLastNamePath));
            }
        }

        //Zmiana nazwiska na żeńskie
        private static string FemaleLastName(string lastName)
        {
            if (string.IsNullOrEmpty(lastName)) return null;
            if (lastName[lastName.Length - 1].Equals('a')) return lastName;
            else return lastName.Substring(0, lastName.Length - 2) + "a";
        }
    }
}
