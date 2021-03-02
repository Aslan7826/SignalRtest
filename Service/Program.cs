using Microsoft.AspNet.SignalR.Client;
using System;

namespace Service
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            HubConnection hubConnection = new HubConnection(@"http://localhost:19874/");
            // 建立 Hub Proxy
            IHubProxy broadcastHubProxy = hubConnection.CreateHubProxy("BroadcastHub");

            // 註冊給伺服端呼叫的方法
            broadcastHubProxy.On("ShowMessage", (string name, string message) =>
            {
                Console.WriteLine($"{name}, {message}\r\n");
            });

            // 連線到 SignalR 伺服器
            hubConnection.Start().Wait();
            Console.Read();
        }
    }
}