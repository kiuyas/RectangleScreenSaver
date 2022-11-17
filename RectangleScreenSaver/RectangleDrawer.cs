using System.Collections.Generic;
using System.Drawing;

namespace RectangleScreenSaver
{
    class RectangleDrawer
    {
        public static void Execute(Graphics g, List<RectangleData> rectangleList)
        {
            if (rectangleList != null)
            {
                foreach (RectangleData data in rectangleList)
                {
                    DrawOneRectangle(g, data.Points, data.DrawBrush);
                }
            }
        }

        /// <summary>
        /// 描画コア
        /// </summary>
        /// <param name="points"></param>
        /// <param name="g"></param>
        /// <param name="drawPen"></param>
        private static void DrawOneRectangle(Graphics g, List<Point> points, Brush drawBrush)
        {
            g.FillPolygon(drawBrush, points.ToArray());
        }
    }
}
