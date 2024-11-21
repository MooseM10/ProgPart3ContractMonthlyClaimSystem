using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ContractMonthlyClaimSystem.Hubs
{
    public class ClaimHub : Hub
    {
        public async Task NotifyStatusChange()
        {
            await Clients.All.SendAsync("ReceiveStatusUpdate");
        }
    }
}
