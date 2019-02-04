using GMAO.Context;
using GMAO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMAO.DataAccessLayer.Repository
{
    public class RoleRepository : GenericRepository<Role>
    {
        public RoleRepository(GMAODbContext context) : base(context)
        {
        }
    }
}
