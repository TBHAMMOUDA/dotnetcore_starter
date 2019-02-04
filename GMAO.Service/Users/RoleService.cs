using GMAO.BusinessLogicLayer.Contracts;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using System.Collections.Generic;

namespace GMAO.Service.Invoice
{
    public class RoleService : IRoleService
    {
        private IGenericBLL<Role> _roleBL;
        public RoleService(IGenericBLL<Role> roleBL)
        {
            _roleBL = roleBL;
        }

        public void UpdateRole(Role r)
        {
            _roleBL.Update(r);
        }

        public void AddRole(Role r)
        {
            _roleBL.Add(r);
        }

        public void DeleteRole(Role r)
        {
            _roleBL.Delete(r);
        }
        public IEnumerable<Role> GetRoles()
        {
            var _Role = _roleBL.GetMany();
            return _Role;
        }
    }
}

