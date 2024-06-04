using AutoMapper;
using BB207WebApi.Business.DTOs.CategoryDTOs;
using BB207WebApi.Core.Models;

namespace BB207WebApi.Business.Mapping;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CategoryCreateDTO, Category>().ReverseMap();
        CreateMap<Category, CategoryGetDTO>().ReverseMap();
    }
}
