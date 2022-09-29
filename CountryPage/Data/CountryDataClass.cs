using CountryPage.Models;

namespace CountryPage.Data
{
    public class CountryDataClass : ICountryDataClass
    {
        private readonly HttpClient httpClient;

        public CountryDataClass(HttpClient _httpClient)
        {
            this.httpClient = _httpClient;
        }

        public async Task<List<CountryModel>> GetAllCountries()
        {
            return await httpClient.GetFromJsonAsync<List<CountryModel>>("/allcountries");
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
