using System.ComponentModel.DataAnnotations;

namespace YouCode.Models.Entity
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [MaxLength(50),MinLength(3)]
        public string Name { get; set; }

        [Required,EmailAddress,MaxLength(120)]
        public string Email { get; set; }

        [MaxLength(60),MinLength(3)]
        public string Subject { get; set; }

        [MaxLength(500), MinLength(10)]
        public string Message { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
