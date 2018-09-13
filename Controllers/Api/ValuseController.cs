using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebCore21TestApp2.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController: ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ValuesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var client = _httpClientFactory.CreateClient();
            var result = await client.GetStringAsync("http://www.google.com");
            return Ok(result);
        }
    }
}
