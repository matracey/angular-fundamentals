using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApp.Controllers
{
    [Route("data/[controller]")]
    public class EventController : Controller
    {
        private IHostingEnvironment _env;

        public EventController(IHostingEnvironment env)
        {
            _env = env;
        }

        public JToken Get()
        {
            return Get(1);
        }

        [HttpGet("{id}")]
        public JToken Get(int id)
        {
            return JObject.Parse(System.IO.File.ReadAllText(_env.WebRootPath + "/data/event/" + id.ToString() + ".json"));
        }

        [HttpPost("{id}")]
        public void Post(string id, [FromBody]JObject eventData)
        {
            System.IO.File.WriteAllText(_env.WebRootPath + "/data/event/" + id.ToString() + ".json", eventData.ToString(Newtonsoft.Json.Formatting.None));
        }
    }
}
