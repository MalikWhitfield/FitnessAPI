using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Exercise
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public List<MuscleGroup> MuscleGroups { get; set; }
    }
}
