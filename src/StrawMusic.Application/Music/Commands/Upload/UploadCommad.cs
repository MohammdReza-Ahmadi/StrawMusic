using ErrorOr;
using StrawMusic.Application.Services.Music.Commons;
using MediatR;

namespace StrawMusic.Application.Music;

public record UploadCommand(
     string Title,
     string AdditionalTags,
     int Rate,
     string Permalink,
     string Description,
     string Caption,
     byte[] Content):IRequest<ErrorOr<MusicResult>>;

