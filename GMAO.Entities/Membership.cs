using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GMAO.Entities
{
    public class Membership
    {       

        public int UserId { get; set; }
        public string Password { get; set; }
       
        public string Email { get; set; }      
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public DateTime? LastPasswordChangedDate { get; set; }
        public DateTime? LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
      
        public string Comment { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Membership")]
        public virtual User IdUserNavigation { get; set; }


    }
}
