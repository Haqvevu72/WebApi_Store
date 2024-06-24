using FluentValidation;
using Store.Domain.DTO.Invoice;

namespace Store.Application.Validators;

public class InvoiceValidator: AbstractValidator<WriteInvoiceDTO>
{
    public InvoiceValidator()
    {
        RuleFor(i => i.InvoiceType)
            .NotEmpty().WithMessage("Invoice type is required.")
            .Must(BeValidInvoiceType).WithMessage("Invalid invoice type");

        RuleFor(i => i.CashierId)
            .NotEmpty().WithMessage("Cashier Id is required")
            .GreaterThan(0).WithMessage("Cashier Id must be greater than 0");
        
        RuleFor(i => i.CustomerId)
            .NotEmpty().WithMessage("Customer Id is required")
            .GreaterThan(0).WithMessage("Customer Id must be greater than 0");

        RuleFor(i => i.InvoiceItems)
            .NotEmpty().WithMessage("Invoice items are required.");
    }
    
    private bool BeValidInvoiceType(string invoiceType)
    {
        // Ensure invoiceType is either "Sell" or "Refund"
        return invoiceType == "Sell" || invoiceType == "Refund";
    }
}