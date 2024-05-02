using Core.Models;

namespace Business.Services.Abstracts;

public interface ICategoryService
{
    void DeleteCategory(int id);
    void AddCategory(Category category);
    void UpdateCategory(int id, Category category);

    Category GetCategory(Func<Category, bool>? predicate);
    List<Category> GetAllCategories(Func<Category, bool>? predicate);
}
