using CountryPage.Models;
using Microsoft.AspNetCore.Routing.Constraints;

namespace CountryPage.Data
{
    public interface ICountryDataClass 
    {
        public Task<List<CountryModel>> GetAllCountries();
        public Task<CountryModel> GetCountryAlpha(string Alpha, int AlphaCode);
        public Task<List<CountryModel>> GetCountriesWithCurrancyCode(string CurrancyCode);
        public Task<List<CountryModel>> GetCountriesWithCurrancyName(string CurrancyCode);

    }
}
