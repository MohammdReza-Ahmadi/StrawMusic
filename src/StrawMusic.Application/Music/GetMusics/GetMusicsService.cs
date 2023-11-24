using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.GetMusics;
public class GetMusicsService: IGetMusicsService
{
    private readonly IMusicRepository _musicRepository;

    public GetMusicsService(IMusicRepository musicRepository)
    {
        _musicRepository = musicRepository;
    }

    public async Task<ErrorOr<MusicResult>> GetMusicById(long id)
    {
        await Task.CompletedTask;
        return new MusicResult(_musicRepository.GetMusic(id));
    }
}

