using Microsoft.AspNetCore.Mvc;
using freeclimb.Api;
using freeclimb.Model;



namespace GettingStarted.Controllers
{
    [Route("voice/")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // POST voice/
        [HttpPost]
        public string Post(CallResult request)
        {
          // Create a PerCl script
          PerclScript helloScript = new PerclScript();

          // Create a Say Command
          Say sayHello = new Say();
          sayHello.Text = "Hello, FreeClimb!";

          // Add the command
          helloScript.Commands.Add(sayHello);

          // Respond to FreeClimb with your script
          return helloScript.ToJson();
        }
    }
}
