using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08if_else
{
    class Chinar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("你考了多少？");
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);

            if (score>=90)
            {
                Console.WriteLine("优秀啊"+score);
            }
            else if (score>=80)
            {
                Console.WriteLine("良"+score);
            }
            else if (score>=70)
            {
                Console.WriteLine("中"+score);
            }
            else
            {
                Console.WriteLine("差");
            }

            Console.ReadKey();
        }
    }
}
