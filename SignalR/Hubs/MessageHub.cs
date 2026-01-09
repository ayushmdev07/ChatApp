using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
                await Clients.All.SendAsync("ReceiveMessage",user, message);
        }
        public async Task Join(string user)
        {
            await Clients.All.SendAsync("UserJoined", user);
        }
        public async Task Leave(string user)
        {
            await Clients.All.SendAsync("UserLeft", user);
        }
        public async Task Typing(string user)
        {
            await Clients.Others.SendAsync("ShowTyping", user);
        }

        public async Task StopTyping(string user)
        {
            await Clients.Others.SendAsync("HideTyping", user);
        }
    }
}
