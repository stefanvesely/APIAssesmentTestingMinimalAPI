using APIAssesment.CSVDB;
using APIAssesment.Models;

namespace APIAssesment.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private DBReader _CSVDB;
        private List<CountryModel> Countries;
        public CountryRepository ()
        {
            _CSVDB = new DBReader(@"C:\Users\malie\source\repos\APIAssesment\APIAssesment\CurrenciesCountries.csv");
            Countries = _CSVDB.Countries;

        }

        public CountryModel GetFirstCountryUsingCurrencyName(string CurrencyName)
        {
            if (Countries.FirstOrDefault(x => x.Currency == CurrencyName) != null)
            {
                return Countries.FirstOrDefault(x => x.Currency == CurrencyName);
            }
            return new CountryModel();
        }

        public CountryModel GetFirstCountryUsingAlpha2(string Alpha2)
        {
            if (Countries.FirstOrDefault(x => x.Alpha2Code == Alpha2) != null)
            {
                return Countries.FirstOrDefault(x => x.Alpha2Code == Alpha2);
            }
            return new CountryModel();
        }
        public CountryModel GetFirstCountryUsingAlpha3(string Alpha3)
        {
            if (Countries.FirstOrDefault(x => x.Alpha3Code == Alpha3) != null)
            {
                return Countries.FirstOrDefault(x => x.Alpha2Code == Alpha3);
            }
            return new CountryModel();
        }

        public List<CountryModel> GetAllCountriesUsingCurrencyName(string CurrencyName)
        {
            
            List<CountryModel> OutCountries = Countries.Where(x => x.Currency == CurrencyName).ToList();
            return OutCountries;
        }

        public List<CountryModel> GetAllCountries()
        {
            return Countries;
        }

        public bool RemoveCountry(string CountryName)
        {
            if (Countries.First(x => x.CountryName == CountryName) != null)
            {
                Countries.Remove(Countries.First(x => x.CountryName == CountryName));
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<CountryModel> GetAllCountriesUsingCurrencyCode(string CurrencyCode)
        {
            return Countries.Where(x => x.CurrencyCode == CurrencyCode).ToList();
        }

        public CountryModel ReturnFirstCountryUsingCurrencyCode(string CurrencyCode)
        {
            if (Countries.FirstOrDefault(x => x.CurrencyCode == CurrencyCode) != null)
            {
                return Countries.FirstOrDefault(x => x.CurrencyCode == CurrencyCode);
            }
            return new CountryModel();
        }

        public bool RemoveCountryUsingCountryCode(int CountryCode)
        {
            if (Countries.First(x => x.CountryCode == CountryCode) != null)
            {
                Countries.Remove(Countries.First(x => x.CountryCode == CountryCode));
                return true;
            }
            else
            {
                return false;
            }
        }

       
    }
}
