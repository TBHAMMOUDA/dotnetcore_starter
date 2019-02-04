using System;
using System.Collections.Generic;
using System.Text;

namespace GMAO.ViewModel
{
    public class UserVm
    {
        public UserVm()
        {

        }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool? IsApproved { get; set; }

        public string roleID { get; set; }

    }
}
