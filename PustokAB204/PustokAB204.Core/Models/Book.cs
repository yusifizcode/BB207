using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokAB204.Core.Models;

public class Book : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public decimal DiscountPercent { get; set; }
    public string Description { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;

    [NotMapped]
    public IFormFile ImageFile { get; set; } = null!;

    public int GenreId { get; set; }
    public Genre Genre { get; set; }

    public List<Tag> Tags { get; set; }
}
