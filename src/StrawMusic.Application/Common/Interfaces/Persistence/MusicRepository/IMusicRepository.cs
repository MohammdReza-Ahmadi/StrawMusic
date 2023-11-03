using StrawMusic.Domain.Entities;

namespace StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;

public interface IMusicRepository
{
    void AddMusic(MusicEntity uploadMusic);
    MusicEntity? GetMusic(Guid? id);
}