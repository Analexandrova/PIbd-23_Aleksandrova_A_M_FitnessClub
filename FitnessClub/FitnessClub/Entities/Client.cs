using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class Client
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;

    public static Client CreateEntity(int id, string fullName, string phone)
    {
        return new Client
        {
            Id = id,
            FullName = fullName ?? string.Empty, // Защита от null
            Phone = phone ?? string.Empty        // Защита от null
        };
    }
}
