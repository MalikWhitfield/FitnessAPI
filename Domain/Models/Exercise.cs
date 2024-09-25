using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Exercise
    {
        // Get and Set is for Entity Framework to be able to get and set the properties
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(160)]
        public string Description { get; set; }
        [MaxLength(30)]
        public ExerciseType ExerciseType { get; set; }
        [MaxLength(12)]
        public MuscleGroup MuscleGroup { get; set; }
    }
}
