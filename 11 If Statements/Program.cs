using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
        bool isFemale = true;
            if (isFemale)
            {
                Console.WriteLine("you are female");
            }
            else
            {
                Console.WriteLine("you are male");
            }
            bool isTall = false;
            if (isTall && isFemale)
            {
                Console.WriteLine("you are both female and tall");
            }
            else if (isTall && isFemale)
            {
                Console.WriteLine("you are not tall but yoy are female");
            }
            else
            {
                Console.WriteLine("you are either not tall or not a male");
            }  Console.ReadLine();

        }
    }
}
