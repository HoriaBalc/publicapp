// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Exceptions;
using System;
using System.Text.RegularExpressions;

class RunApp{
    static public void Main() { 
        Console.WriteLine("Hello, World!");
        try 
        {
            User user = new User("Horia","Balc","balc_horia@yahoo.com","parola",new  Role("user"));
            if(user==null)
                throw new UserException("null user");
            Console.WriteLine(user.FirstName + " " + user.LastName + " " + user.Email + " " + user.Role.Name);
            TimeSpan time = new TimeSpan(0, 10, 0);
            Activity activity = new Activity(time, DateTime.Now, (decimal)1.74, new Sport("running"),user);
            if (activity == null)
                throw new ActivityException("null activity");
            activity.addDetails();
            foreach (DetailActivity detail in activity.Details)
            {
                Console.WriteLine(detail.Duration + " " + detail.Distance);
            }
            activity.Distance = (decimal)2.7;
            activity.Duration = DateTime.Now-DateTime.UtcNow;
            activity.addDetails();
            foreach (DetailActivity detail in activity.Details)
            {
                Console.WriteLine(detail.Duration + " " + detail.Distance);
            }
        }
        catch (UserException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        
        
    }

    public static string FormatPhoneNumber(string phone)
    {
        Regex regex = new Regex(@"[^\d]");
        phone = regex.Replace(phone, "");
        phone = Regex.Replace(phone, @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
        return phone;
    }

}