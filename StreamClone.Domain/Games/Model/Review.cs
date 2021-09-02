using StreamClone.Domain.Common;
using System;

namespace StreamClone.Domain.Model.Games
{
    public class Review : EntityBase<string>
    {
        public Review(int rate, string comment)
        {
            Id = Guid.NewGuid().ToString();
            Rate = rate;
            Comment = comment;
        }

        public int Rate { get; set; }
        public string Comment { get; set; }

        protected override void Validate()
        {
            
        }
    }
}