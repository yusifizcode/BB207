using AutoMapper;
using BB207WebApi.Business.DTOs.CategoryDTOs;
using BB207WebApi.Business.Services.Abstracts;
using BB207WebApi.Core.Models;
using BB207WebApi.Core.Repositories;

namespace BB207WebApi.Business.Services.Concretes;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public void Add(CategoryCreateDTO createDTO)
    {
        Category category = _mapper.Map<Category>(createDTO);
        _categoryRepository.Add(category);
        _categoryRepository.Commit();
    }

    public CategoryGetDTO Get(Func<Category, bool>? func = null)
    {
        var category = _categoryRepository.Get(func);

        CategoryGetDTO getDTO = _mapper.Map<CategoryGetDTO>(category);
        return getDTO;
    }

    public ICollection<CategoryGetDTO> GetAll(Func<Category, bool>? func = null)
    {
        var categories = _categoryRepository.GetAll(func);
        ICollection<CategoryGetDTO> dtoList = new List<CategoryGetDTO>();
        foreach (var category in categories)
        {
            CategoryGetDTO getDTO = new CategoryGetDTO
            {
                Id = category.Id,
                Name = category.Name,
            };

            dtoList.Add(getDTO);
        }
        return dtoList;
    }

    public void HardDelete(int id)
    {
        var existCategory = _categoryRepository.Get(x => x.Id == id);
        if (existCategory == null) throw new NullReferenceException();

        _categoryRepository.HardDelete(existCategory);
        _categoryRepository.Commit();
    }

    public void SoftDelete(int id)
    {
        var existCategory = _categoryRepository.Get(x => x.Id == id);
        if (existCategory == null) throw new NullReferenceException();

        existCategory.DeletedDate = DateTime.UtcNow.AddHours(4);
        _categoryRepository.SoftDelete(existCategory);
        _categoryRepository.Commit();
    }

    public void Update(CategoryUpdateDTO updateDTO)
    {
        var existCategory = _categoryRepository.Get(x => x.Id == updateDTO.Id);
        if (existCategory == null) throw new NullReferenceException();

        existCategory.Name = updateDTO.Name;
        _categoryRepository.Commit();
    }
}
