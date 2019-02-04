using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMAO.Entities
{
    public class UsersInRoles
    {
        
        public int RoleId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("UsersInRoles")]
        public virtual User IdUserNavigation { get; set; }

        [ForeignKey("RoleId")]
        [InverseProperty("UsersInRoles")]
        public virtual Role IdRoleNavigation { get; set; }
    }
}
