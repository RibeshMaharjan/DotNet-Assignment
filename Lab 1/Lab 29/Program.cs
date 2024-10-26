// Give an example of Virtual Method and Virtual Class in C#.

using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle();
        circle.Draw();
    }

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("\nDrawing a Circle.");
        }
    }
}