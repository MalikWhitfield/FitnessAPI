using Domain.Models;
using MediatR;
using Persistence;

namespace Application.Exercises
{
    public class CreateExercise
    {
        public class Command : IRequest
        {
            public Exercise Exercise { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _dataContext;

            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                _dataContext.Exercises.Add(request.Exercise);

                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
