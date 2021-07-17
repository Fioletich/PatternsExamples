using Visitor.Visitors;

namespace Visitor.ObjectStructs
{
    public class Triangle : IFigure<double>
    {
        public double HSide { get; set;}
        public double BSide { get; set; }

        public double AcceptVisitor(IFigureVisitor<double> visitor)
        {
            return visitor.VisitTriangle(this);
        }

        public void Draw()
        {
            System.Console.WriteLine("Draw triangle.");
        }
    }
}
