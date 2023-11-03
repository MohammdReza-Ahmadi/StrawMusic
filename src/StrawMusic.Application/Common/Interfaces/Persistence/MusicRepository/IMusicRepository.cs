using Helios.Domain.Entities;

namespace Helios.Application.Common.Interfaces.Persistence.MusicRepository;

public interface IMusicRepository
{
    void AddMusic(Domain.Entities.Music uploadMusic);
}