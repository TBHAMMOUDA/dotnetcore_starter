using GMAO.Entities;
using System.Collections.Generic;

namespace GMAO.Service.Interfaces.Invoice
{
    public interface IRoleService
    {
        IEnumerable<Role> GetRoles();
        void DeleteRole(Role r);
        void UpdateRole(Role r);
        void AddRole(Role r);
    }
}
