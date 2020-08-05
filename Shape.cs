using System.Drawing;

namespace Shaw
{
    public class Shape
    {
        public Shape()
        {
        }
        protected Color Background { get; set; }

        public void SetBackground(Color bgColor)
        {
            Background = bgColor;
        }
    }
}