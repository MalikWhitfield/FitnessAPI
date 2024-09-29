
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
            await _context.UserExercises.AddAsync(userExercise);
            await _context.SaveChangesAsync();
        }
        public async Task<UserExercise> UpdateUserExercise(UserExercise userExercise)
        {
            _context.Entry(userExercise).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception(ex.Message);
            }
            await _context.SaveChangesAsync();

            return userExercise;
        }
    }
}
