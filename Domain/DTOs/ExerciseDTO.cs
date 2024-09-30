using Domain.Enums;

namespace Domain.DTOs
{
    public class ExerciseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ExerciseType ExerciseType { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
