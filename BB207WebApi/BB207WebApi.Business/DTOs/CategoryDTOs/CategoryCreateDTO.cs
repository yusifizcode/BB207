using FluentValidation;

namespace BB207WebApi.Business.DTOs.CategoryDTOs;

public class CategoryCreateDTO
{
    public string Name { get; set; }
}

public class CategoryCreateDTOValidator : AbstractValidator<CategoryCreateDTO>
{
    public CategoryCreateDTOValidator()
    {
        RuleFor(x => x.Name)
            .MaximumLength(50).WithMessage("Name uzunlugu maximum 50 ola biler!")
            .NotEmpty().WithMessage("Name bosh ola bilmez!!");
    }
}