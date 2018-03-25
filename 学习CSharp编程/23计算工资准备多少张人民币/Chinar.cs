using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _23计算工资准备多少张人民币
{
    class Chinar
    {
        static void Main(string[] args)
        {
            int money   = Convert.ToInt32(Console.ReadLine()); //用户输入金额
            int m100    = money   / 100;                       //100元多少张
            int surplus = money   % 100;                       //剩余的金额 —— 几十元
            int m50     = surplus / 50;                        //以此类推
            surplus     %= 50;
            int m10     = surplus / 10;
            surplus     %= 10;
            int m5      = surplus / 5;
            surplus     %= 5;
            int m2      = surplus / 2;
            surplus     %= 2;

            Console.WriteLine("100元" + m100    + "张");
            Console.WriteLine("50元"  + m50     + "张");
            Console.WriteLine("10元"  + m10     + "张");
            Console.WriteLine("5元"   + m5      + "张");
            Console.WriteLine("2元"   + m2      + "张");
            Console.WriteLine("1元"   + surplus + "张");
            Console.ReadLine();
        }
    }
}