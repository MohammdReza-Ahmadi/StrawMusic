using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Services.Music.Commons;
using StrawMusic.Domain.Entities;
using MediatR;

namespace StrawMusic.Application.Music.Command.Upload;

public class UploadCommandHandler : IRequestHandler<UploadCommand, ErrorOr<MusicResult>>
{
    private readonly IMusicRepository _musicRepository;
    public UploadCommandHandler(IMusicRepository musicRepository)
    {
        _musicRepository = musicRepository;
    }
    public async Task<ErrorOr<MusicResult>> Handle(
        UploadCommand request,
        CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var music = new MusicEntity{
            Id = Guid.NewGuid(),
            Title = request.Title,
            Permalink = request.Permalink,
            AdditionalTags = request.AdditionalTags,
            Caption = request.Caption,
            Content = request.Content,
            Description = request.Description,
            Rate = request.Rate
        };
        _musicRepository.AddMusic(music);
        Console.WriteLine($"{music.Id}");

        return new MusicResult(music);
    }
}