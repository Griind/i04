 $.connection.hub.start()
        .done(function () {console.log("it worked")});

      $.connection.algoHub.client.newtest = function (data) {
    console.log("new Test run");
        AutoFollow(data);
        };