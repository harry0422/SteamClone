namespace SteamClone.Application.Games.DTOs
{
    public class GameIdDto
    {
        public GameIdDto(string id)
        {
            Id = id;
        }

        public string Id { get; set; }
    }
}