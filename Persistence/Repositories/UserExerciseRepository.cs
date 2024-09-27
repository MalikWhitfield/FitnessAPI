
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class UserExerciseRepository : IUserExerciseRepository
    {
        private readonly DataContext _context;

        public UserExerciseRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<UserExercise>> GetUserExercises()
        {
            return await _context.UserExercises.ToListAsync();
        }

        public async Task<UserExercise> GetUserExerciseById(int id)
        {
            return await _context.UserExercises.FirstOrDefaultAsync(ue => ue.Id == id);
        }

        public async Task CreateUserExercise(UserExercise userExercise)
        {
            await _context.AddAsync(userExercise);
            await _context.SaveChangesAsync();
        }
    }
}
