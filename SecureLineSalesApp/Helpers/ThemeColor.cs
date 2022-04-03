using System.Collections.Generic;
using System.Drawing;

namespace SecureLineSalesApp.Helpers
{
    internal class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> colorList = new List<string>()
        {
            "#c92a2a", 
            "#a61e4d",
            "#1864ab",
            "#087f5b",
            "#2b8a3e",
            "#c0eb75",
            "#d9480f",
            "#5c940d",
            "#364fc7"
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            if (correctionFactor > 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
