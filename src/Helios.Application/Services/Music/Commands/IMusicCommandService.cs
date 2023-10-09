using ErrorOr;
using Helios.Domain.Entities;

namespace Helios.Application.Services.Music.Commands;

public interface IMusicCommandService
{
    ErrorOr<UploadMusic> UploadMusic(
    string title,
    string additionalTags,
    int rate,
    string permalink,
    string description,
    string caption,
    byte[] content);
}