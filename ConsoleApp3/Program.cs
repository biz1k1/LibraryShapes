using LibraryShapes;
using LibraryShapes.interfaces;
class Program
{
    static void Main()
    {
        IShapeHandler shape = new ShapeHandler();
        Console.WriteLine(shape.CircleArea(-5));
    }
}