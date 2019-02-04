using API.Core;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers.GMAO
{

    [Route("api/[controller]")]
    public class UsersInRolesController : Controller
    {
        int page = 1;
        int pageSize = 10;
        IUsersInRolesService _userinrole;
        int id;

        public UsersInRolesController(IUsersInRolesService userinrole)
        {
            _userinrole = userinrole;

        }


        [HttpGet]
        [Route("GetUsersInRoles")]
        public IActionResult GetUsersInRoles()
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
            var totalRoles = _userinrole.GetUsersInRoles().Count();
            var totalPages = (int)Math.Ceiling((double)totalRoles / pageSize);

            IEnumerable<UsersInRoles> _UsersInRoles = _userinrole.GetUsersInRoles()
                .OrderBy(c => c.UserId)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToList();
            Response.AddPagination(page, pageSize, totalRoles, totalPages);

            return new OkObjectResult(_UsersInRoles.OrderByDescending(x => x.UserId));
        }


        [HttpGet]
        [Route("GetUsersInRolesById/{UserId}")]
        public IActionResult GetUsersInRolesById(String userId)
        {
            id = int.Parse(userId);
            var _usrol = _userinrole.GetUsersInRolesById(id);
            
            if (_usrol != null)
            {
                return new OkObjectResult(_usrol);
            }
            else
            {
                return NotFound();
            }

        }

        [HttpGet]
        [Route("SearchUser/{userUame}")]
        public IActionResult SearchUser(string userUame)
        {
            _userinrole.SearchUser(userUame);

            var pagination = Request.Headers["Pagination"];
            if (!string.IsNullOrEmpty(pagination))
            {
                string[] vals = pagination.ToString().Split(',');
                int.TryParse(vals[0], out page);
                int.TryParse(vals[1], out pageSize);
            }
            int currentPage = page;
            int currentPageSize = pageSize;
            var totalUsers = _userinrole.SearchUser(userUame).Count();
            var totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);

            IEnumerable<UsersInRoles> _user = _userinrole.SearchUser(userUame)
                .OrderBy(c => c.UserId)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToList();
            Response.AddPagination(page, pageSize, totalUsers, totalPages);

            return new OkObjectResult(_user);
        }
    }
}

