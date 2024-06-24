using FluentValidation;
using Store.Domain.DTO.User;

namespace Store.Application.Validators;

public class UserValidator: AbstractValidator<WriteUserDTO>
{
    public UserValidator()
    {
        RuleFor(u => u.Name)
            .NotEmpty().WithMessage("Name is required")
            .Length(2, 50).WithMessage("First name must be between 2 and 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("First name must contain only letters.");
        
        RuleFor(u => u.Surname)
            .NotEmpty().WithMessage("Surname is required")
            .Length(3, 50).WithMessage("Surname must be between 2 and 50 characters.")
            .Matches("^[a-zA-Z]+$").WithMessage("Surname must contain only letters.");
        
        RuleFor(u => u.Email)
            .NotEmpty().WithMessage("Email is required")
            .Length(11,50).WithMessage("Email must be between 11 and 50 characters.")
            .Must(email => email.EndsWith("@gmail.com")).WithMessage("Email must be a Gmail address.");

        RuleFor(u => u.Password)
            .NotEmpty().WithMessage("Password is required")
            .Length(8, 20).WithMessage("Password must be at least 8 characters long.")
            .Must(BeValidPassword).WithMessage("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special symbol.");
        
        RuleFor(u => u.RoleId)
            .NotEmpty().WithMessage("RoleId is required.")
            .GreaterThan(0).WithMessage("RoleId must be greater than zero.");
    }
    
    private bool BeValidPassword(string password)
    {
        // Define regular expressions for each password requirement
        var hasUppercase = new System.Text.RegularExpressions.Regex(@"[A-Z]+");
        var hasLowercase = new System.Text.RegularExpressions.Regex(@"[a-z]+");
        var hasDigit = new System.Text.RegularExpressions.Regex(@"\d+");
        var hasSpecialChar = new System.Text.RegularExpressions.Regex(@"\W+");

        // Check if password meets all criteria
        return hasUppercase.IsMatch(password)
               && hasLowercase.IsMatch(password)
               && hasDigit.IsMatch(password)
               && hasSpecialChar.IsMatch(password);
    }
    
}