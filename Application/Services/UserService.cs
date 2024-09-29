using Domain.Models;
using Persistence.Repositories;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> GetUserById(Guid id)
        {
            var user = await _userRepository.GetUserById(id);
            if (user == null)
            {
                throw new Exception("User not found");
            }
            return user;
        }

        public async Task CreateUser(User user)
        {
            await _userRepository.CreateUser(user);
        }

        public async Task UpdateUser(User user)
        {
            var existingUser = await _userRepository.GetUserById(user.Id);
            if (existingUser == null)
            {
                throw new Exception("User not found");
            }
            await _userRepository.UpdateUser(user);
        }
    }
}