using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12平方根
{
    class Chinar
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                int pingfang = i * i;
                double gen = Math.Sqrt(i);//求平方根
                Console.WriteLine(pingfang );
                Console.WriteLine(gen);
            }
            Console.ReadKey();
        }
    }
}
