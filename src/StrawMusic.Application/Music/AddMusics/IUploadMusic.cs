using ErrorOr;
using StrawMusic.Application.ModelDto.AddMusics;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.AddMusics;
public interface IUploadMusic
{
    Task<ErrorOr<MusicResult>> AddMusic(MusicDto request);
}

