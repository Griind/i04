 var proxy = $.connection.algohub;

 $.connection.hub.start()
        .done(function ()
 {console.log("it worked");
  //var connectionID = $.connection.hub.id;
// console.log(connectionID);


             
});
      
      $.connection.algoHub.client.newtest = function (data) {
   
        $.connection.algoHub.server.rezz(data);
        console.log("Server Metdod run"+data);
        };

 $.connection.algoHub.client.testone = function (data,id) {
   
       console.log(id)
        console.log("Test One run");
           //AutoFollow(data);
        };


 $.connection.algoHub.client.newtest1 = function (data) {
    console.log("new 1Test run");
        AutoFollow1(data);
        };