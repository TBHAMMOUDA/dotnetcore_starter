using GMAO.BusinessLogicLayer.Contracts;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using System;
using System.Collections.Generic;

namespace GMAO.Service.Invoice
{
    public class UserService : IUserService
    {
        private IGenericBLL<User> _userBL;
        public UserService(IGenericBLL<User> userBL)
        {
            _userBL = userBL;
        }
        
        public void UpdateUser(User u)
        {
            _userBL.Update(u);
        }

        public void AddUser(User u)
        {

             _userBL.Add(u);
        }

        public void DeleteUser(User u)
        {
            _userBL.Delete(u);
        }
        public IEnumerable<User> GetUsers()
        {
            var _user = _userBL.GetMany(null,x => x.Membership, x=>x.UsersInRoles);
            return _user;
        }

        public User GetUserById(int Id)
        {
            var _user = _userBL.GetById(Id);
            return _user;

        }
    }
}

