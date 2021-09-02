using SteamClone.Application.Users.DTOs;
using StreamClone.Domain.Users.Model;

namespace SteamClone.Application.Users.Mappers
{
    public static class UserMapper 
    {
        public static UserDto ToDto(this User user)
        {
            if (user == null) return null;

            UserDto dto = new UserDto();
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            dto.Name = user.Name;

            return dto;
        }
    }
}