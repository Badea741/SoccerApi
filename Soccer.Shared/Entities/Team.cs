using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonGenericClasses;

namespace Soccer.Shared.Entities;
public class Team : BaseEntity
{
    public Team()
    {
        Players = new HashSet<Player>();
    }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Country { get; set; } = string.Empty;
    [Required]
    public DateTime Founded { get; set; }
    [Required]
    public string CoachName { get; set; } = string.Empty;
    [DataType("longblob")]
    public byte[]? Logo { get; set; } = null!;
    public virtual ICollection<Player> Players { get; set; }
}