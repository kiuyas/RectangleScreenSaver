using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleScreenSaver
{
    class RectangleSettings
    {
        public static readonly Brush[][] BRS_MASTER = {
            new Brush[] { Brushes.Blue, Brushes.Red, Brushes.Lime, Brushes.Magenta, Brushes.Cyan, Brushes.Yellow },
            new Brush[] { Brushes.DeepSkyBlue, Brushes.Pink, Brushes.PaleGreen, Brushes.Violet, Brushes.LightCyan, Brushes.LightYellow },
        };

        public const int DEFAULT_COLOR_MODE = 0;

        public const int DEFAULT_RECTANGLES = 3;

        public const int DEFAULT_MAX_COUNT = 200;

        public const int DEFAULT_W = 50;

        public const int DEFAULT_H = 60;

        public const int DEFAULT_R = 16;

        public int ColorMode { get; set; }
        public int Rectangles { get; set; }
        public int MaxCount { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int R { get; set; }
        public Brush[] BrushesSet { get; set; }

        public RectangleSettings()
        {
            ColorMode = DEFAULT_COLOR_MODE;
            Rectangles = DEFAULT_RECTANGLES;
            MaxCount = DEFAULT_MAX_COUNT;
            W = DEFAULT_W;
            H = DEFAULT_H;
            R = DEFAULT_R;

            BrushesSet = BRS_MASTER[ColorMode];
        }

        public RectangleSettings(int colorMode, int rectangles, int maxCount, int w, int h, int r)
        {
            ColorMode = colorMode;
            Rectangles = rectangles;
            MaxCount = maxCount;
            W = w;
            H = h;
            R = r;

            BrushesSet = BRS_MASTER[ColorMode];
        }
    }
}
