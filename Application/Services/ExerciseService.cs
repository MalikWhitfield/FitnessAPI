using Domain.Models;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ExerciseService : IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseService(IExerciseRepository exerciseRepository)
        {
            _exerciseRepository = exerciseRepository;
        }

        public async Task<List<Exercise>> GetAllExercises()
        {
            return await _exerciseRepository.GetExercises();
        }

        public async Task<Exercise> GetExerciseById(int id)
        {
            var exercise = await _exerciseRepository.GetExerciseById(id);
            if (exercise == null)
            {
                throw new Exception("Exercise not found");
            }
            return exercise;
        }

    }
}
