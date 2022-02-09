using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    [Serializable]
    public class Triangle : Shape
    {
        
        public double Area(int a, int b , int c)
        {
            double p = (a + b + c) / 2;
            p = Math.Sqrt( p * (p - a) * (p - b) * (p - c) ); 
            return p;
        }

        public override bool Contains(Point p)
        {
            throw new NotImplementedException();
        }

        public override void Paint(Graphics g , Color t )
        {
            //var FillColor = Color.FromArgb(100, triangle.color);

          /*  using (var brush = new SolidBrush(Color.Red))
                g.FillPolygon(brush, new PointF[] 
                { 
                    new PointF(Location.X,Location.Y ),
                    new PointF(Math.Abs(Location.X - Width ),Math.Abs(Location.Y - Width ) ),
                    new PointF(Math.Abs(Location.X - Height ),Math.Abs(Location.Y - Height ) )
                });
          */
            using (var pen = new Pen(Color.Black))
                g.DrawPolygon(pen , new PointF[]
                {
                   new PointF(Location.X,Location.Y ),
                    new PointF(Math.Abs(120 ),Math.Abs(10) ),
                    new PointF(Math.Abs(70 ),Math.Abs(120) )
                });
        
            }
    }
}
