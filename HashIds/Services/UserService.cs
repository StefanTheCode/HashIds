using HashIds.Models;
using HashidsNet;
using System.Collections.Generic;

namespace HashIds.Services
{
    public class UserService : IUserService
    {
        private readonly IHashids _hashids;

        public UserService(IHashids hashids)
        {
            _hashids = hashids;
        }

        private List<User> Users = new List<User>
        {
            new User { Id = 1, FullName = "Stefan Djokic" },
            new User { Id = 2, FullName = "Ricky Sellers"},
            new User { Id = 3, FullName = "Tasnim Shaffer"}
        };

        public ReturnUser GetUser(int id)
        {
            User user = Users.Find(x => x.Id == id);

            if (user == null) return null;

            return new ReturnUser
            {
                Id = _hashids.Encode(id),
                FullName = user.FullName
            };
        }
    }
}