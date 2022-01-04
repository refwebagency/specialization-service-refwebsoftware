using System.ComponentModel.DataAnnotations;

namespace SpecializationService.Models
{
    public class Specialization
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}