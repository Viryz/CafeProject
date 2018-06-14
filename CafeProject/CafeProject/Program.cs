using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Cafe cafe = new Cafe(20, 100);
            cafe.Start();
        }
    }
}
