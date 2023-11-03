using ErrorOr;
using StrawMusic.Application.Authentication.Queries.Login;
using StrawMusic.Application.Services.Music.Commons;
using MediatR;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;

namespace StrawMusic.Application.Music.Queries;
public class MusicQueryHandler : IRequestHandler<MusicQuery, ErrorOr<MusicResult>>
{
    private readonly IMusicRepository _musicRepository;

    public MusicQueryHandler(IMusicRepository musicRepository)
    {
        _musicRepository = musicRepository;
    }

    public async Task<ErrorOr<MusicResult>> Handle(MusicQuery request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        return new MusicResult(_musicRepository.GetMusic(request.id));
    }
}

