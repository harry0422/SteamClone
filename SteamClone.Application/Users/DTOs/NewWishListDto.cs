namespace SteamClone.Application.Users.DTOs
{
    public class NewWishListDto
    {
        public NewWishListDto(string userId, string gameId)
        {
            UserId = userId;
            GameId = gameId;
        }

        public string UserId { get; set; }
        public string GameId { get; set; }
    }
}