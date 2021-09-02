using SteamClone.Infrastructure.Common;
using SteamClone.Infrastructure.Games.Contexts;
using StreamClone.Domain.Users.Model;
using StreamClone.Domain.Users.Repositories;
using System.Linq;

namespace SteamClone.Infrastructure.Users.Repositories
{
    public class UserRepository : EFRepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {

        }

        //public User GetByCredentials(string userName, string password)
        //{
        //    return _context.Set<User>().Where(x => x.UserName == userName && x.Password == password).FirstOrDefault();
        //}
    }
}