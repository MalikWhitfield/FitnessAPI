using Domain.Models;

namespace Application.Services
{
    public interface IExerciseService
    {
        Task<List<Exercise>> GetAllExercises();
        Task<Exercise> GetExerciseById(int id);
    }
}
