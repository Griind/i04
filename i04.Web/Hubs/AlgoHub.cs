using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using i04.Web.Controllers;
using i04.Web.Models.Home;

namespace i04.Web.Hubs
{
    public class AlgoHub : Hub

    {
        //public  int[] NewTest()
        //{
        //    var ret = ChartsDataViewModel.GetList();
           
        //    return ret.Numbers[1];
        //}
        public string GetId() => Context.ConnectionId;

        private static IHubConnectionContext<dynamic> GetClients(AlgoHub chatHub)
        {    
                return GlobalHost.ConnectionManager.GetHubContext<AlgoHub>().Clients;
        }

        // Call from JavaScript
        public void Send(int[] m)
        {
            Send(m, this);
        }

        // Call from C# eg: Hubs.ChatHub.Send(message, null);
        public static void Send(int[] message, AlgoHub chatHub)
        {
            IHubConnectionContext<dynamic> clients = GetClients(chatHub);
            // common logic goes here 
            clients.All.autoFollow(message);
        }
    }

}