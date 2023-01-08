using System.ComponentModel.DataAnnotations;

namespace productwebsitedotnetcore.Entities
{
    //[tablename]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string? NameSurname { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required] 
        [StringLength(100)]
        public string Password { get; set; }
        public bool Locked { get; set; } = false;
        public DateTime CreatAt { get; set; } = DateTime.Now;
        [Required]
        public string Role { get; set; } = "User";
    }
}

//firsmigration initialcreate