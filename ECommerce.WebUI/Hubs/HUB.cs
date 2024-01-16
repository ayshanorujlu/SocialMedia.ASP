using Microsoft.AspNetCore.SignalR;

namespace ASPProject.WebUI.Hubs
{
    public class HUB : Hub
    {
        public async override Task OnConnectedAsync()
        {
            //var user = await _userManager.GetUserAsync(_contextAccessor.HttpContext.User);
            //var userItem = _context.Users.SingleOrDefault(x => x.Id == user.Id);
            //userItem.IsOnline = true;
            //await _context.SaveChangesAsync();

            //string info = user.UserName + " connected successfully";
            await Clients.Others.SendAsync("Connect", "Yes");
        }
    }
}
