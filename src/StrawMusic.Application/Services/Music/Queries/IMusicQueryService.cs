using ErrorOr;
using StrawMusic.Application.Services.Music.Commons;

namespace StrawMusic.Application.Services.Music.Queries;
public interface IMusicQueryService
{
    ErrorOr<MusicResult> GetMusicById(Guid id);
}

