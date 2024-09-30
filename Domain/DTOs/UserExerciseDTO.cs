
namespace Domain.DTOs
{
    public class UserExerciseDTO
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public Guid UserId { get; set; }
        public int MaxWeight { get; set; }
        public int BestTime { get; set; }
        public ExerciseDTO Exercise { get; set; }
        public UserDTO User { get; set; }
    }
}
