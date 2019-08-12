using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForregisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "password should between 4 to 8 charactors")]
        public string Password { get; set; }
    }
}