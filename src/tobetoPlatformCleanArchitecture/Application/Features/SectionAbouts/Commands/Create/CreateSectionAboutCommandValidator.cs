using FluentValidation;

namespace Application.Features.SectionAbouts.Commands.Create;

public class CreateSectionAboutCommandValidator : AbstractValidator<CreateSectionAboutCommand>
{
    public CreateSectionAboutCommandValidator()
    {
        RuleFor(c => c.ProducerCompanyId).NotEmpty();
        RuleFor(c => c.SectionId).NotEmpty();
        RuleFor(c => c.LanguageId).NotEmpty();
        RuleFor(c => c.Text).NotEmpty();
        RuleFor(c => c.EstimatedDuration).NotEmpty();
     
    }
}