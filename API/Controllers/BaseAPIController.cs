using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class BaseAPIController : ControllerBase
    {
        private IExerciseRepository _exerciseRepository;
        protected IExerciseRepository ExerciseRepository => _exerciseRepository ??= HttpContext.RequestServices.GetService<IExerciseRepository>();
    }
}
