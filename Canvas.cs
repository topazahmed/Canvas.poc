using System;

namespace Shaw
{
    class Canvas
    {
        public void Draw(int shape)
        {
            Console.WriteLine("Drawing " + shape);
            Type ShapeType;
            switch (shape)
            {
                case 1:
                    ShapeType = typeof(Circle); break;
                case 2:
                    ShapeType = typeof(Line); break;
                case 3:
                    ShapeType = typeof(Box); break;
                default:
                    ShapeType = null;
                    break;
            }
            if (ShapeType != null)
            {
                var shapeToDraw = Activator.CreateInstance(ShapeType);
                Console.WriteLine("Drawing: "+ shapeToDraw.ToString());
            }
        }
    }
}
