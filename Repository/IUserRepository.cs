using demoapiweb.Models;

namespace demoapiweb.Repository
{
    public interface IUserRepository
    {
        User getall();
        User insert(User u1);
        User insertuser(User com);
    }
}
