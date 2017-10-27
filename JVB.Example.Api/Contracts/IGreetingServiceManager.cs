using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JVB.Example.Api.Models;

namespace JVB.Example.Api.Contracts
{
    public interface IGreetingServiceManager
    {
        WelcomeMessage GetHelloMessage();
    }
}
