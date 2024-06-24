using FluentValidation;
using Store.Domain.DTO.Category;

namespace Store.Application.Validators;

public class CategoryValidator: AbstractValidator<WriteCategoryDTO>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Category name is required")
            .Length(3, 50).WithMessage("Category name must be between 3 and 50 characters")
            .Matches("^[a-zA-Z]+$").WithMessage("Category name must contain only letters");

        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Category description is required")
            .Length(3, 50).WithMessage("Category description must be between 3 and 50 characters")
            .Matches("^[a-zA-Z]+$").WithMessage("Category description must contain only letters");
    }
}