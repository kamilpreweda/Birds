using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class Egg
    {
        public double Size { get; private set; }
        public string Color { get; private set; }
        public Egg(double size, string color)
        {
            Size = size;
            Color = color;
        }
        public string Description
        {
            get { return $"\n{Color} jajo o wielkości {Size:0.0} cm."; }
        }
    }
}
