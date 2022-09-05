using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CommonGenericClasses;

namespace Soccer.Shared.Entities;
public class Player : BaseEntity
{
    public Player()
    {
        Teams = new HashSet<Team>();
    }

    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public string Nationality { get; set; } = string.Empty;
    [ForeignKey("teamId")]
    public Guid TeamId { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [DataType("longblob")]
    public byte[]? Image { get; set; } = null!;
    public virtual ICollection<Team> Teams { get; set; } = null!;
}