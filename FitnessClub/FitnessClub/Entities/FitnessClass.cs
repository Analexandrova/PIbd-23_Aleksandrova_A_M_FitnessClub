using FitnessClub.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClub.Entities;

public class FitnessClass
{
    public int Id { get; private set; }
    public int TrainerId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public WeekDays ScheduleDays { get; private set; }
    public int MaxPlaces { get; private set; }

    public static FitnessClass CreateOperation(int id, int trainerId, string name, WeekDays scheduleDays, int maxPlaces)
    {
        return new FitnessClass
        {
            Id = id,
            TrainerId = trainerId,
            Name = name ?? string.Empty,
            ScheduleDays = scheduleDays,
            MaxPlaces = maxPlaces
        };
    }
}