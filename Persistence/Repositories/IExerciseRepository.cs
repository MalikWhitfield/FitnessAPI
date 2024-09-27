using Domain.Models;


namespace Persistence.Repositories
{
    public interface IExerciseRepository
    {
        Task<List<Exercise>> GetExercises();
        Task<Exercise> GetExerciseById(int id);
    }
}
