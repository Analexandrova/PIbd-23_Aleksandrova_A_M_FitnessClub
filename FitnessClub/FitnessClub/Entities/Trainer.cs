using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class Trainer
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string Specialization { get; private set; } = string.Empty;

    public static Trainer CreateEntity(int id, string fullName, string specialization)
    {
        return new Trainer
        {
            Id = id,
            FullName = fullName ?? string.Empty,
            Specialization = specialization ?? string.Empty
        };
    }
}