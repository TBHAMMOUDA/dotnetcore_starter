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
    public class RoleController : Controller
    {
        int page = 1;
        int pageSize = 10;
        IRoleService _service;
        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetRoles")]
        public IActionResult GetRoles()
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
            var totalRoles = _service.GetRoles().Count();
            var totalPages = (int)Math.Ceiling((double)totalRoles / pageSize);

            IEnumerable<Role> _role = _service.GetRoles()
                .OrderBy(c => c.RoleId)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToList();
            Response.AddPagination(page, pageSize, totalRoles, totalPages);

            return new OkObjectResult(_role.OrderByDescending(x => x.RoleId));
        }

        [HttpPost]
        [Route("AddRole")]
        public IActionResult AddRole([FromBody] RoleVm r)
        {


            if (r != null)
            {
                Role role = new Role();
                role.RoleName = r.RoleName;
                role.Description = r.Description;
                _service.AddRole(role);
                return new OkObjectResult(r);
            }
            else
            {
                return NotFound();
            }

        }



    }
}

