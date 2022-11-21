namespace ObserverPattern
{
    public interface IFriend<T>
    {
        void Notify(T item, string name);
    }
}
