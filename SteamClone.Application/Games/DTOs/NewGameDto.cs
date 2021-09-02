using System;

namespace SteamClone.Application.Games.DTOs
{
    public class NewGameDto
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; }
        public string Classification { get; set; }
    }
}