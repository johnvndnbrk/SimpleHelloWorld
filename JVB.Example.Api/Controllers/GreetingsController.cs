using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JVB.Example.Api.Managers;
using JVB.Example.Api.Models;

namespace JVB.Example.Api.Controllers
{
    [RoutePrefix("api/welcomemessage")]
    public sealed class GreetingsController : ApiController
    {
        [HttpGet]
        [AllowAnonymous]
        [Route("getgreeting")]
        public WelcomeMessage GetGreetingData()
        {
            var response = new GreetingServiceManager();

            return response.GetHelloMessage();

        }
    }
}
