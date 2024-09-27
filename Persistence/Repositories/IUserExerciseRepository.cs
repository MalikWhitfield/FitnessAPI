using Domain.Models;

namespace Persistence.Repositories
{
    public interface IUserExerciseRepository
    {
        Task<List<UserExercise>> GetUserExercises();
        Task<UserExercise> GetUserExerciseById(int id);
        Task CreateUserExercise(UserExercise userExercise);
    }
}
