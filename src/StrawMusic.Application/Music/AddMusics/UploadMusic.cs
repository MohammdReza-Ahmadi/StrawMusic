using ErrorOr;
using StrawMusic.Domain.Entities;
using StrawMusic.Application.ModelDto.AddMusics;
using StrawMusic.Application.Common.Interfaces.Persistence.MusicRepository;
using StrawMusic.Application.Services;

namespace StrawMusic.Application.Music.AddMusics;

public class UploadMusic: IUploadMusic
{
    private readonly IMusicRepository _musicRepository;
    public UploadMusic(IMusicRepository musicRepository)
    {
        _musicRepository = musicRepository;
    }
    public async Task<ErrorOr<MusicResult>> AddMusic(
        MusicDto request)
    {
        await Task.CompletedTask;
        var music = new MusicEntity
        {
            Id = request.Id,
            Title = request.Title,
            Permalink = request.Permalink,
            AdditionalTags = request.AdditionalTags,
            Caption = request.Caption,
            Content = request.Content,
            Description = request.Description,
            Rate = request.Rate
        };
        _musicRepository.AddMusic(music);
        Console.WriteLine($"{music.Id}");

        return new MusicResult(music);
    }
}