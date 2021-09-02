using SteamClone.Infrastructure.Common;
using SteamClone.Infrastructure.Games.Contexts;
using StreamClone.Domain.Common;
using StreamClone.Domain.Games.Repositories;
using StreamClone.Domain.Users.Model;
using System.Collections.Generic;

namespace SteamClone.Infrastructure.Users.Repositories
{
    public class LibraryRepository : EFRepositoryBase<Library>, ILibraryRepository
    {
        public LibraryRepository(ApplicationContext context) : base(context)
        {

        }
    }
}