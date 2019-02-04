 
using System;

namespace GMAO.DataAccessLayer.Contracts
{
    public interface IUnitOfWork
    { 
        void Commit();
        IRepository GetRepository<T>() where T : class;
    }
}
