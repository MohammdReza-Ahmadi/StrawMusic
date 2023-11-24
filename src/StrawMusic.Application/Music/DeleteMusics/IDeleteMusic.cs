using ErrorOr;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.DeleteMusics;
public interface IDeleteMusic
{
    Task<ErrorOr<MusicResult>> DeleteMusicById(long id);
}

