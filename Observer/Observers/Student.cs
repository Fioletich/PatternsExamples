using System.Text;

namespace Observer.Observers
{
    public class Student : IObserver<string>
    {
        private StringBuilder _workBook = new();

        public string WorkBook => _workBook.ToString();

        public void Update(string item)
        {
            _workBook.Append(item);
        }
    }
}
