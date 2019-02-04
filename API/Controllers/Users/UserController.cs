using API.Core;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using GMAO.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers.GMAO
{

    [Route("api/[controller]")]
    public class UserController : Controller
    {
        int page = 1;
        int pageSize = 10;
        IUserService _service;
        IMembershipService _memberservice;
        IUsersInRolesService _userinrole;
        public UserController(IUserService service,IMembershipService memberservice, IUsersInRolesService userinrole)
        {
            _service = service;
            _memberservice = memberservice;
            _userinrole = userinrole;
        }

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            var pagination = Request.Headers["Pagination"];
            if (!string.IsNullOrEmpty(pagination))
            {
                string[] vals = pagination.ToString().Split(',');
                int.TryParse(vals[0], out page);
                int.TryParse(vals[1], out pageSize);
            }
            int currentPage = page;
            int currentPageSize = pageSize;
            var totalUsers = _service.GetUsers().Count();
            var totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);

            IEnumerable<User> _user = _service.GetUsers()
                .OrderBy(c => c.UserId)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToList();
            Response.AddPagination(page, pageSize, totalUsers, totalPages);

            return new OkObjectResult(_user.OrderByDescending(x => x.UserId));
        }


        [HttpGet]
        [Route("GetUserById/{Id}")]
        public IActionResult GetUserById(int Id)
        { 
            var user = _service.GetUserById(Id);

            if (user != null)
            {
                return new OkObjectResult(user);
            }
            else
            {
                return NotFound();
            }
        }

       
        [HttpPost]
        [Route("AddUser")]
        public IActionResult AddUser([FromBody]UserVm user)
        {
            if (user.Password != null)
            {
                User u = new User();
                u.UserName = user.UserName;
               
                UsersInRoles ur = new UsersInRoles();
                ur.RoleId = int.Parse(user.roleID);
                u.UsersInRoles.Add(ur);
                Membership ms = new Membership();
                ms.Email = user.Email;
                ms.Password = user.Password;
                ms.IsApproved = true;
                ms.CreateDate = DateTime.Now;
                ms.LastLoginDate = DateTime.Now;
         
                ms.LastPasswordChangedDate = DateTime.Now;
                ms.LastLockoutDate = DateTime.Now;
                ms.FailedPasswordAttemptCount = 0;
              
                u.Membership.Add(ms);
                var listemail = _memberservice.GetMemberships().FirstOrDefault(a => a.Email == user.Email);
                if (listemail == null)
                {
                 _service.AddUser(u);
                 user.UserId = u.UserId;
                 return new OkObjectResult(user);
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return NotFound();
            }

        }


        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser([FromBody]UserVm user)
        {      
            User _user = _service.GetUserById(user.UserId);
            Membership _membership = _memberservice.GetMemberShipById(user.UserId);
            UsersInRoles _userInRol = _userinrole.GetUsersInRolesById(user.UserId);
            if (_user != null && _membership != null && _userInRol != null )
            {
                _user.UserName = user.UserName;
               
                _membership.IsApproved = (bool)user.IsApproved;
                _membership.Password = user.Password;
                _membership.Email = user.Email;
                
                _user.Membership.Add(_membership);

                _userInRol.RoleId= int.Parse(user.roleID);
                _user.UsersInRoles.Add(_userInRol);

                _service.UpdateUser(_user);
                    
                return new OkObjectResult(_user);               
            }
            else
            {
                return NotFound();
            }

        }

    }
}

