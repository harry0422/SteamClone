using StreamClone.Domain.Common;
using System;
using System.Collections.Generic;

namespace StreamClone.Domain.Model.Games
{
    public class Game : EntityBase<string>
    {
        public Game(string name, string category, string developer, string publisher, DateTime publicationDate, string synopsis, string classification)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
            Category = category;
            Developer = developer;
            Publisher = publisher;
            PublicationDate = publicationDate;
            Synopsis = synopsis;
            Classification = classification;
            Reviews = new List<Review>();
        }

        public string Name { get; set; }
        public string Category { get; set; }
        public IList<Tag> Tags { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; }
        public IList<Game> RelatedGames { get; set; }
        public IList<Review> Reviews { get; set; }
        public string Classification { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}