namespace SteamClone.Application.Users.DTOs
{
    public class NewLibraryDto
    {
        public NewLibraryDto(string userId, string gameId)
        {
            UserId = userId;
            GameId = gameId;
        }

        public string UserId { get; set; }
        public string GameId { get; set; }
    }
}