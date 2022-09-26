using CountryPage.Models;

namespace CountryPage.Data
{
    public class CountryDataClass : ICountryDataClass
    {
        public Task<List<CountryModel>> GetAllCountries()
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryModel>> GetCountriesWithCurrancyCode(string CurrancyCode)
        {
            throw new NotImplementedException();
        }

        public Task<List<CountryModel>> GetCountriesWithCurrancyName(string CurrancyCode)
        {
            throw new NotImplementedException();
        }

        public Task<CountryModel> GetCountryAlpha(string Alpha, int AlphaCode)
        {
            throw new NotImplementedException();
        }
    }
}
