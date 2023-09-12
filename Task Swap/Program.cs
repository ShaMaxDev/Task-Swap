using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Bychkov";
            string lastName = "Max";
            string buffer;
            Console.WriteLine("Before correcting Name is " + name + " and last name is " + lastName);
            buffer = name;
            name = lastName;
            lastName = buffer;
            Console.WriteLine("After correcting Name is " + name + " and last name is " + lastName);

        }
    }
}
