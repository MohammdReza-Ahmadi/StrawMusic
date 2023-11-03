using Helios.Application.Common.Interfaces.Persistence.MusicRepository;
using Helios.Domain.Entities;

namespace Helios.Infrastructure.Persistence;
public class MusicRepository : IMusicRepository
{
    private static readonly List<Music> _uploadMusic = new ();
    public void AddMusic(Music uploadMusic)
    {
        _uploadMusic.Add(uploadMusic);
    }
}