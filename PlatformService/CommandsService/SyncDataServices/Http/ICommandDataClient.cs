using PlatformService.Dtos;

namespace CommandsService.SyncDataServices
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto dto);
    }
}
