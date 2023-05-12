using demoapiweb.Models;

namespace demoapiweb.Repository
{
    public interface ICompanyRepository
    {
        Company getall();
        Company insertcompany(Company com);
    }
}
