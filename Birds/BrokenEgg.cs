using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birds
{
    public class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0, $"{color} pęknięte ")
        {
            Console.WriteLine("\nPtak złożył pęknięte jajo");
        }
    }
}
