using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities;
using FitnessClub.Entities.Enum;

namespace FitnessClub.Repositories;

public interface ITrainerRepository
{
    IEnumerable<Trainer> ReadTrainers();
    Trainer ReadTrainerById(int id);
    void CreateTrainer(Trainer trainer);
    void UpdateTrainer(Trainer trainer);
    void DeleteTrainer(int id);
}