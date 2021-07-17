using Visitor.Visitors;

namespace Visitor.ObjectStructs
{
    public class Rectangle : IFigure<double>
    {
        public double ASide { get; set; }
        public double BSide { get; set; }

        public double AcceptVisitor(IFigureVisitor<double> visitor)
        {
            return visitor.VisitRectangle(this);
        }

        public void Draw()
        {
            System.Console.WriteLine("Draw rectangle.");
        }
    }
}
