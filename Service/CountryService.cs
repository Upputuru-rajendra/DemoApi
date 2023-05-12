//using demoapiweb.Data;
//using demoapiweb.Models;
//using demoapiweb.Repository;

//namespace demoapiweb.Service
//{
//    public class CountryService : ICountryRepository
//    {
//        public Country getall()
//        {
//            Context con = new Context();
//            Country co = con.Countrys.ToList()
//                .First();
//            return co;

//        }

//        public Country insertcountry(Country cou)
//        {

//            Context cou = new Context();
//            cou.Countrys.Add(cou);
//            co.SaveChanges();
//            return cou;


//        }
//    }
//}