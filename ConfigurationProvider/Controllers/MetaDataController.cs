using ConfigurationProvider.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Runtime;

namespace ConfigurationProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetaDataController : ControllerBase
    {
        private readonly IOptions<SecurityMetaData> _settings;
        public MetaDataController(IOptions<SecurityMetaData> settings)
        {
            _settings = settings;

        }

        [HttpGet]
        public IActionResult Get()
        {
            var accessKeys = new SecurityMetaData
            {
                SecretKey = _settings.Value.SecretKey,
                PublicKey = _settings.Value.PublicKey,
                IsLocked = _settings.Value.IsLocked,
                IsEnabled = _settings.Value.IsEnabled,

            };
            Console.WriteLine("Here is the key =>", accessKeys);
            return Ok(accessKeys);
        }
    }
}

