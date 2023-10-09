using FluentValidation;

namespace Helios.Application.Music.Command.Upload;

public class UploadCommandValidation : AbstractValidator<UploadCommand>
{
    public UploadCommandValidation()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Permalink).NotEmpty();
    }
}