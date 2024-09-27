using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Domain.Models;
using Persistence;
using MediatR;
using Application.Exercises;

namespace API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ExercisesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ExercisesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/Exercises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exercise>>> GetExercises()
        {
            return await _mediator.Send(new ExerciseList.Query());
        }

        // GET: api/Exercises/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Exercise>> GetExercise(Guid id)
        //{
        //    var exercise = await _context.Exercises.FindAsync(id);

        //    if (exercise == null)
        //    {
        //        return NotFound();
        //    }

        //    return exercise;
        //}

        //// PUT: api/Exercises/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutExercise(Guid id, Exercise exercise)
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

        //// POST: api/Exercises
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Exercise>> PostExercise(Exercise exercise)
        //{
        //    _context.Exercises.Add(exercise);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetExercise", new { id = exercise.Id }, exercise);
        //}

        //// DELETE: api/Exercises/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteExercise(Guid id)
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

        //private bool ExerciseExists(Guid id)
        //{
        //    return _context.Exercises.Any(e => e.Id == id);
        //}
    }
}
