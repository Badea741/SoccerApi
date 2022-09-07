using System.ComponentModel.DataAnnotations;

namespace Soccer.Shared.Dtos;

public class TeamDto : BaseDto
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Country { get; set; } = string.Empty;
    [Required]
    public DateTime Founded { get; set; }
    [Required]
    public string CoachName { get; set; } = string.Empty;
    public string? Logo { get; set; } = string.Empty;
    public virtual ICollection<PlayerDto>? Players { get; set; }

}