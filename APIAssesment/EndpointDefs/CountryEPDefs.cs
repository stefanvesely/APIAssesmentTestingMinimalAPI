using APIAssesment.MappingClasses;
using APIAssesment.Models;
using APIAssesment.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIAssesment.EndpointDefs
{
    public class CountryEPDefs : IEndpointDefinition
    {

        public void DefineEndpoints(WebApplication app)
        {
            app.MapGet("/allcountries", ([FromServices] ICountryRepository _CountryRepo) =>
            {
                return _CountryRepo.GetAllCountries();
            });
            app.MapGet("/country2/{alpha2}", ([FromServices] ICountryRepository _CountryRepo, string alpha2) =>
            {
                var _country = _CountryRepo.GetFirstCountryUsingAlpha2(alpha2);
                return _country is not null ? Results.Ok(_country) : Results.NotFound();
            });
            app.MapGet("/country3/{alpha3}", ([FromServices] ICountryRepository _CountryRepo, string alpha3) =>
            {
                var _country = _CountryRepo.GetFirstCountryUsingAlpha3(alpha3);
                return _country is not null ? Results.Ok(_country) : Results.NotFound();
            });
            app.MapGet("/countrycurrency/{currancyname}", ([FromServices] ICountryRepository _CountryRepo, string currencyname) =>
            {
                List<CountryModel> _country = _CountryRepo.GetAllCountriesUsingCurrencyName(currencyname);
                if (_country.Count == 0) return Results.NotFound();
                return Results.Ok(_country);
            });
            app.MapGet("/countrycurrencycode/{currencycode}", ([FromServices] ICountryRepository _CountryRepo, string currencycode) =>
            {
                List<CountryModel> _country = _CountryRepo.GetAllCountriesUsingCurrencyCode(currencycode);
                if (_country.Count == 0) return Results.NotFound();
                return Results.Ok(_country);
            });

            app.MapDelete("/country/{countryname}", ([FromServices] ICountryRepository _CountryRepo, string countryname) =>
            {
                bool isgone = _CountryRepo.RemoveCountry(countryname);
                if (isgone) return Results.Ok();
                return Results.NotFound();
            });
        }

       

        public void DefineServices(IServiceCollection services)
        {
            services.AddSingleton<ICountryRepository, CountryRepository>();
        }
    }
}
