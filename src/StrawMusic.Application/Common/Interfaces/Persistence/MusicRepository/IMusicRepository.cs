using StrawMusic.Domain.Entities;

namespace StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;

public interface IMusicRepository
{
    void AddMusic(MusicEntity uploadMusic);
    void updateMusic(MusicEntity uploadMusic);
    MusicEntity? GetMusic(long? id);
    public bool DeleteMusic(long id);
}