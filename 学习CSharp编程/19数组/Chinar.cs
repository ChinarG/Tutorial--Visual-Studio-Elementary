using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19数组
{
    class Chinar
    {
        static void Main(string[] args)
        {
            //第一种：声明 + 初始化，直接赋值
            int[] iInt = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //第二种：声明 + 初始化，没有赋值 —— 所有值都为0
            int[] iInts =new int[10];

            //第三种：声明 + 初始化，并且赋值
            int[] iScores=new int[10]{1,2,3,4,5,6,7,8,9,10};
        }
    }
}
