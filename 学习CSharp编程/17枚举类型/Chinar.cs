using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;


namespace _17枚举类型
{
    enum People:byte
    {
        Man=200,
        Woman,
        Good,
        Bad,
        Old,
        Young
    }

    class Chinar
    {
        /// <summary>
        /// 测试枚举类型
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            People people = People.Old;

            int num = (int)people;//枚举类型是整数类型，可以强转
            switch (people)
            {
                case People.Man:
                    break;
                case People.Woman:
                    break;
                case People.Good:
                    break;
                case People.Bad:
                    break;
                case People.Old:
                    break;
                case People.Young:
                    break;
                default:
                    break;
            }


            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}