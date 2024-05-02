using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI2.Controllers
{
    [Route("/internal-api/[controller]")]
    [ApiController]
    public class Service2Controller : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Bonjour, je suis le service 2";
        }
    }
}
