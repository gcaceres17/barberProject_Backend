using barberProject_Backend.Models;

namespace barberProject_Backend.Dto
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }

    }
}
