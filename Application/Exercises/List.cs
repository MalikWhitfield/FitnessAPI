using MediatR;
using Domain.Models;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Exercises
{
    public class ExerciseList
    {
        public class Query : IRequest<List<Exercise>> { }
        public class Handler : IRequestHandler<Query, List<Exercise>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public async Task<List<Exercise>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Exercises.ToListAsync();
            }
        }
    }
}
