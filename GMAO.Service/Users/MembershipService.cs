using GMAO.BusinessLogicLayer.Contracts;
using GMAO.Entities;
using GMAO.Service.Interfaces.Invoice;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GMAO.Service.Invoice
{
    public class MembershipService : IMembershipService
    {
        private IGenericBLL<Membership> _membershipBL;
        public MembershipService(IGenericBLL<Membership> membershipBL)
        {
            _membershipBL = membershipBL;
        }
        
        public Membership GetMemberShipById(int userId)
        {
                var memb = _membershipBL.GetById(userId);
                return memb;            
        }
        public IEnumerable <Membership> verif(string login, string mp)
        {
            var _Membe = _membershipBL.GetMany(null,x => x.IdUserNavigation, x => x.IdUserNavigation.Membership).Where(x => x.Email== login && x.Password == mp);
            return _Membe;
        }

        public void UpdateMembership(Membership ms)
        {
            _membershipBL.Update(ms);
        }

        public void AddMembership(Membership ms)
        {
            _membershipBL.Add(ms);
        }

        public void DeleteMembership(Membership ms)
        {
            _membershipBL.Delete(ms);

        }
        public IEnumerable<Membership> GetMemberships()
        {
            var _Membership = _membershipBL.GetMany(null,o => o.IdUserNavigation, o => o.IdUserNavigation.Membership, o => o.IdUserNavigation.UsersInRoles);
            return _Membership;
        }


    }
}

