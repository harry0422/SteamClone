using SteamClone.Application.Users.DTOs;
using SteamClone.Application.Users.Mappers;
using StreamClone.Domain.Games.Repositories;
using StreamClone.Domain.Model.Games;
using StreamClone.Domain.Repositories.Games;
using StreamClone.Domain.Users.Model;
using StreamClone.Domain.Users.Repositories;

namespace SteamClone.Application.Users.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IGameRepository _gameRepository;
        private readonly IWishListRepository _wishListRepository;
        private readonly ILibraryRepository _libraryRepository;

        public UserService(IUserRepository userRepository, IGameRepository gameRepository, IWishListRepository wishListRepository, ILibraryRepository libraryRepository)
        {
            _userRepository = userRepository;
            _gameRepository = gameRepository;
            _wishListRepository = wishListRepository;
            _libraryRepository = libraryRepository;
        }

        public void Add(NewUserDto dto)
        {
            User user = new User(dto.UserName, dto.Password, dto.Name);
            _userRepository.Insert(user);
        }

        public void AddToLibrary(NewLibraryDto dto)
        {
            User user = _userRepository.Get(dto.UserId);
            Game game = _gameRepository.Get(dto.GameId);
            Library library = new Library(user, game);

            _libraryRepository.Insert(library);
        }

        public void AddToWishList(NewWishListDto dto)
        {
            User user = _userRepository.Get(dto.UserId);
            Game game = _gameRepository.Get(dto.GameId);
            Wish wish = new Wish(user, game);

            _wishListRepository.Insert(wish);
        }

        public UserDto GetByCredentials(CredentialsDto dto)
        {
            //return _userRepository.GetByCredentials(dto.Username, dto.Password).ToDto();
            throw new System.NotImplementedException();
        }
    }
}