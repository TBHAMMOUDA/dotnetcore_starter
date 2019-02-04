using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMAO.Entities
{
    public partial class User
    {

        public User()
        {
            Membership = new HashSet<Membership>();
            UsersInRoles = new HashSet<UsersInRoles>();

        }
        public int UserId { get; set; }
        public string UserName { get; set; }
       
        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<Membership> Membership { get; set; }

        [InverseProperty("IdUserNavigation")]
        public virtual ICollection<UsersInRoles> UsersInRoles { get; set; }



    }
   
}
