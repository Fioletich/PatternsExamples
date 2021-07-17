using Observer.Observers;
using System.Collections.Generic;

namespace Observer.Observables
{
    public class Teacher : IObservable<string>
    {
        private readonly IList<IObserver<string>> _observers;

        public Teacher()
        {
            _observers = new List<IObserver<string>>();
        }

        public void Add(IObserver<string> observer)
        {
            _observers.Add(observer);
        }

        public void Notify(string item)
        {
            foreach (var observer in _observers)
            {
                observer.Update(item);
            }
        }

        public void Remove(IObserver<string> observer)
        {
            _ = _observers.Remove(observer);
        }
    }
}
