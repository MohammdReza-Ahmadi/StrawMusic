using Helios.Application.Common.Interfaces.Services;

namespace Helios.Infrastructure.Services;
public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
