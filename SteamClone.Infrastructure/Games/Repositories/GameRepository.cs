using SteamClone.Infrastructure.Common;
using SteamClone.Infrastructure.Games.Contexts;
using StreamClone.Domain.Model.Games;
using StreamClone.Domain.Repositories.Games;

namespace SteamClone.Infrastructure.Games.Repositories
{
    public class GameRepository : EFRepositoryBase<Game>, IGameRepository
    {
        public GameRepository(ApplicationContext context) : base(context)
        {

        }
    }
}