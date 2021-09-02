namespace SteamClone.Application.Games.DTOs
{
    public class NewReviewDto
    {
        public NewReviewDto(string gameId, int rate, string comment)
        {
            GameId = gameId;
            Rate = rate;
            Comment = comment;
        }

        public string GameId { get; set; }
        public int Rate { get; set; }
        public string Comment { get; set; }
    }
}