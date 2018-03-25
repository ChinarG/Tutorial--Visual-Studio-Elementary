using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _33百元买百鸡
{
    class Chinar
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 1000 / 5; i++)
            {
                for (int j = 0; j <= (1000 - i * 5) / 3; j++)
                {
                    int money = 1000 - i * 5 - 3 * j;
                    int numJi = money   * 3;
                    if (i + j + numJi == 1000)
                    {
                        Console.Write("公鸡:" + i + "只" + "||||" + "母鸡:" + j + "只" + "||||" + "小鸡:" + numJi + "只");
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}