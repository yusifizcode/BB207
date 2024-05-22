using System.ComponentModel.DataAnnotations;

namespace Eflyer.Areas.Admin.ViewModels;

public class AdminLoginVm
{
    [Required]
    [StringLength(maximumLength: 10, MinimumLength = 10)]
    public string UserName { get; set; }
    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
