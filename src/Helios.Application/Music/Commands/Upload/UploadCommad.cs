namespace Helios.Application.Music;

public record UploadCommand(string Title,
 string AdditionalTags,
  int Rate,
   string Permalink,
    string Description,
     string Caption,
byte[] Content);

