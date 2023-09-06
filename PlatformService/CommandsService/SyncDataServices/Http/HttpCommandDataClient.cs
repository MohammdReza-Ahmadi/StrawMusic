using PlatformService.Dtos;
using System.Text;
using System.Text.Json;

namespace CommandsService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpclient;

        public HttpCommandDataClient(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task SendPlatformToCommand(PlatformReadDto dto)
        {
            var httpContent = new StringContent(JsonSerializer.Serialize(dto),Encoding.UTF8,"application/json");
            var response = await _httpclient.PostAsync("http://localhost:6000/api/c/platforms",httpContent);
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("test----->tststs");
            }
            else
            {
                Console.WriteLine("test----->tststs2");
                Console.WriteLine("test----->tststs2");
            }
       }
    }
}
