using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            LineLength length = new LineLength(4, 8, 3, 5);
            length.Calculate();
            Console.ReadLine();
        }
    }
}
