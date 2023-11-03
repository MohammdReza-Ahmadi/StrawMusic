using ErrorOr;
using Helios.Application.Authentication.Queries.Login;
using Helios.Application.Services.Music.Commons;
using MediatR;

namespace Helios.Application.Music.Queries
{
    public class MusicQueryHandler : IRequestHandler<MusicQuery, ErrorOr<MusicResult>>
    {
        public Task<ErrorOr<MusicResult>> Handle(MusicQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
