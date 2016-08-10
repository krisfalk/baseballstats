using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStats
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayTools myArray = new ArrayTools();
            Console.Clear();
            myArray.PrintArray(myArray.statNames, myArray.stats);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("This players slugging percentage is:");
            myArray.CalculateSLG();
            Console.ReadLine();
        }
    }
}
