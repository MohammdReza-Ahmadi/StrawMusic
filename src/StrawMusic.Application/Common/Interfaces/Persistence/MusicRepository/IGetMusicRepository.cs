using StrawMusic.Domain.Entities;

namespace StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository
{
    public interface IGetMusicRepository
    {
        MusicEntity GetMusic(string id);
    }
}
