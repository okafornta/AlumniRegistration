using System.ComponentModel.DataAnnotations;

namespace AlumniRegistration.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? Address { get; set; }
        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Occupation { get; set; }
        [Required]
        public string? Gender { get; set; }
        [Required]
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
