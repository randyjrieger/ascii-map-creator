using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageToAsciiConverter
{
    public class MapPoint
    {
        private int x;
        private int y;

        public double X { get { return x; } }
        public double Y { get { return y; } }

        public MapPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
