using System.ComponentModel.DataAnnotations;

namespace productwebsitedotnetcore.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username Zorunludur.")]
        [StringLength(30)]
        public string Username { get; set; }
        //[DataType(DataType.Password)]
        [Required]
        [MinLength(6)]
        [MaxLength(16)]
        public string Password { get; set; }
    }
}
