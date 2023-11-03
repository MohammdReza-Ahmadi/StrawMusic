using ErrorOr;
using Helios.Application.Services.Music.Commons;
using MediatR;

namespace Helios.Application.Music.Queries
{
    public record MusicQuery(long id):IRequest<ErrorOr<MusicResult>>;
}
