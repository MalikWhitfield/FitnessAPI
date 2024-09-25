using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Exercise
    {
        // Get and Set is for Entity Framework to be able to get and set the properties
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public List<MuscleGroup> MuscleGroups { get; set; }
    }
}
