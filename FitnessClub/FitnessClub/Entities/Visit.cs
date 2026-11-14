using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class Visit
{
    public int Id { get; private set; }
    public int ClientId { get; private set; }
    public int ClassId { get; private set; }
    public DateTime VisitDate { get; private set; }

    public static Visit CreateOperation(int id, int clientId, int classId, DateTime visitDate)
    {
        return new Visit
        {
            Id = id,
            ClientId = clientId,
            ClassId = classId,
            VisitDate = visitDate
        };
    }
}