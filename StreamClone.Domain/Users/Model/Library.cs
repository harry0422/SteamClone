using StreamClone.Domain.Common;
using StreamClone.Domain.Model.Games;
using System;

namespace StreamClone.Domain.Users.Model
{
    public class Library : EntityBase<string>
    {
        public Library() { }

        public Library(User user, Game games)
        {
            Id = Guid.NewGuid().ToString();
            User = user;
            Games = games;
        }

        public User User { get; set; }
        public Game Games { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}