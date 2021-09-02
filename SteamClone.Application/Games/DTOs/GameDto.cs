using System;

namespace SteamClone.Application.Games.DTOs
{
    public class GameDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        //public IList<Tag> Tags { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; }
        //public IList<Game> RelatedGames { get; set; }
        //public IList<Review> Reviews { get; set; }
        public string Classification { get; set; }
    }
}