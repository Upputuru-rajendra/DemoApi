using demoapiweb.Data;
using demoapiweb.Models;
using demoapiweb.Repository;

namespace demoapiweb.Service
{
    public class CompanyService : ICompanyRepository
    {
        public Company getall()
        {
            Context con=new Context();
            Company co = con.Companies.ToList().First();
            return co;

        }

        public Company insertcompany(Company com)
        {
            
         Context con = new Context();
           con.Companies.Add(com);
          con.SaveChanges();
            return com;
            
            
        }
    }
}
