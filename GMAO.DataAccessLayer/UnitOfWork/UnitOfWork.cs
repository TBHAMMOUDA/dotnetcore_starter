using GMAO.DataAccessLayer.Contracts;
using GMAO.DataAccessLayer.Repository;
using GMAO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Reflection;
using GMAO.Context;

namespace GMAO.DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly Dictionary<Type, IRepository> _repositories;
   
        public UnitOfWork(IRepository<UsersInRoles> UsersInRolesRepo,
                          IRepository<Membership> MemberShipRepo,
                          IRepository<User> userRepo,
                          IRepository<Role> roleRepo
                         )
                          

        {
            _repositories = _repositories?? new Dictionary<Type, IRepository>();
           
            _repositories.Add(typeof(User), userRepo);
            _repositories.Add(typeof(Role), roleRepo);
            _repositories.Add(typeof(Membership), MemberShipRepo);
            _repositories.Add(typeof(UsersInRoles), UsersInRolesRepo);

        }
       

        public IRepository GetRepository<T>() where T:class
        {
            return _repositories[typeof(T)];
        }
        public void Commit()
        {
            _repositories.ToList().ForEach(x => x.Value.Submit());
        }


        private Type[] GetTypesInNamespace(Assembly assembly, string nameSpace)
        {
            return assembly.GetTypes().Where(t => String.Equals(t.Namespace, nameSpace, StringComparison.Ordinal)).ToArray();
        }
    }
}
