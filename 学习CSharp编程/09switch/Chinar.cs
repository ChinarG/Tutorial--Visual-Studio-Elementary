using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09switch
{
    class Chinar
    {
        static void Main(string[] args)
        {
            string str   = Console.ReadLine();
            int num = Convert.ToInt32(str);
            switch (num)
            {
                case 0:
                    Console.WriteLine("开始");
                    break;
                case 1:
                    Console.WriteLine("这是1");
                    break;
                case 2:
                    Console.WriteLine("这是2");
                    break;
                case 4:
                    Console.WriteLine("这是3");
                    break;
                    default: Console.WriteLine("什么都不是");
                        break;
            }
            Console.ReadKey();
        }
    }
}
