

using Application;
using Domain;

namespace Infrastructure
{
    public class InMemoryUserRepository : IUserRepository
    {
        private readonly List<User> _users = new();
        public User GetUser(string lastName, string firstName)
        {
            foreach (User user in _users)
            {
                if (user.LastName.Equals(lastName) && user.FirstName.Equals(firstName))
                    return user;
            }
            return new User(firstName, lastName,"email", "Password", new Role("basic_user"));
        }
        public void CreateUser(User user)
        {
            _users.Add(user);
        }
    }
}