using Microsoft.AspNetCore.SignalR;

namespace SignalRCollaboration
{
    public class DrawingHub : Hub
    {
        public async Task SendDrawData(object data)
        {
            await Clients.Others.SendAsync("ReceiveDrawData", data);
        }

        public async Task ClearCanvas()
        {
            await Clients.Others.SendAsync("ReceiveClearCanvas");
        }
    }
}
