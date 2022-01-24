using System.ComponentModel.DataAnnotations;

namespace SpecializationService.Dtos
{
    public class UpdateSpecializationAsyncDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Event { get; set; }
    }
}