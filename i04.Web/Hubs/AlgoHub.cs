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
        public int[] NewTest()
        {
            return ChartsDataViewModel.GetList().Numbers[1];
        }

        public string GetId() => Context.ConnectionId;

        private static IHubConnectionContext<dynamic> GetClients(AlgoHub nub)
        {
            if (nub == null)
                return GlobalHost.ConnectionManager.GetHubContext<AlgoHub>().Clients;
            else
                return nub.Clients;
        }

        public static void UpdateChart2(int[] numbers, AlgoHub hub, string connId)
        {
            IHubConnectionContext<dynamic> clients = GetClients(hub);

            clients.Client(connId).UpdateChart2(numbers);
        }
        
        public static void UpdateChart1(int[] numbers, AlgoHub hub, string connId)
        {
            IHubConnectionContext<dynamic> clients = GetClients(hub);

            clients.Client(connId).UpdateChart1(numbers);
        }
    }

}