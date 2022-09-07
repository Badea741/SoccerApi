using System.ComponentModel.DataAnnotations;

namespace Soccer.Shared.Dtos
{
    public class PlayerDto : BaseDto
    {
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Nationality { get; set; } = string.Empty;
        [Required]
        public Guid TeamId { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public string? Image { get; set; } = string.Empty;

    }
}