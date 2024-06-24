using FluentValidation;
using Store.Domain.DTO.Product;

namespace Store.Application.Validators;

public class ProductValidator: AbstractValidator<WriteProductDTO>
{
    public ProductValidator()
    {
        RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Product name is required.")
            .Length(2, 50).WithMessage("First name must be between 2 and 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("Product name must contain only letters.");

        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("Product description is required.")
            .Length(3, 50).WithMessage("Product description must be between 2 and 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("Product description must contain only letters.");

        RuleFor(p => p.Price)
            .NotEmpty().WithMessage("Product price is required.")
            .GreaterThan(0).WithMessage("Product price must be greater than 0.")
            .LessThan(10000).WithMessage("Product price must be less then 10000");

        RuleFor(p => p.StockQuantity)
            .NotEmpty().WithMessage("Product stock quantity is required.")
            .GreaterThan(0).WithMessage("Product stock quantity must be greater than 0")
            .LessThan(500).WithMessage("Product stock quantity must be less than 500");

        RuleFor(p => p.ExpireDate)
            .NotEmpty().WithMessage("Product expire date is required.")
            .Must(BeValidExpireDate).WithMessage("Expire date must be greater than date of now");

        RuleFor(p => p.Brand)
            .NotEmpty().WithMessage("Product brand is required")
            .Length(5, 50).WithMessage("Product brand must be between 2 and 50 characters");

        RuleFor(p => p.CategoryId)
            .NotEmpty().WithMessage("CategoryId required .")
            .GreaterThan(0).WithMessage("CategoryId must be greater than 0");

    }
    
    private bool BeValidExpireDate(DateTime expireDate)
    {
        // Ensure expireDate is greater than DateTime.Now
        return expireDate > DateTime.Now;
    }
}