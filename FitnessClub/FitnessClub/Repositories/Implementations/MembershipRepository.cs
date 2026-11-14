using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities.Enum;
using FitnessClub.Entities;

namespace FitnessClub.Repositories.Implementations;

internal class MembershipRepository : IMembershipRepository
{
    public void CreateMembership(Membership membership) { }
    public void DeleteMembership(int id) { }
    public Membership ReadMembershipById(int id) => Membership.CreateOperation(0, 0, 0, DateTime.Now);
    public IEnumerable<Membership> ReadMemberships() => new List<Membership>();
    public void UpdateMembership(Membership membership) { }
}