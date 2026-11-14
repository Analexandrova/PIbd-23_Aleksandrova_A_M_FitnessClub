using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class Membership
{
    public int Id { get; private set; }
    public int ClientId { get; private set; }
    public int MembershipTypeId { get; private set; }
    public DateTime PurchaseDate { get; private set; }

    public static Membership CreateOperation(int id, int clientId, int membershipTypeId, DateTime purchaseDate)
    {
        return new Membership
        {
            Id = id,
            ClientId = clientId,
            MembershipTypeId = membershipTypeId,
            PurchaseDate = purchaseDate
        };
    }
}