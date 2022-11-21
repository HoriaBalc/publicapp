using System.Collections.Generic;

namespace ObserverPattern
{
    public class User<T> : IFriend<Activity>
    {
        private List<IFriend<T>> friends;

        public string Name { get; }

       
        public User(string name)
        {
            this.friends = new List<IFriend<T>>();
            Name = name;

        }
        public void AddSubscriber(IFriend<T> friend)
        {
            this.friends.Add(friend);
        }
        public void Publish(T item)
        {
            this.friends.ForEach(s => s.Notify(item, Name));
        } 
        public void Notify(Activity activity, string name)
        {
            Console.WriteLine($@"User {Name} notified about a new activity from {name} who practiced {activity.Name} for {activity.Duration} seconds and did  {activity.Distance} meters.");
        }
    }
}
