using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JVB.Example.Api.Contracts;
using JVB.Example.Api.Models;

namespace JVB.Example.Api.Managers
{

    public class GreetingServiceManager : IGreetingServiceManager
    {
        public WelcomeMessage GetHelloMessage()
        {
            return new WelcomeMessage();
        }
    }
}