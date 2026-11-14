using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities.Enum;
using FitnessClub.Entities;

namespace FitnessClub.Repositories;

public interface IMembershipTypeRepository
{
    IEnumerable<MembershipType> ReadMembershipTypes();
    MembershipType ReadMembershipTypeById(int id);
    void CreateMembershipType(MembershipType type);
    void UpdateMembershipType(MembershipType type);
    void DeleteMembershipType(int id);
}