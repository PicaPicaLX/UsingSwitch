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
            //UsIf();
            UsSwitch();
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

        static void UsSwitch()
        {
            Console.WriteLine("请输入要查询的分数线（一本、二本、民办、艺术类、体育类）");
            string strNum = Console.ReadLine();
            switch (strNum)
            {
                case "一本":
                    Console.WriteLine("一本分数线：555");
                    break;
                case "二本":
                    Console.WriteLine("二本分数线：445");
                    break;
                case "体育类":
                    Console.WriteLine("体育类本科分数线：280");
                    break;
                case "艺术类":
                    Console.WriteLine("艺术类本科分数线：290");
                    break;
                case "民办":
                    Console.WriteLine("民办本科分数线：350");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
