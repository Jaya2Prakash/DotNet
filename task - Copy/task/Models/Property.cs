using System.ComponentModel.DataAnnotations;

namespace task.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        
        public string Email { get; set; }

        [MinLength(8,ErrorMessage = "Password must contains minimum of 8 characters")]
        public string Password { get; set; }
    }
}
