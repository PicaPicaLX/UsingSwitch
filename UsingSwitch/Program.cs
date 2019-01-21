using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            UsIf();
        }

        static void UsIf()
        {
            char grade = 'B';
            if (grade=='A')
            {
                Console.WriteLine("真棒!");
            }
            if (grade=='B')
            {
                Console.WriteLine("还可以!");
            }
            if (grade=='c')
            {
                Console.WriteLine("继续努力");
            }
            Console.ReadLine();
        }
    }
}
