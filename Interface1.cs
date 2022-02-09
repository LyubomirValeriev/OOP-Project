using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{

    public interface IShape
    {
        int TypeShape { get;  }
        void Paint(Graphics g, Color s);

        Point Location { get; set; }

        int Width { get; set; }

        int Height { get; set; }

        Color color { get; set; }

        double Area(); 

        bool Selected { get; set; }

        bool Chosen { get; set; }

        bool Contains(Point p);

    }
}
