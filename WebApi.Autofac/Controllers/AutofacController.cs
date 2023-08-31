using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Autofac.Services;

namespace WebApi.Autofac.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutofacController : ControllerBase
    {

        public readonly ISample _sample;
        public AutofacController(ISample sample) { _sample = sample; }

        [Route("[Action]")]
        [HttpGet]
        public IActionResult GetAll()
        {
            _sample.Add();
            return Ok();
        }
    }
}
