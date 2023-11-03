using ErrorOr;
using Helios.Application.Services.Music.Commands;
using Helios.Application.Services.Music.Commons;
using Helios.Domain.Entities;

namespace Helios.Application.Music.Commands;

public class MusicCommandService : IMusicCommandService
{
    public ErrorOr<MusicResult> UploadMusic(string title, string additionalTags, int rate, string permalink, string description, string caption, byte[] content)
    {
            var uploadMusic = new Domain.Entities.Music{
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