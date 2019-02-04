using GMAO.Context;
using GMAO.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMAO.DataAccessLayer.Repository
{
     public class UserRepository : GenericRepository<User>
    {
        public UserRepository(GMAODbContext context) : base(context)
        {
        }
    }
}
