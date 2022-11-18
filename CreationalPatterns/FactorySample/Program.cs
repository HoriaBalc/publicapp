using FactorySample;

ISportActivity run = new FactoryActivity().CreateActivity(1, 3600, 4263);

Console.WriteLine($"Running Average speed: {run.AverageSpeed()} m/s Estemated calories: {run.CalculateCalories()}");

ISportActivity walk = new FactoryActivity().CreateActivity(2, 2384, 1738);
Console.WriteLine($"Walking Average speed: {walk.AverageSpeed()} m/s Estemated calories: {walk.CalculateCalories()}");

ISportActivity cycle = new FactoryActivity().CreateActivity(3, 2849, 12304);
Console.WriteLine($"Cycling Average speed: {cycle.AverageSpeed()} m/s Estemated calories: {cycle.CalculateCalories()}");
