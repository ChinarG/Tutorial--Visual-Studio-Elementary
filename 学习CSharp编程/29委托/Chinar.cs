using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _29委托
{
    public delegate double MyDelegate(double a, double b); //定义一个委托

    //委托的参数、返回值，必须要和与将要赋值给它的方法的参数、返回值保值一致

    class Chinar
    {

        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }


        static double Divide(double param1, double param2)
        {
            return param1 / param2;
        }


        static void Main(string[] args)
        {
            MyDelegate de;//利用自定义委托类型，声明一个新的变量 de；
            de = Multiply;//给委托对象赋值一个函数
            Console.WriteLine(de(3.3, 2.2));
            de = Divide;
            Console.WriteLine(de(4,2));
            Console.ReadLine();
        }
    }
}