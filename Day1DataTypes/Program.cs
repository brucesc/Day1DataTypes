using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int ii;
            double dd;
            string ss;

            

            Console.WriteLine("Please provide an integer: ");
            ii = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please provide a double: ");
            dd = Convert.ToDouble(Console.ReadLine());
            double stupid = d + dd;
            string verStupid = stupid.ToString("0.0");

            Console.WriteLine("Please finish this sentence: HackerRank ");
            ss = Console.ReadLine();

            Console.WriteLine("We have changed your integer to {0}", i + ii);
            Console.WriteLine(verStupid);
            Console.WriteLine(s + ss);

            Console.ReadKey();

            //some of this code will need to be removed to get the actual answer correct in Hackerrank. Run this to figure out which lines of code need edits.
            
        }
    }
}
