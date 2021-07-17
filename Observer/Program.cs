using Observer.Observables;
using Observer.Observers;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var teacher = new Teacher();
            var student = new Student();

            teacher.Add(student);

            teacher.Notify("1 + 1 = 2");

            System.Console.WriteLine(student.WorkBook);
        }
    }
}
