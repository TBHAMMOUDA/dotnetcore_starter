using GMAO.Context;
using GMAO.DataAccessLayer;
using GMAO.Entities;
using System;
using System.Collections.Generic;
public class UsersInRolesRepository : GenericRepository<UsersInRoles>
{
    public UsersInRolesRepository(GMAODbContext context) : base(context)
    {
    }
}

