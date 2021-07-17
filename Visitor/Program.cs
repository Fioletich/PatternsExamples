using System;
using Visitor.ObjectStructs;
using Visitor.Visitors;

namespace Visitor
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            IFigure<double> triangle = new Triangle { BSide = 1, HSide = 2 };
            IFigure<double> rectangle = new Rectangle { BSide = 1, ASide = 2 };

            IFigureVisitor<double> figureVisitor = new FigureSquareVisitor();

            Console.WriteLine(triangle.AcceptVisitor(figureVisitor));
        }
    }
}
