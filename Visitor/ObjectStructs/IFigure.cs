using Visitor.Visitors;

namespace Visitor.ObjectStructs
{
    public interface IFigure<T>
    {
        T AcceptVisitor(IFigureVisitor<T> visitor);
        void Draw();
    }
}
