using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07三元运算符
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int num = 100;
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);

            string readStr = score > 50 ? "对" : "错";
            Console.WriteLine(readStr);
        }
    }
}
