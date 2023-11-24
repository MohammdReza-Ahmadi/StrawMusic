using ErrorOr;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.DeleteMusics;
public class DeleteMusic: IDeleteMusic
{

        private readonly IMusicRepository _musicRepository;
        public DeleteMusic(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public async Task<ErrorOr<MusicResult>> DeleteMusicById(long id)
        {
            await Task.CompletedTask;
            _musicRepository.DeleteMusic(id);
            return new MusicResult(_musicRepository.GetMusic(id));
        }
    }

