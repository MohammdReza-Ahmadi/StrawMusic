using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using StrawMusic.Application.Music.AddMusics;
using StrawMusic.Application.Music.DeleteMusics;
using StrawMusic.Application.Music.GetMusics;
using StrawMusic.Application.Music.UpdateMusics;
using StrawMusic.Application.ModelDto.AddMusics;

namespace StrawMusic.Api.Controllers;

[Route("[controller]/[action]")]
public class MusicsController : ApiController
{
    private readonly IMapper _mapper;
    private readonly IUploadMusic _uploadMusic;
    private readonly IDeleteMusic _deleteMusic;
    private readonly IGetMusicsService _getMusicsService;
    private readonly IUpdateMusics _updateMusics;

    public MusicsController(
        IMapper mapper,
        IUploadMusic uploadMusic = null,
        IDeleteMusic deleteMusic = null,
        IGetMusicsService getMusicsService = null,
        IUpdateMusics updateMusics = null)
    {
        _mapper = mapper;
        _uploadMusic = uploadMusic;
        _deleteMusic = deleteMusic;
        _getMusicsService = getMusicsService;
        _updateMusics = updateMusics;
    }


    [HttpGet]
    public IActionResult ListMusics()
    {
        return Ok(Array.Empty<string>());
    }

    [HttpPost]
    public async Task<IActionResult> UploadMusic(MusicDto request)
    {
        var uploadMusic = await _uploadMusic.AddMusic(request);
        return Ok(uploadMusic);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateMusic(MusicDto request)
    {
        var uploadMusic = await _updateMusics.UpdateMusic(request);
        return Ok(uploadMusic);
    }

    [HttpGet]
    public async Task<IActionResult> GetMusic(long id)
    {
        return Ok(await _getMusicsService.GetMusicById(id));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteMusic(long id)
    {
        return Ok(await _deleteMusic.DeleteMusicById(id));
    }
}