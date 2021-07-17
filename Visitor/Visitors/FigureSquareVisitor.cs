using Visitor.ObjectStructs;

namespace Visitor.Visitors
{
    public class FigureSquareVisitor : IFigureVisitor<double>
    {
        public double VisitRectangle(Rectangle rectangle)
        {
            return (rectangle.ASide * rectangle.BSide);
        }

        public double VisitTriangle(Triangle triangle)
        {
            return ((triangle.BSide * triangle.HSide) / 2);
        }
    }
}
