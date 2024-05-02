using Business.Services.Abstracts;
using Core.Models;
using Core.RepositoryAbstracts;
using Data.RepositoryConcretes;

namespace Business.Services.Concretes;

public class CategoryService : ICategoryService
{
    ICategoryRepository _repository = new CategoryRepository();
    public void AddCategory(Category category)
    {
        if (!_repository.GetAll(null).Any(x => x.Name == category.Name))
        {
            _repository.Add(category);
            _repository.Commit();
        }
    }

    public void DeleteCategory(int id)
    {
        var category = _repository.Get(x => x.Id == id);
        if (category == null) throw new NullReferenceException();

        _repository.Delete(category);
        _repository.Commit();
    }

    public List<Category> GetAllCategories(Func<Category, bool>? predicate)
    {
        return _repository.GetAll(predicate);
    }

    public Category GetCategory(Func<Category, bool>? predicate)
    {
        return _repository.Get(predicate);
    }

    public void UpdateCategory(int id, Category category)
    {
        var oldCategory = _repository.Get(x => x.Id == id);
        if (oldCategory == null) throw new NullReferenceException();

        if (!_repository.GetAll(null).Any(x => x.Name == category.Name))
        {
            oldCategory.Name = category.Name;
            _repository.Commit();
        }
    }
}
