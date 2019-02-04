using GMAO.BusinessLogicLayer.Contracts;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMAO.Service.Invoice
{
    public class UsersInRolesService : IUsersInRolesService
    {
        private IGenericBLL<UsersInRoles> _UsersInRolesBL;
        public UsersInRolesService(IGenericBLL<UsersInRoles> UsersInRolesBL)
        {
            _UsersInRolesBL = UsersInRolesBL;
        }

        public void UpdateUsersInRoles(UsersInRoles ur)
        {
            _UsersInRolesBL.Update(ur);
        }

        public void AddUsersInRoles(UsersInRoles ur)
        {
            _UsersInRolesBL.Add(ur);
        }

        public void DeleteUsersInRoles(UsersInRoles ur)
        {
            _UsersInRolesBL.Delete(ur);
        }
        public IEnumerable<UsersInRoles> GetUsersInRoles()
        {
            var _UsersInRoles = _UsersInRolesBL.GetMany(null, o => o.IdUserNavigation,o => o.IdRoleNavigation, o => o.IdUserNavigation.Membership);
            return _UsersInRoles;
            
        }

        public UsersInRoles GetUsersInRolesById(int UserId)
        {
            var usr = _UsersInRolesBL.GetMany(null, o => o.IdUserNavigation, o => o.IdRoleNavigation, o => o.IdUserNavigation.Membership).Where(x => x.UserId == UserId).ToList();
            
            return usr[0];
        }

        public IEnumerable<UsersInRoles> SearchUser(string userUame)
        {
            var _user = _UsersInRolesBL.GetMany(null, o => o.IdUserNavigation, o => o.IdRoleNavigation,o =>o.IdUserNavigation.Membership).Where(x => x.IdUserNavigation.UserName.ToUpper().Contains(userUame.ToUpper())).ToList();
            return _user;
        }
    }
}


