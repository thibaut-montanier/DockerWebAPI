using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Service1Controller : ControllerBase
    {
        private readonly HttpClient _HttpClient;
        private readonly IOptions<ApiUrls> _Urls;
        private readonly ILogger<Service1Controller> _Logger;

        public Service1Controller(HttpClient httpClient, IOptions<ApiUrls> urls, ILogger<Service1Controller> logger)
        {
            this._HttpClient = httpClient;
            this._Urls = urls;
            this._Logger = logger;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            _Logger.LogInformation("Service1Controller-Get-start");
            var result = await _HttpClient.GetAsync($"{_Urls.Value.UrlWebApi2}service2");
            var weather = await result.Content.ReadAsStringAsync();

            return weather ?? string.Empty;
                
        }
    }
}
