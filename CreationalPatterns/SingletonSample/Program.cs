using SingletonSample;

var steps = new List<int>() { 2312, 4432, 1332, 521, 134 };
var instances = new List<StepsCounter>();
var options = new ParallelOptions { MaxDegreeOfParallelism = 5 };
//foreach (var step in steps)
//    Parallel.Invoke(
//                   () => { StepsCounter.Instance.PrintSteps(step); }
//                   );
    Parallel.ForEach(steps, options, instance =>
    {
        instances.Add(StepsCounter.Instance);
        ;
    });
int count = 0;
foreach (var instance in instances) 
{
    instance.PrintSteps(steps[count]);
    count++;
}
