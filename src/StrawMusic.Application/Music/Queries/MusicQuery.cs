using ErrorOr;
using StrawMusic.Application.Services.Music.Commons;
using MediatR;

namespace StrawMusic.Application.Music.Queries;
public record MusicQuery(Guid id) : IRequest<ErrorOr<MusicResult>>;

