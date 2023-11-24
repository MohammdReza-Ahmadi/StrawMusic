using ErrorOr;
using StrawMusic.Application.ModelDto.AddMusics;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.UpdateMusics;
public interface IUpdateMusics
{
    Task<ErrorOr<MusicResult>> UpdateMusic(MusicDto request);
}

