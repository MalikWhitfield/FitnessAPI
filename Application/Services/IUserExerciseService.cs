using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IUserExerciseService
    {
        Task<List<UserExercise>> GetAllUserExercises();
        Task<UserExercise> GetUserExerciseById(int id);
        Task CreateUserExercise(UserExercise userExercise);
        Task<UserExercise> UpdateUserExercise(UserExercise userExercise);
    }
}