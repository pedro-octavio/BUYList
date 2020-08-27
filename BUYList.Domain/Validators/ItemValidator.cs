using BUYList.Domain.Entities;
using FluentValidation;

namespace BUYList.Domain.Validators
{
    public class ItemValidator :
    AbstractValidator<Item>
    {
        public ItemValidator
        ()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("The name cannot be null.")
                .NotEmpty().WithMessage("The name cannot be empty")
                .MaximumLength(30).WithMessage("The maximum length of name is 30.");

            RuleFor(x => x.Description)
                .MaximumLength(200).WithMessage("The maximum length of description is 200.");

            RuleFor(x => x.CreateDate)
                .NotNull().WithMessage("The creat date cannot be null");

            RuleFor(x => x.UserId)
                .NotNull().WithMessage("The userId cannot be null.");
        }
    }
}
