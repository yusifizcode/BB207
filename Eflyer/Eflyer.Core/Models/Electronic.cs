using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eflyer.Core.Models;

public class Electronic : BaseEntity
{
    [Required]
    [MaxLength(50)]
    public string Title { get; set; } = null!;
    public int Price { get; set; }

    public string? ImageUrl { get; set; }
    [NotMapped]
    public IFormFile? ImageFile { get; set; }
}
