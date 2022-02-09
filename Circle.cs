using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    [Serializable]
    public class Circle : Shape
    {
        public override double Area()
        {
            return (int)(Math.PI * Math.Pow(Height, 2)) ;
        }
        public override void Paint(Graphics g, Color p)
        {
            var borderColor = color;
            if (Selected)
            {
                borderColor = Color.Purple;
            }
            var FillColor = Color.FromArgb(100, p);

            using (var brush = new SolidBrush(FillColor))
            {
                g.FillEllipse(brush, Location.X, Location.Y, Width, Height);
            }
            using (var pen = new Pen(borderColor, 3))
            {
                g.DrawEllipse(pen, Location.X, Location.Y, Width, Height);
                
            }
        }
        public override bool Contains(Point p)
        {
            return
                 Location.X < p.X && p.X < Location.X + Width &&
                Location.Y < p.Y && p.Y < Location.Y + Height;
        }
    }
}
