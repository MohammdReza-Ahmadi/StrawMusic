using ErrorOr;
using Helios.Application.Services.Music.Commons;

namespace Helios.Application.Services.Music.Commands;

public interface IMusicCommandService
{
    ErrorOr<MusicResult> UploadMusic(
    string title,
    string additionalTags,
    int rate,
    string permalink,
    string description,
    string caption,
    byte[] content);
}