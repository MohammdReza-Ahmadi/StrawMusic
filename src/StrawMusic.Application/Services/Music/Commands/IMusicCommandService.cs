using ErrorOr;
using StrawMusic.Application.Services.Music.Commons;

namespace StrawMusic.Application.Services.Music.Commands;

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