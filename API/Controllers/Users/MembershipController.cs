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
    public class MembershipController : Controller
    {
        int page = 1;
        int pageSize = 10;        
        IMembershipService _memberservice;
        
        public MembershipController(IMembershipService memberservice)
        {
            _memberservice = memberservice;
            
        }


        [HttpGet]
        [Route("GetMemberships")]
        public IActionResult GetMemberships()
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
            var totalUsers = _memberservice.GetMemberships().Count();
            var totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);

            IEnumerable<Membership> _user = _memberservice.GetMemberships()
                .OrderBy(c => c.UserId)
                .Skip((currentPage - 1) * currentPageSize)
                .Take(currentPageSize)
                .ToList();
            Response.AddPagination(page, pageSize, totalUsers, totalPages);

            return new OkObjectResult(_user.OrderByDescending(x => x.UserId));
        }


        [HttpGet]
        [Route("GetMemberShipById/{UserId}")]
        public IActionResult GetMemberShipById(int userId)
        {
            var member = _memberservice.GetMemberShipById(userId);

            if (member != null)
            {
                return new OkObjectResult(member);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut]
        [Route("UpdateMembership")]

        public IActionResult UpdateMembership([FromBody]Membership membership)
        {
            if (membership != null)
            {
                
                _memberservice.UpdateMembership(membership);
                return new OkObjectResult(membership);
            }
            else
            {
                return NotFound();
            }

        }
        

        [HttpPost]
        [Route("VerifyUser")]
        public IActionResult VerifyUser([FromBody]UserVm login)
        {
            IEnumerable<Membership> _member = _memberservice.verif(login.Email,login.Password);
            return new OkObjectResult(_member);          
            
        }

    }
  }


