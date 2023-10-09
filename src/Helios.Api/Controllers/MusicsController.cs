using Helios.Contracts.Music;
using Microsoft.AspNetCore.Mvc;

namespace Helios.Api.Controllers;

[Route("[controller]")]
public class MusicsController : ApiController
{
    [HttpGet]
    public IActionResult ListMusics()
    {
        return Ok(Array.Empty<string>());
    }

    [HttpPost]
    public IActionResult UploadMusic(UploadMusicRequest request)
    {
        return Ok(request);
    }
}