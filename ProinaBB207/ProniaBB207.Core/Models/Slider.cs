using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaBB207.Core.Models;

public class Slider : BaseEntity
{
    [Required]
    [StringLength(50)]
    public string Title { get; set; } = null!;
    [Required]
    [StringLength(100)]
    public string Subtitle { get; set; } = null!;
    [StringLength(250)]
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }

    [NotMapped]
    public IFormFile? ImageFile { get; set; } = null!;
}
