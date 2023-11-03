using ErrorOr;
using StrawMusic.Application.Services.Music.Commons;
using MediatR;

namespace StrawMusic.Application.Music.Queries;
public record MusicQuery(long id) : IRequest<ErrorOr<MusicResult>>;

