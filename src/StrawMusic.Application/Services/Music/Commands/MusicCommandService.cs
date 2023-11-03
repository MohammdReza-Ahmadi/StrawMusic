using ErrorOr;
using StrawMusic.Application.Services.Music.Commands;
using StrawMusic.Application.Services.Music.Commons;
using StrawMusic.Domain.Entities;

namespace StrawMusic.Application.Music.Commands;

public class MusicCommandService : IMusicCommandService
{
    public ErrorOr<MusicResult> UploadMusic(string title, string additionalTags, int rate, string permalink, string description, string caption, byte[] content)
    {
            var uploadMusic = new MusicEntity{
            Title = title,
            AdditionalTags = additionalTags,
            Rate = rate,
            Caption = caption,
            Content = content,
            Description = description,
            Permalink = permalink
        };

        return new MusicResult(uploadMusic);
    }
}