using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Threading.Tasks;

namespace ServiceCore
{
    class Program
    {
        static void Main(string[] args)
        {

            var _Con = new HubConnectionBuilder().WithUrl($"https://localhost:44345/hub/BroadcastHub")
                 .WithAutomaticReconnect(new[] { TimeSpan.Zero, TimeSpan.Zero, TimeSpan.FromSeconds(10) })
                 .Build();

            //_Con.Closed += async (error) =>
            //{
            //    await Task.Delay(new Random().Next(0, 5) * 1000);
            //    await _Con.StartAsync();
            //};

            _Con.On("showmessage", (string name, string message) =>
            {
                Console.WriteLine($"{name}, {message}\r\n");
                _Con.InvokeAsync("TaskResult", "I Get");
            });
            _Con.StartAsync().Wait();
            Console.Read();

        }

    }
}
