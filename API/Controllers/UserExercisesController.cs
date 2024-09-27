using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Persistence;
using Persistence.Repositories;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserExercisesController : ControllerBase
    {
        private readonly IUserExerciseRepository _repository;

        public UserExercisesController(IUserExerciseRepository repository)
        {
            _repository = repository;
        }

        // GET: api/UserExcercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserExercise>>> GetUserExercises()
        {
            return await _repository.GetUserExercises();
        }

        // GET: api/UserExcercises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserExercise>> GetUserExercise(int id)
        {
            var exercise = await _repository.GetUserExerciseById(id);

            if (exercise == null)
            {
                return NotFound();
            }

            return exercise;
        }

        // POST: api/UserExcercises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult> CreateUserExercise([FromBody] UserExercise exercise)
        {
            try
            {
                await _repository.CreateUserExercise(exercise);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return CreatedAtAction("CreateUserExercise", new { id = exercise.Id }, exercise);
        }

        // PUT: api/UserExcercises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutExercise(int id, Exercise exercise)
        //{
        //    if (id != exercise.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(exercise).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ExerciseExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}


        // DELETE: api/UserExcercises/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteExercise(string id)
        //{
        //    var exercise = await _context.Exercises.FindAsync(id);
        //    if (exercise == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Exercises.Remove(exercise);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

    }
}
