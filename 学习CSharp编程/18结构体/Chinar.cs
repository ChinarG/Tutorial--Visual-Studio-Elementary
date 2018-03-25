using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _18结构体
{
    /// <summary>
    /// 结构体
    /// </summary>
    struct MyStruct
    {
        public float x;
        public float y;
        public float z;
    }


    /// <summary>
    /// 枚举一个东南西北
    /// </summary>
    enum Direction
    {
        West,
        North,
        East,
        South
    }


    /// <summary>
    /// 结构体 —— 表示路径：有方向 和 距离
    /// </summary>
    struct S
    {
        public float     distance; //距离
        public Direction dir;      //方向
    }
    class Chinar
    {
        /// <summary>
        /// 结构体 —— 可以把结构体当成几个小属性，组成的一个大类型！
        /// 比如3个数值，组成一个坐标！
        /// 定义 长宽高 ，组成一个体积结构
        /// </summary>
        static void Main()
        {
            //通过3个 小数值，来表示一个 人物的坐标
            float x1 = 1;
            float y1 = 2;
            float z1 = 3;

            //如果设置第二个人物的坐标，需要重新建立3个小数变量
            float x2 = 4;
            float y2 = 5;
            float z2 = 6;

            //当使用结构体声明变量的时候，相当于使用结构体中所有的变量，去声明（就是说一次声明了3个变量）
            MyStruct cs;
            cs.x = 1; //直接就可以访问结构体中变量，并且赋值；（但是结构体中的变量，需要是 public才能访问到)

            MyStruct cs2; //使用结构体可以使程序更为清晰
            cs2.x = 4;
        }


        static void Main1()
        {
            S s;                         //声明一个路径对象
            s.dir      = Direction.East; //设置方向
            s.distance = 1000;           //设置距离
        }
    }
}