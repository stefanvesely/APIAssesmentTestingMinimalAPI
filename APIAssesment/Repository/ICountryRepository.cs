using APIAssesment.Models;

namespace APIAssesment.Repository
{
    public interface ICountryRepository 
    {
        List<CountryModel> GetAllCountries();
        CountryModel GetFirstCountryUsingCurrencyName(string CurrencyName);
        CountryModel ReturnFirstCountryUsingCurrencyCode(string CurrencyCode);
        CountryModel GetFirstCountryUsingAlpha2(string Alpha2);
        CountryModel GetFirstCountryUsingAlpha3(string Alpha3);
        List<CountryModel> GetAllCountriesUsingCurrencyName(string CurrencyName);
        List<CountryModel> GetAllCountriesUsingCurrencyCode(string CurrencyCode);
        bool RemoveCountry(string CountryName);
        bool RemoveCountryUsingCountryCode(int CountryCode);
    }
}
