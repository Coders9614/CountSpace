using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSpace
{
    public class Program
    {
        public static int CountSpaces(string input)
        {
            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                }
            }
            return spaceCount;
        }

        public static void Main(string[] args)
        {
            Console.Write("Please input a string: ");
            string inputString = Console.ReadLine();

            int spaces = CountSpaces(inputString);

            Console.WriteLine($"\"{inputString}\" contains {spaces} spaces");
            Console.ReadKey();
        }
    }
}
