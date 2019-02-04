using GMAO.Context;
using GMAO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMAO.DataAccessLayer.Repository
{
    public class MemberShipRepository : GenericRepository<Membership>
    {
        public MemberShipRepository(GMAODbContext context) : base(context)
        {
        }
    }
}
