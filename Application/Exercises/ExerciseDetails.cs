using Domain.Models;
using MediatR;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exercises
{
    public class ExerciseDetails
    {
        public class Query : IRequest<Exercise>
        {
            public Guid Id { get; set; }
        }


        public class Handler : IRequestHandler<Query, Exercise>
        {
            private readonly DataContext _dataContext;
            public Handler(DataContext dataContext)
            {
                _dataContext = dataContext;
            }

            public async Task<Exercise> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _dataContext.Exercises.FindAsync(request.Id, cancellationToken);
            }
        }
    }
}
