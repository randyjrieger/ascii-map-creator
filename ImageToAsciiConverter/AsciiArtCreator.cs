using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAsciiConverter
{
    public class AsciiArtCreator
    {
        private string imageLocation;
        public AsciiArtCreator(string ImageLocation)
        {
            this.imageLocation = ImageLocation;
        }

        private string pixels = ".#";


        public void Go(string saveLocation)
        { 
            var img = new Bitmap(imageLocation);
            using (var writer = new StreamWriter(saveLocation))
            {
                for(var y = 0; y < img.Height; y++)
                {
                    for (var x = 0; x < img.Width; x++)
                    {
                        var pxl = ".";
                        var color = img.GetPixel(x,y);
                        var brightness = Brightness(color);
                       // var idx = 1;

                        if (brightness < 150)
                        {
                           // idx = 0;
                            pxl = "#";
                        }

                        writer.Write(pxl);
                    }
                    writer.WriteLine();
                }
            }
        }

        private static double Brightness(Color c)
        {
            return Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
    }
}
