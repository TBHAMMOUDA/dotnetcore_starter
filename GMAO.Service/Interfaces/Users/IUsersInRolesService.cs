using GMAO.Entities;
using System;
using System.Collections.Generic;

namespace GMAO.Service.Interfaces.Invoice
{
    public interface IUsersInRolesService
    {
        IEnumerable<UsersInRoles> GetUsersInRoles();
        IEnumerable<UsersInRoles> SearchUser(string userUame);
        UsersInRoles GetUsersInRolesById(int UserId);
        void DeleteUsersInRoles(UsersInRoles ur);
        void UpdateUsersInRoles(UsersInRoles ur);
        void AddUsersInRoles(UsersInRoles ur);
    }
}
