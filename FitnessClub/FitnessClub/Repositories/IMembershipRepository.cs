using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitnessClub.Entities.Enum;
using System.Threading.Tasks;
using FitnessClub.Entities;

namespace FitnessClub.Repositories;

public interface IMembershipRepository
{
    IEnumerable<Membership> ReadMemberships();
    Membership ReadMembershipById(int id); 
    void CreateMembership(Membership membership);
    void UpdateMembership(Membership membership); 
    void DeleteMembership(int id); 
}