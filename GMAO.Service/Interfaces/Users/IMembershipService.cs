using GMAO.Entities;
using System;
using System.Collections.Generic;

namespace GMAO.Service.Interfaces.Invoice
{
    public interface IMembershipService
    {
        IEnumerable<Membership> GetMemberships();

        void DeleteMembership(Membership ms);
        void UpdateMembership(Membership ms);
        void AddMembership(Membership ms);

        IEnumerable<Membership> verif(string login, string mp);

        Membership GetMemberShipById(int userId);
    }
}
