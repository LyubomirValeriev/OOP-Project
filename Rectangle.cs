using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    [Serializable]
    public class Rectangle : Shape
    {
        public override double Area()
        {
            return  
                Width * Height;
        }
        public override void Paint(Graphics g , Color rectangleC)
        {
            var borderColor = color;
            if (Selected)
            {
                borderColor = Color.DarkCyan; 
            }    


            var FillColor = Color.FromArgb(100, rectangleC);

            using (var brush = new SolidBrush(FillColor))
                g.FillRectangle(brush, Location.X, Location.Y, Width, Height);


            using (var pen = new Pen(borderColor, 3))
                g.DrawRectangle(pen, Location.X, Location.Y, Width, Height);
        }

        public override bool Contains(Point p)
        {
            return
                Location.X < p.X && p.X < Location.X + Width &&
                Location.Y < p.Y && p.Y < Location.Y + Height;
        }
    }
}
