using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessClub.Entities;
using FitnessClub.Entities.Enum;

namespace FitnessClub.Repositories.Implementations;

internal class TrainerRepository : ITrainerRepository
{
    public void CreateTrainer(Trainer trainer) { }
    public void DeleteTrainer(int id) { }
    public Trainer ReadTrainerById(int id) => Trainer.CreateEntity(0, string.Empty, string.Empty);
    public IEnumerable<Trainer> ReadTrainers() => new List<Trainer>();
    public void UpdateTrainer(Trainer trainer) { }
}