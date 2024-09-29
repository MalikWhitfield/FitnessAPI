using Domain.Models;
using Persistence.Repositories;


namespace Application.Services
{
    public class UserExerciseService : IUserExerciseService
    {
        private readonly IUserExerciseRepository _userExerciseRepository;

        public UserExerciseService(IUserExerciseRepository userExerciseRepository)
        {
            _userExerciseRepository = userExerciseRepository;
        }

        public async Task<List<UserExercise>> GetAllUserExercises()
        {
            return await _userExerciseRepository.GetUserExercises();
        }

        public async Task<UserExercise> GetUserExerciseById(int id)
        {
            var userExercise = await _userExerciseRepository.GetUserExerciseById(id);
            if (userExercise == null)
            {
                throw new Exception("User exercise not found");
            }
            return userExercise;
        }

        public async Task CreateUserExercise(UserExercise userExercise)
        {
            await _userExerciseRepository.CreateUserExercise(userExercise);
        }

        public async Task<UserExercise> UpdateUserExercise(UserExercise userExercise)
        {
            var existingUserExercise = await _userExerciseRepository.GetUserExerciseById(userExercise.Id);
            if (existingUserExercise == null)
            {
                throw new Exception("User exercise not found");
            }

            var result = await _userExerciseRepository.UpdateUserExercise(userExercise);
            return result;
        }
    }
}
