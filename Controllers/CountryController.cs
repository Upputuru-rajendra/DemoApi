using demoapiweb.Dto;
using demoapiweb.Models;
using demoapiweb.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;

namespace demoapiweb.Controllers
{
    [ApiController]
    [Route("/Country")]
    public class CountryController : Controller
    {
        private ICountryRepository _countryRepository;
        private object countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            this.countryRepository = countryRepository;
        }

        [HttpGet(Name = "getCountry")]
        public Country GetCountry()
        {
            return countryRepository.getall();
        }


        [HttpPost(Name = "insert")]
        public Country insert(CountryDto countryDto)
        {
            Country c = new Country();
            c.Countryid = countryDto.Countryid;
            c.Name = countryDto.Name;
            c.ShortName = countryDto.ShortName;
            c.TimeZone = countryDto.TimeZone;
            c.Currency = countryDto.Currency;
            c.CountryTnCode = countryDto.CountryTnCode;
            c.Region = countryDto.Region;
            return _countryRepository.insertcountry(c);
        }
    }

    public interface ICountryRepository
    {
        Country insertcountry(Country c);
    }
}
