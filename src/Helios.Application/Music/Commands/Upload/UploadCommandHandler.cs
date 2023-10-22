using ErrorOr;
using Helios.Application.Common.Interfaces.Persistence;
using Helios.Application.Services.Music.Commons;
using Helios.Domain.Entities;
using MediatR;

namespace Helios.Application.Music.Command.Upload;

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
        var music = new UploadMusic{
            Title = request.Title,
            Permalink = request.Permalink,
            AdditionalTags = request.AdditionalTags,
            Caption = request.Caption,
            Content = request.Content,
            Description = request.Description,
            Rate = request.Rate
        };
        _musicRepository.AddMusic(music);

        return new MusicResult(music);
    }
}