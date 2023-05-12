using demoapiweb.Models;

namespace demoapiweb.Repository
{
    public interface ICountryRepository
    {
        Country getall();
        Country insertcountry(Country cou);
    }
}
