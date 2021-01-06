using FluentValidation;

namespace Application.Funds.Commands.UpdateFund
{
  public class UpdateFundCommandValidator: AbstractValidator<UpdateFundCommand>
  {
    public UpdateFundCommandValidator()
    {
      RuleFor(v => v.Name)
          .MaximumLength(50)
          .NotEmpty();
    }
  }
}
