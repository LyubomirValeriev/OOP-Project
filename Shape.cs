using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Проект
{
    [Serializable]
    public abstract class Shape : IShape
    {

        public virtual double Area()
        {
            return Height * Width;
        }
        public Point Location { get; set; }

        public int Width { get; set; }
        public int Height { get; set; }
        public Color color { get; set; }
        public bool Selected { get; set; }

        public bool Chosen { get; set; }

        public int TypeShape { get; set; }

        public abstract void Paint(Graphics g, Color s);
        public abstract bool Contains(Point p);
    }
}
