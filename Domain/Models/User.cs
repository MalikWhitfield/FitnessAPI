using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
    }
}
