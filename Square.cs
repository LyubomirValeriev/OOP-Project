using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Проект
{
    [Serializable]
    public class Square : Shape
    {
        public override double Area()
        {
            return Math.Pow(Height, 2);
        }

        public override void Paint(Graphics g, Color square)
        {
            var borderColor = color; 
            if (Selected)
            {
                borderColor = Color.Red;
            }
            var FillColor = Color.FromArgb(100, square);

            using (var brush = new SolidBrush(FillColor))
            {
                g.FillRectangle(brush, Location.X, Location.Y, Width, Height);
            }
            using (var pen = new Pen(borderColor, 3))
            {
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
            }
        }

        public override bool Contains(Point s)
        {
            return
                Location.X < s.X && s.X < Location.X + Width &&
                Location.Y < s.Y && s.Y < Location.Y + Height;
        }
    }
}
