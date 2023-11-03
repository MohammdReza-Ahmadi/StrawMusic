namespace Helios.Contracts.Music;

public record UploadMusicRequest(
string Title,
int Rate,
string AdditionalTags,
string Permalink,
string Description,
string Caption,
byte[] Content);