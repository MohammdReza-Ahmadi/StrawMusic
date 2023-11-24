using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Domain.Entities;

namespace StrawMusic.Infrastructure.Persistence;
public class MusicRepository : IMusicRepository
{
    private static readonly List<MusicEntity> _uploadMusic = new ();
    public void AddMusic(MusicEntity uploadMusic)
    {
        _uploadMusic.Add(uploadMusic);
    }
    public void updateMusic(MusicEntity uploadMusic)
    {
        _uploadMusic.Add(uploadMusic);
    }
    public MusicEntity? GetMusic(long? id)
    {
       return _uploadMusic.SingleOrDefault(x => x.Id == id);
    }

    public bool DeleteMusic(long id)
    {
       var upload = _uploadMusic.SingleOrDefault(x => x.Id == id);
        if(upload == null)
            return false;
        _uploadMusic.Remove(upload);
        return true;
    }
}