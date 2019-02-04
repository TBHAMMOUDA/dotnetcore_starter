using GMAO.Entities;
using System;
using System.Collections.Generic;

namespace GMAO.Service.Interfaces.Invoice
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUserById(int Id);
        void DeleteUser(User u);
        void UpdateUser(User u);
        void AddUser(User u);
    }
}
