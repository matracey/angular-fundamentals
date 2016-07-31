using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

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
            return GetAllArray();
        }

        private JToken GetAllArray()
        {
            string content = "";
            
            foreach (var file in System.IO.Directory.GetFiles(_env.WebRootPath + "/data/event/")) 
                content += System.IO.File.ReadAllText(file) + ",";

            return JArray.Parse("[" + content.Substring(0, content.Length - 1) + "]");
        }

        private JToken GetAllObject()
        {
            JObject val = new JObject();

            foreach (string file in System.IO.Directory.GetFiles(_env.WebRootPath + "/data/event/"))
            {
                var data = JObject.Parse(System.IO.File.ReadAllText(file));
                val.Add(data["id"].ToString(), data);
            }

            return new JObject(val);
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
