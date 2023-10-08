using Microsoft.AspNetCore.Authorization;
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
    public IActionResult UploadMusics(){
        return Ok();
    }
}