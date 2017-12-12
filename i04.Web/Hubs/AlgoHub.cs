using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using i04.Web.Controllers;
using System.Threading.Tasks;

namespace i04.Web.Hubs
{

  
    public class AlgoHub : Hub

    {
        public void Rezz(int []data) {

            var z = data;
            var id = Context.ConnectionId;
            Clients.Client(id).testone(data,id);
        }

        

        public static void SendMessage(List<int> number)

        {
            
            var data = number.ToArray();
            //var hubContext = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            IHubContext das = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            

            das.Clients.All.NewTest(data);
                      
            
            //var hubContext1 = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            //hubContext.Clients.All.NewTest1(Data);
            //hubContext.Clients.All.NewTest();




        }

        public static void SendMessage1(List<int> number)

        {
            var data1 = number.ToArray();
            //var hubContext = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            context.Clients.All.NewTest1(data1);
            
            //var hubContext1 = GlobalHost.ConnectionManager.GetHubContext<AlgoHub>();
            //hubContext.Clients.All.NewTest1(Data);
            //hubContext.Clients.All.NewTest();




        }






        //public void BubleSort( List<int> number)
        //{
        //    var i = number.ToArray();

        //    Clients.Caller.NewTest(i);


        //}
        public void BubleSort()
        {

            Clients.All.newTest();
            
        }

    }

}