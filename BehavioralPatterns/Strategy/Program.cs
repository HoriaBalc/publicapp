// See https://aka.ms/new-console-template for more information
using FactorySample;
using Strategy;

Console.WriteLine("The duration of the activity in seconds: ");
var duration = int.Parse(Console.ReadLine());
Console.WriteLine("The distance of the activity in meters: ");
var distance = int.Parse(Console.ReadLine());

Console.WriteLine("Please select route preference! 1 -> Cycling; 2 -> Running; 3 -> Walking");
var selection = int.Parse(Console.ReadLine());
SportActivity sportActivity = new SportActivity(duration, distance); 
var context = new CalculateCaloriesContext();

if (selection == 1)
{
    context.SetStrategy(new CyclingCalculateCalories());
    Console.WriteLine(context.CalculateCalories(sportActivity.Duration, sportActivity.Distance));
}

if (selection == 2)
{
    context.SetStrategy(new RunningCalculateCalories());
    Console.WriteLine(context.CalculateCalories(sportActivity.Duration, sportActivity.Distance));
}

if (selection == 3)
{
    context.SetStrategy(new WalkingCalculateCalories());
    Console.WriteLine(context.CalculateCalories(sportActivity.Duration, sportActivity.Distance));
}

if (selection > 3 || selection < 1)
{
    context.SetStrategy(new CyclingCalculateCalories());
    Console.WriteLine(context.CalculateCalories(sportActivity.Duration, sportActivity.Distance));
}
