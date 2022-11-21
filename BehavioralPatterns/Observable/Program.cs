using ObserverPattern;

var publisher = new User<Activity>("Alex");//publisher

//subscribers
var andrei = new User<Activity>("Andrei");
var marcel = new User<Activity>("Marcel");
var radu = new User<Activity>("Radu");



//subscribing ...
publisher.AddSubscriber(andrei);
publisher.AddSubscriber(marcel);
publisher.AddSubscriber(radu);


//action
publisher.Publish(new Activity("Running", 2132, 3123, DateTime.Now));
