using FluentValidation;

namespace StrawMusic.Application.Music.Queries;
public class MusicQueryValidator : AbstractValidator<MusicQuery>
{
    public MusicQueryValidator()
    {
        RuleFor(x => x.id).NotEmpty();
    }
}

