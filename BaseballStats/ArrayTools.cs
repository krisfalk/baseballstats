using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballStats
{
    class ArrayTools
    {
        public double[] stats;
        public string[] statNames;

        public ArrayTools()
        {
            stats = new double[5];
            statNames = new string[]{"Singles", "Doubles", "Triples", "Home Runs", "At Bat"};
            fillStatArray();
        }
        public void fillStatArray()
        {
            for (int i = 0; i < statNames.Length; i++)
            {
                Console.WriteLine("Enter number for {0}", statNames[i]);
                stats[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public void CalculateSLG()
        {
            double final;

            final = (stats[0] + (2 * stats[1]) + (3 * stats[2]) + (4 * stats[3])) / stats[4];
            Console.WriteLine(final);
        }
        public void PrintArray(string[] stringArray, double[] intArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
                Console.WriteLine(intArray[i]);
            }
        }
    }
}
