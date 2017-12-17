using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using i04.Web.Controllers;
using i04.Web.Models.Home;
using i04.Web.Helpers;

namespace i04.Web.Hubs
{
    public class AlgoHub : Hub

    {

        public string GetId() => Encode.Base64Encode(Context.ConnectionId);

        private static IHubConnectionContext<dynamic> GetClients(AlgoHub nub)
        {
            if (nub == null)
                return GlobalHost.ConnectionManager.GetHubContext<AlgoHub>().Clients;
            else
                return nub.Clients;
        }

        public static void Send(int[] numbers, AlgoHub hub, string connId)
        {
            IHubConnectionContext<dynamic> clients = GetClients(hub);

            clients.Client(connId).UpdateChart2(numbers);
        }

        public static void SendUnsorted(int[] numbers, AlgoHub hub, string connId)
        {
            IHubConnectionContext<dynamic> clients = GetClients(hub);

            clients.Client(connId).UpdateChart1(numbers);
        }
    }

}