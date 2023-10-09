namespace Helios.Domain.Entities;

public class UploadMusic
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Title { get; set; } = null!;
    public string AdditionalTags { get; set; } = null!;
    public int Rate { get; set; }
    public string Permalink { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Caption { get; set; } = null!;
    public byte[] Content { get; set; } = null!;
}