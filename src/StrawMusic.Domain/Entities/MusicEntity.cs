namespace StrawMusic.Domain.Entities;

public class MusicEntity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string AdditionalTags { get; set; } = null!;
    public int Rate { get; set; }
    public string Permalink { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Caption { get; set; } = null!;
    public byte[] Content { get; set; } = null!;
}