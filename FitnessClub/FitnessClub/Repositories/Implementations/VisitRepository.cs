using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities;
using FitnessClub.Entities.Enum;

namespace FitnessClub.Repositories.Implementations;

internal class VisitRepository : IVisitRepository
{
    public void CreateVisit(Visit visit) { }
    public void DeleteVisit(int id) { }
    public Visit ReadVisitById(int id) => Visit.CreateOperation(0, 0, 0, DateTime.Now);
    public IEnumerable<Visit> ReadVisits() => new List<Visit>();
    public void UpdateVisit(Visit visit) { }
}