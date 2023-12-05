using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsorcio
{
    public static class ThemeColor
    {
        public static Color colorPrimario {  get; set; }
        public static Color colorSecundario { get; set; }

        public static List<string> ColorList = new List<string>()
        {
                                                    "#3F51B5",
                                                    "#FF5722",
                                                    "#607D8B",
                                                    "#FF9800",
                                                    "#9C27B0",
                                                    "#2196F3",
                                                    "#EA676C",
                                                    "#E41A4A",
                                                    "#5978BB",
                                                    "#018790",
                                                    "#00B0AD",
                                                    "#721D47",
                                                    "#EA4833",
                                                    "#EF937E",
                                                    "#F37521",
                                                    "#A12059",
                                                    "#126881",
                                                    "#8BC240",
                                                    "#364D5B",
                                                    "#C7DC5B",
                                                    "#0094BC",
                                                    "#E4126B",
                                                    "#43B76E",
                                                    "#7BCFE9",
                                                    "#B71C46" 
        };

        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //si el factor de correccion es menor a 0, el color va a ser mas oscuro
            if(correctionFactor < 0) 
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else //caso contrario, color mas claro
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
    
}
