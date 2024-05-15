using System.ComponentModel.DataAnnotations;

namespace ProniaBB207.Core.Models;

public class Category : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;
}
