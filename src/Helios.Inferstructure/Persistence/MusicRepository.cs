using Helios.Application.Common.Interfaces.Persistence;
using Helios.Domain.Entities;

namespace Helios.Infrastructure.Persistence;
public class MusicRepository : IMusicRepository
{
    private static readonly List<UploadMusic> _uploadMusic = new ();
    public void AddMusic(UploadMusic uploadMusic)
    {
        _uploadMusic.Add(uploadMusic);
    }
}