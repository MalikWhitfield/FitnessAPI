using Domain.DTOs;
using Domain.Models;


namespace Application.Services
{
    public interface IUserService
    {
        Task<List<UserDTO>> GetAllUsers();
        Task<User> GetUserById(Guid id);
        Task CreateUser(User user);
        Task UpdateUser(User user);
    }
}