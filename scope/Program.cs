using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace scope
{
    class Program
    {

        private static int x = 1;

        static void Main(string[] args)
        {
            int x  = 5;
            Console.WriteLine($"local x in main method main is {x} ");
            UseLocalVarible();
            UseStaticVarible();
            Console.ReadKey();
        }

        static void UseLocalVarible ()
        {
            int x = 25;
            Console.WriteLine($"local x method UseLocalVariable is {x}");
            ++x;
            Console.WriteLine($"local x before exiting method UseLocalVariable {x}");

        }
        static void UseStaticVarible ()
        {
            Console.WriteLine($"static variable x on entering method UseStaticVariable {x}");
            x *= 10;
            Console.WriteLine($"static variable x on entering method UseStaticVariable {x}");
        }

    }
}
