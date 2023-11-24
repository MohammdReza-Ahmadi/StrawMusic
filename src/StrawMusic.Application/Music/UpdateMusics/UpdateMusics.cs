using ErrorOr;
using Mapster;
using MapsterMapper;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.ModelDto.AddMusics;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.UpdateMusics;
public class UpdateMusics: IUpdateMusics
{
    private readonly IMusicRepository _musicRepository;
    private readonly IMapper _mapper;
    public UpdateMusics(IMusicRepository musicRepository, IMapper mapper = null)
    {
        _musicRepository = musicRepository;
        _mapper = mapper;
    }
    public async Task<ErrorOr<MusicResult>> UpdateMusic(
        MusicDto request)
    {
        await Task.CompletedTask;
        var getMusic = _musicRepository.GetMusic(request.Id);
        if (getMusic != null)
           getMusic.Adapt<MusicDto>();
        _musicRepository.updateMusic(getMusic);
        Console.WriteLine($"{getMusic.Id}");

        return new MusicResult(getMusic);
    }
}

