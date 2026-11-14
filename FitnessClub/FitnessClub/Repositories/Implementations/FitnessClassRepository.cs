using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities.Enum;
using FitnessClub.Entities;

namespace FitnessClub.Repositories.Implementations;

internal class FitnessClassRepository : IFitnessClassRepository
{
    public void CreateClass(FitnessClass fitnessClass) { }
    public void DeleteClass(int id) { }
    public FitnessClass ReadClassById(int id) => FitnessClass.CreateOperation(0, 0, string.Empty, Entities.Enum.WeekDays.None, 0);
    public IEnumerable<FitnessClass> ReadClasses() => new List<FitnessClass>();
    public void UpdateClass(FitnessClass fitnessClass) { }
}