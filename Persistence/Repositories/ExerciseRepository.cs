
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class ExerciseRepository
    {
        private readonly DataContext _dataContext;

        public ExerciseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Exercise>> GetExercises()
        {
            return await _dataContext.Exercises.ToListAsync();
        }

        //public async Task<List<Exercise>> GetExerciseById(string id)
        //{
        //    return await _dataContext.Exercises.FirstOrDefaultAsync(e => e.Id == id);
        //}
    }
}
