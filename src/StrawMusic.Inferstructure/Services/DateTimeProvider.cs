using StrawMusic.Application.Common.Interfaces.Services;

namespace StrawMusic.Infrastructure.Services;
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
