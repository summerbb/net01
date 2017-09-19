using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("请选择月份[1,2,3,4,5,6,7,8,9,10,11,12]:");
                string s = Console.ReadLine();
                switch (s)
                {
                    case "1":
                        Console.WriteLine("所在季节为冬季");
                        break;
                    case "2":
                        Console.WriteLine("所在季节为冬季");
                        break;
                    case "3":
                        Console.WriteLine("所在季节为春季");
                        break;
                    case "4":
                        Console.WriteLine("所在季节为春季");
                        break;
                    case "5":
                        Console.WriteLine("所在季节为春季");
                        break;
                    case "6":
                        Console.WriteLine("所在季节为夏季");
                        break;
                    case "7":
                        Console.WriteLine("所在季节为夏季");
                        break;
                    case "8":
                        Console.WriteLine("所在季节为夏季");
                        break;
                    case "9":
                        Console.WriteLine("所在季节为秋季");
                        break;
                    case "10":
                        Console.WriteLine("所在季节为秋季");
                        break;
                    case "11":
                        Console.WriteLine("所在季节为秋季");
                        break;
                    case "12":
                        Console.WriteLine("所在季节为冬季");
                        break;
                    default:
                        Console.WriteLine("输入无效");
                        break;
                }
            }
        }
    }
}
