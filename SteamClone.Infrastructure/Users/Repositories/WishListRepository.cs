using SteamClone.Infrastructure.Common;
using SteamClone.Infrastructure.Games.Contexts;
using StreamClone.Domain.Games.Repositories;
using StreamClone.Domain.Users.Model;

namespace SteamClone.Infrastructure.Users.Repositories
{
    public class WishListRepository : EFRepositoryBase<Wish>, IWishListRepository
    {
        public WishListRepository(ApplicationContext context) : base(context)
        {

        }
    }
}