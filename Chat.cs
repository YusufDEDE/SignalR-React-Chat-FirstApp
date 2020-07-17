using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;


namespace SignalR_React_Chat_FirstApp
{
    public class Chat : Hub
    {      
        public async Task Send(string nick, string message)
        {
            await Clients.All.SendAsync("Send", nick, message);
        }
    }
}