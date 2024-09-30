using AutoMapper;
using Domain.DTOs;
using Domain.Models;

namespace Application.Utilities
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<ExerciseDTO, ExerciseDTO>().ReverseMap();
            CreateMap<UserExerciseDTO, UserExerciseDTO>().ReverseMap();
        }
    }
}
