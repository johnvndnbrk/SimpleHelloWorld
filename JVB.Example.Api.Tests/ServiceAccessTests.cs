using Microsoft.VisualStudio.TestTools.UnitTesting;
using JVB.Example.Api.Contracts;
using JVB.Example.Api.Controllers;
using JVB.Example.Api.Models;
using Moq;

namespace JVB.Example.Api.Tests
{
    [TestClass]
    public class ServiceAccessTests
    {

        [TestMethod]
        public void GetHelloGreetingMessage()
        {
            Mock<IGreetingServiceManager> mockGreetingService = new Mock<IGreetingServiceManager>();

            WelcomeMessage helloMessage = new WelcomeMessage()
            {
                HelloMessage = "Hello World"
            };

            mockGreetingService.Setup(obj => obj.GetHelloMessage()).Returns(helloMessage);

            GreetingsController controller = new GreetingsController();

            WelcomeMessage response = controller.GetGreetingData();

            Assert.IsTrue(response.HelloMessage == helloMessage.HelloMessage);
        }

    }
}
