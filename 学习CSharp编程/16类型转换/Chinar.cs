using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _16类型转换
{
    class Chinar
    {
        static void Main(string[] args)
        {
            byte cbyte = 134;         //小类型
            int  cInt  = cbyte;       //大类型 —— 小箱子放入大箱子，就是隐式转换（工作由编译器完成的）
            cbyte      = (byte) cInt; //显式转换、强转 —— 当大箱放不进小箱子，所以需要强制塞进去，就需要强转，才能放入！

            Convert.ToInt32("333");
            Convert.ToDouble("111.333");
        }
    }
}