using Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Exercise
    {
        // Get and Set is for Entity Framework to be able to get and set the properties
        // Went with int ID here because I wanted it to be human readable
        public int Id { get; set; }
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
