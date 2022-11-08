// See https://aka.ms/new-console-template for more information

//string xmlText="<app><app><app></app></app>";
//string xmlText = "<app></app></app><app><app>";
string xmlText = "</app><app><app></app></app>";
int mistakes = 0;
int open = 0;
int close = 0;
string[] tags=xmlText.Split('<');

foreach (string tag in tags) {
    if (string.Compare(tag, "app>") == 0) {
        open++;
    }
    if (string.Compare(tag, "/app>") == 0)
    {
        if (open <= close) {
            mistakes++;
        }
        else {  close++;}
       
    }
}

if (open > close) {
    mistakes += open - close;
}

Console.WriteLine(mistakes);

TimeSpan timeSpan = new TimeSpan(0,0,0);
DateTime date = DateTime.Now;
DateTime date1 = DateTime.UtcNow;
Console.WriteLine("Romania time: " + date + " vs Great Britan time:" + date1);
Console.WriteLine(timeSpan);
DateTimeOffset dateOffset = new DateTimeOffset(date1, timeSpan);
Console.WriteLine(dateOffset);


