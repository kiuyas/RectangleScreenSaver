using System;
using System.Collections.Generic;
using System.Drawing;

namespace RectangleScreenSaver
{
    class RectangleGenerator
    {
        const double DELTA = 0.01;

        public void Prepare(RectangleData data, RectangleSettings settings)
        {
            data.Points = new List<Point>();

            double cx = data.CX, cy = data.CY;
            int W = settings.W;
            int H = settings.H;
            int R = settings.R;

            // 右上
            double x = cx + settings.W;
            double y = cy - settings.H;
            Point[] pp = GenerateArc(x - R, y + R, R, 0, Math.PI * 0.5);
            data.Points.AddRange(pp);

            // 左上
            x = cx - W;
            y = cy - H;
            pp = GenerateArc(x + R, y + R, R, Math.PI * 0.5, Math.PI);
            data.Points.AddRange(pp);

            // 左下
            x = cx - W;
            y = cy + H;
            pp = GenerateArc(x + R, y - R, R, Math.PI, Math.PI * 1.5);
            data.Points.AddRange(pp);

            // 右下
            x = cx + W;
            y = cy + H;
            pp = GenerateArc(x - R, y - R, R, Math.PI * 1.5, Math.PI * 2);
            data.Points.AddRange(pp);
        }

        private Point[] GenerateArc(double cx, double cy, double r, double start, double end)
        {
            return GenerateArc(cx, cy, r, start, end, 1);
        }

        private Point[] GenerateArc(double cx, double cy, double r, double start, double end, double v)
        {
            var pp = new List<Point>();

            for(var theta = start; theta <= end; theta += DELTA * v)
            {
                pp.Add(new Point(T(cx + Math.Cos(theta) * r), T(cy - Math.Sin(theta) * r)));
            }

            return pp.ToArray();
        }

        private int T(double v)
        {
            return (int)v;
        }
    }
}
