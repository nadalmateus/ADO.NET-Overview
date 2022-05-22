using ECommerce.Entities;

namespace ECommerce.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static List<User> _db = new List<User>()
    {
        new User(){Id = 1, Name = "Matt1", Email = "matt1@matt.com"},
        new User(){Id = 2, Name = "Matt2", Email = "matt2@matt.com"},
        new User(){Id = 3, Name = "Matt3", Email = "matt3@matt.com"}
    };


        public List<User> GetAllUsers()
        {
            return _db;
        }

        public User GetUserById(int id)
        {
            return _db.FirstOrDefault(a => a.Id == id);
        }

        public void CreateUser(User user)
        {
            _db.Add(user);
        }

        public void UpdateUser(User user)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == user.Id));
            _db.Add(user);
        }

        public void DeleteUser(int id)
        {
            _db.Remove(_db.FirstOrDefault(a => a.Id == id));
        }
    }
}