//using demoapiweb.Data;
//using demoapiweb.Models;
//using demoapiweb.Repository;
//using System.Net.Mail;
//using System.Text.RegularExpressions;

//namespace demoapiweb.Service
//{
//    public class UserService : IUserRepository
//    {
//        public User getall()
//        {
//            Context con = new Context();
//            User u=con.Users.ToList().First();
//            return u;

//        }

//        public User insert(User user)
//        {
//            Context con = new Context();
//            con.Users.Add(user);
//            con.SaveChanges();
//            return user;
//        }
//        public bool IsValid(string emailaddress)
//        {
//            try
//            {
//                MailAddress m = new MailAddress(emailaddress);

//                return true;
//            }
//            catch (FormatException)
//            {
//                return false;
//            }
//        }
//        public bool IsValidPhone(string Phone)
//        {
//            try
//            {
//                if (string.IsNullOrEmpty(Phone))
//                    return false;
//                var r = new Regex(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$");
//                return r.IsMatch(Phone);

//            }
//            catch (Exception)
//            {
//                throw;
//            }
//        }
//    }
//}
using demoapiweb.Data;
using demoapiweb.Models;
using demoapiweb.Repository;

namespace demoapiweb.Service
{
    public class UserService : IUserRepository
    {
        public User getall()
        {
            Context con = new Context();
            User co = con.Users.ToList().First();
            return co;

        }

        public User insert(User user)
        {
            throw new NotImplementedException();
        }

        public User insertuser(User com)
        {

            Context con = new Context();
            con.Users.Add(com);
            con.SaveChanges();
            return com;


        }

        public bool IsValid(string emailaddress)
        {
            throw new NotImplementedException();
        }

        public bool IsValidPhone(string Phone)
        {
            throw new NotImplementedException();
        }
    }
}


        //public bool IsValid(string emailaddress)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool IsValidPhone(string Phone)
        //{
        //    throw new NotImplementedException();
        //}
//    }
//}
