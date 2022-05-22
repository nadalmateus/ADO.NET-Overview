﻿using ECommerce.Entities;

namespace ECommerce.Repositories
{
    interface IUserRepository
    {
        public List<User> GetAllUsers();
        public User GetUserById(int id);
        public void CreateUser(User user);
        public void UpdateUser(User user);
        public void DeleteUser(int id);
    }
}
