using Helios.Domain.Entities;

namespace Helios.Application.Common.Interfaces.Persistence;

public interface IMusicRepository
{
    void AddMusic(UploadMusic uploadMusic);
}