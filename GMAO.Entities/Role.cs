using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMAO.Entities
{
    public partial class Role
    {
        public Role()
        {
           
            UsersInRoles = new HashSet<UsersInRoles>();

        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }

        [InverseProperty("IdRoleNavigation")]
        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }



    }
}
