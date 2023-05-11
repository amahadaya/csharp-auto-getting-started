using Microsoft.AspNetCore.Mvc;
using freeclimb.Api;
using freeclimb.Model;
using freeclimb.Enums;
using System;
using System.Collections.Generic;


namespace GettingStarted.Controllers
{
    [Route("/voice")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // POST voice/
        [HttpPost]
        public string Post(CallStatus request)
        {
            System.Console.WriteLine("Request Value: " + request);
            // Create a PerCl script
            PerclScript helloScript = new PerclScript(new List<PerclCommand>());

            // Create a Say Command
            Say sayHello = new Say("hello, freeclimb!");
            Console.WriteLine(sayHello.ToJson());
            // Add the command
            helloScript.Commands.Add(sayHello);

            Console.WriteLine(helloScript.ToJson());

            // Respond to FreeClimb with your script
            return helloScript.ToJson();
        }
    }
}
