using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FitnessClub.Entities.Enum;
using System.Threading.Tasks;
using FitnessClub.Entities;

namespace FitnessClub.Repositories;

public interface IVisitRepository
{
    IEnumerable<Visit> ReadVisits();
    Visit ReadVisitById(int id); 
    void CreateVisit(Visit visit);
    void UpdateVisit(Visit visit); 
    void DeleteVisit(int id);
}