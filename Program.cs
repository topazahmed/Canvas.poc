using System;

namespace Shaw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the shape you want to draw: ");
            Console.WriteLine("Enter 1 for Circle.");
            Console.WriteLine("Enter 2 for Line.");
            Console.WriteLine("Enter 3 for Box.");

            int shape = 0;
            int.TryParse(Console.ReadLine(), out shape);
            if (shape < 1 || shape > 3)
            {
                return;
            }
            Canvas canvas = new Canvas();
            canvas.Draw(shape);

            Console.WriteLine("Done...");
        }
    }
}
