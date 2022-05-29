using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class BrokenEgg : Egg
    {
        public BrokenEgg(double size, string color) : base(size, color)
        {
            Console.WriteLine("Ptak złożył pęknięte jajo");
        }
    }
}
