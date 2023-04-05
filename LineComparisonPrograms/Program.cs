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
            //LineLength length = new LineLength(4, 8, 3, 5);       \\UC1
            //length.Calculate();
            //Console.ReadLine();

            EqualityOfLines length_One = new EqualityOfLines(4, 2, 7, 3);
            double Length = length_One.CalculateOne();

            EqualityOfLines length_Two = new EqualityOfLines(5, 8, 4, 6);
            double length_ = length_Two.CalculateTwo();

            if (Length.Equals(length_))
                Console.WriteLine("Both line are equal");
            else
                Console.WriteLine("Both lines are not equal");

            Console.ReadLine();
        }
    }
}
