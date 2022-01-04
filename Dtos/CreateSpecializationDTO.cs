using System.ComponentModel.DataAnnotations;

namespace SpecializationService.Dtos
{
    public class CreateSpecializationDTO
    {   
        [Required]
        public string Name { get; set; }
    }
}