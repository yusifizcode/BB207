using BB207WebApi.Business.DTOs.CategoryDTOs;
using BB207WebApi.Core.Models;

namespace BB207WebApi.Business.Services.Abstracts;

public interface ICategoryService
{
    void SoftDelete(int id);
    void HardDelete(int id);
    void Add(CategoryCreateDTO createDTO);
    void Update(CategoryUpdateDTO updateDTO);

    CategoryGetDTO Get(Func<Category, bool>? func = null);
    ICollection<CategoryGetDTO> GetAll(Func<Category, bool>? func = null);
}
