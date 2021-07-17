using Observer.Observers;

namespace Observer.Observables
{
    public interface IObservable<T>
    {
        void Add(IObserver<T> observer);
        void Remove(IObserver<T> observer);
        void Notify(T item);
    }
}
