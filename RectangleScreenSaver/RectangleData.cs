using System.Collections.Generic;
using System.Drawing;

namespace RectangleScreenSaver
{
    class RectangleData
    {
        public double CX { get; set; }

        public double CY { get; set; }

        public Brush DrawBrush { get; set; }

        public List<Point> Points { set; get; }

        public RectangleData(double cx, double cy, Brush b)
        {
            CX = cx;
            CY = cy;
            DrawBrush = b;
            Points = new List<Point>();
        }
    }
}
