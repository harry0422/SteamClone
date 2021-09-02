using StreamClone.Domain.Common;
using StreamClone.Domain.Users.Model;

namespace StreamClone.Domain.Users.Repositories
{
    public interface IUserRepository : IRepository<User, string>
    {
        //public User GetByCredentials(string user, string password);
    }
}