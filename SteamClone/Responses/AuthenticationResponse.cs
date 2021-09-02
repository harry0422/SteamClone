using SteamClone.Application.Users.DTOs;

namespace SteamClone.Responses
{
    public class AuthenticationResponse
    {
        private const string TOKEN_TYPE = "Bearer";

        public AuthenticationResponse(string accessToken, UserDto usuario)
        {
            AccessToken = accessToken;
            TokenType = TOKEN_TYPE;
        }

        public string AccessToken { get; set; }
        public string TokenType { get; set; }
        public string Perfil { get; set; }
    }
}