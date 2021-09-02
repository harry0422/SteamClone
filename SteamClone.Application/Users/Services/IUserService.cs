using SteamClone.Application.Users.DTOs;

namespace SteamClone.Application.Users.Services
{
    public interface IUserService
    {
        public UserDto GetByCredentials(CredentialsDto dto);
        public void Add(NewUserDto dto);
        public void AddToWishList(NewWishListDto dto);
        public void AddToLibrary(NewLibraryDto dto);
    }
}