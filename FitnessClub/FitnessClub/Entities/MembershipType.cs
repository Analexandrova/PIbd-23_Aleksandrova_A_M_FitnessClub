using FitnessClub.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class MembershipType
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public decimal Price { get; private set; }
    public int DurationDays { get; private set; }
    public MembershipCategory Category { get; private set; }

    public static MembershipType CreateEntity(int id, string name, decimal price, int durationDays, MembershipCategory category)
    {
        return new MembershipType
        {
            Id = id,
            Name = name ?? string.Empty,
            Price = price,
            DurationDays = durationDays,
            Category = category
        };
    }
}