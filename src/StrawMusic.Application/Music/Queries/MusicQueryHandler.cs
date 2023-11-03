using ErrorOr;
using StrawMusic.Application.Authentication.Queries.Login;
using StrawMusic.Application.Services.Music.Commons;
using MediatR;

namespace StrawMusic.Application.Music.Queries;
public class MusicQueryHandler : IRequestHandler<MusicQuery, ErrorOr<MusicResult>>
{
    public Task<ErrorOr<MusicResult>> Handle(MusicQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

