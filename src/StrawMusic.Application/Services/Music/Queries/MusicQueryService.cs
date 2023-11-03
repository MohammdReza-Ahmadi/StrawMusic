using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Services.Music.Commons;
using StrawMusic.Domain.Entities;

namespace StrawMusic.Application.Services.Music.Queries;
public class MusicQueryService : IMusicQueryService
{
    private readonly IMusicRepository _musicService;
    public MusicQueryService(IMusicRepository musicRepository)
    {
        _musicService = musicRepository;
    }
    public ErrorOr<MusicResult> GetMusicById(Guid id)
    {

        if(_musicService.GetMusic(id) is not MusicEntity musicEntity)
        {
            return new ErrorOr<MusicResult>();
        }
        return new MusicResult(musicEntity);
    }
}

