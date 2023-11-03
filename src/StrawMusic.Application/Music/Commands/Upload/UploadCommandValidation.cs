using FluentValidation;

namespace StrawMusic.Application.Music.Command.Upload;

public class UploadCommandValidation : AbstractValidator<UploadCommand>
{
    public UploadCommandValidation()
    {
        RuleFor(x => x.Title).NotEmpty();
    }
}