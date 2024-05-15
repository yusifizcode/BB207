using ProniaBB207.Core.Models;

namespace ProniaBB207.Business.Services.Abstracts;

public interface ICategoryService
{
    void AddCategory(Category category);
    void DeleteCategory(int id);
    void UpdateCategory(int id, Category newCategory);

    Category GetCategory(Func<Category, bool>? func = null);
    List<Category> GetAllCategories(Func<Category, bool>? func = null);
}
