using Visitor.ObjectStructs;

namespace Visitor.Visitors
{
    public interface IFigureVisitor<T>
    {
        T VisitRectangle(Rectangle rectangle);
        T VisitTriangle(Triangle triangle);
    }
}
