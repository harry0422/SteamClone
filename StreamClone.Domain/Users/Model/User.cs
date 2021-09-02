using StreamClone.Domain.Common;
using System;
using System.Collections.Generic;

namespace StreamClone.Domain.Users.Model
{
    public class User : EntityBase<string>
    {
        public User(string userName, string password, string name)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
            Name = name;
            Library = new List<Library>();
            WishList = new List<Wish>();
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public IList<Library> Library { get; set; }
        public IList<Wish> WishList { get; set; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}