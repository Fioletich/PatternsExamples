namespace Observer.Observers
{
    public interface IObserver<T>
    {
        void Update(T item);
    }
}
