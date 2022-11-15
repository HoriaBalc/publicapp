using static System.Console;
using Linq;
using System.Linq;

WriteLine("Hello, World!");

var activity1 = new Activity();
Extensions.SetActivity(activity1, DateTime.Now, new TimeSpan(0, 10, 0), (decimal)1.6, 22, 11, 45, true );
var detailActivity1 = new DetailActivity();
Extensions.SetDetailActivity(detailActivity1, new TimeSpan(0, 8, 22), (decimal)0.5, 12, 15, 25);
Extensions.AddDetail(activity1 , detailActivity1);
var detailActivity2 = new DetailActivity();
Extensions.SetDetailActivity(detailActivity2, new TimeSpan(0, 18, 45), (decimal)1.5, 24, 21, 67);
Extensions.AddDetail(activity1, detailActivity2);

var orderedByCalories = activity1.Details.OrderByDescending(x => x.Calories);
foreach (DetailActivity detail in orderedByCalories) {
    WriteLine(detail.Calories + " " + detail.Distance + " " + detail.Duration);
}

int n = activity1.Details.Count;
int sum = (int)activity1.Details.Select(x => x.Calories).Sum();

WriteLine(sum);


