using ErrorOr;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.GetMusics;
public interface IGetMusicsService
{
    Task<ErrorOr<MusicResult>> GetMusicById(long id);
}
