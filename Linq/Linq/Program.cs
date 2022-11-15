using static System.Console;
using Linq;
using System.Linq;

WriteLine("Hello, World!");

var activity1 = new Activity();
activity1.SetActivity( Extensions.DateSample(), Extensions.TimeSample(0, 10, 0), (decimal)1.6, 22, 11, 45, true );
var detailActivity1 = new DetailActivity();
detailActivity1.SetDetailActivity(Extensions.TimeSample(0, 8, 22), (decimal)0.5, 12, 15, 25);
activity1.AddDetail(detailActivity1);
var detailActivity2 = new DetailActivity();
detailActivity2.SetDetailActivity(Extensions.TimeSample(0, 18, 45), (decimal)1.5, 24, 21, 67);
activity1.AddDetail( detailActivity2);

var orderedByCalories = activity1.Details.OrderByDescending(x => x.Calories);
foreach (DetailActivity detail in orderedByCalories) {
    WriteLine(detail.Calories + " " + detail.Distance + " " + detail.Duration);
}

int n = activity1.Details.Count;
int sum = (int)activity1.Details.Select(x => x.Calories).Sum();

WriteLine(sum);


