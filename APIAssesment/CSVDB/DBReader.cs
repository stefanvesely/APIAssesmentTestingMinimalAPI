using APIAssesment.Models;
using Microsoft.VisualBasic.FileIO;
using System.IO;
using System.Linq;

namespace APIAssesment.CSVDB
{
    //C:\Users\malie\source\repos\APIAssesment\APIAssesment (My personalpath please use your own)
    public class DBReader
    {
        private List<CountryModel> _Countries = new List<CountryModel>();
        public List<CountryModel> Countries 
            { get { return _Countries; }
              set { _Countries = value; }
            }
        public DBReader(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                using (TextFieldParser MyCSVParser = new TextFieldParser(FilePath))
                {
                    MyCSVParser.TextFieldType = FieldType.Delimited;
                    MyCSVParser.SetDelimiters(",");
                    while (!MyCSVParser.EndOfData)
                    {
                        string[] CSVFields = MyCSVParser.ReadFields();
                        CountryModel SingleCountry = new CountryModel()
                        {
                            CountryName = CSVFields[0],
                            CountryCode = int.Parse(CSVFields[3]),
                            Currency = CSVFields[4],
                            CurrencyCode = CSVFields[5],
                            Alpha2Code = CSVFields[1],
                            Alpha3Code = CSVFields[2],
                        };
                        Countries.Add(SingleCountry);
                    }
                }
            }
        }
    } 
}
