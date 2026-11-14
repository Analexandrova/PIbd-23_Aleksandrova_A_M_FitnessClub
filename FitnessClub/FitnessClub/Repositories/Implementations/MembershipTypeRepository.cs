using FitnessClub.Entities;
using FitnessClub.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Repositories.Implementations;

internal class MembershipTypeRepository : IMembershipTypeRepository
{
    public void CreateMembershipType(MembershipType type) { }
    public void DeleteMembershipType(int id) { }
    public MembershipType ReadMembershipTypeById(int id) => MembershipType.CreateEntity(0, string.Empty, 0, 0, MembershipCategory.None);
    public IEnumerable<MembershipType> ReadMembershipTypes() => new List<MembershipType>();
    public void UpdateMembershipType(MembershipType type) { }
}