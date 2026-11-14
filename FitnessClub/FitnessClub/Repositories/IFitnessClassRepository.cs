using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities.Enum;
using FitnessClub.Entities;

namespace FitnessClub.Repositories;

public interface IFitnessClassRepository
{
    IEnumerable<FitnessClass> ReadClasses();
    FitnessClass ReadClassById(int id); 
    void CreateClass(FitnessClass fitnessClass);
    void UpdateClass(FitnessClass fitnessClass); 
    void DeleteClass(int id); 
}