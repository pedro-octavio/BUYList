using BUYList.Domain.Entities;
using FluentValidation;

namespace BUYList.Domain.Validators
{
    public class UserValidator :
    AbstractValidator<User>
    {
        public UserValidator
        ()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("The name cannot be empty.")
                .NotNull().WithMessage("The name cannot be null")
                .Length(4, 25).WithMessage("The name length must be between 4 and 25.");

            RuleFor(x => x.Email)
                .EmailAddress().WithMessage("The email is not valid.")
                .MaximumLength(50).WithMessage("The maximum length of email is 50.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("The password cannot be empty.")
                .NotNull().WithMessage("The password cannot be null.")
                .Length(6, 200).WithMessage("The password length must be between 6 and 200.");
        }
    }
}
