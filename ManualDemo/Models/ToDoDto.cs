using System.ComponentModel.DataAnnotations;

namespace ManualDemo.Models
{
    public class ToDoDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
