using System;
using System.Threading;
using System.Timers;
using JVB.Example.ConsoleApp.Helpers;
using JVB.Example.ConsoleApp.Models;
using Timer = System.Timers.Timer;

namespace JVB.Example.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var greetingMsg = new WelcomeMessage();

            greetingMsg = RemoteApiHelper.GetHelloMessage();

            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("");

            Console.WriteLine(greetingMsg.HelloMessage);

            Console.ReadLine();
        }

    }
}
