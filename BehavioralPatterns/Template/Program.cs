using Template;

Console.WriteLine("The duration of the activity in seconds: ");
var duration = int.Parse(Console.ReadLine());
Console.WriteLine("The distance of the activity in meters: ");
var distance = int.Parse(Console.ReadLine());
var run = new Running( duration, distance);
run.ActivityAnalize();


Console.WriteLine("The duration of the activity in seconds: ");
var duration1 = int.Parse(Console.ReadLine());
Console.WriteLine("The distance of the activity in meters: ");
var distance1 = int.Parse(Console.ReadLine());
var walk = new Walking(duration1, distance1);
walk.ActivityAnalize();
