using System;
namespace 值和引用
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 变量类型的复习
            //无符号整型
            byte b = 1;
            ushort us = 1;
            uint ui = 1;
            ulong ul = 1;

            //有符号整型
            sbyte sb = 1;
            short s = 1;
            int i = 1;
            long l = 1;
            //浮点数
            float f = 1f;
            double d = 1.1;
            decimal de = 1.1m;
            //特殊类型
            bool bo = true;
            char c = 'A';
            string str = "strs";
            //复杂数据类型
            //enum枚举
            //数组（一维，二维，交错）

            //将以上 变量类型 分为 值类型和引用类型
            //引用类型：string 数组 类
            //值类型：其他 结构体
            #endregion
            #region 知识点二 值类型和引用类型的区别
            //1.使用上的区别
            //值类型 
            int a = 10;
            //引用类型
            int[] arr = new int[] {1,2,3,4};

            //申明q让其等于a
            int q = a;
            int[] arr2 = arr;
            Console.WriteLine("a={0},q={1}", a, q);
            Console.WriteLine("arr[0]={0},arr2{0}={1}", arr[0], arr2[0]);

            q = 20;
            arr2[0] = 5;
            Console.WriteLine("a={0},q={1}", a, q);
            Console.WriteLine("arr[0]={0},arr2{0}={1}", arr[0], arr2[0]);
            //值类型 在相互赋值时 把内容拷贝给堆放 它变我不变
            //引用类型相互赋值 是 让两者指向同一个值 它变我也变

            //2.为什么有以上区别
            //值类型 和 引用类型 存储在的 内存区域 不同 存储方式不同
            //所以有使用上的区别

            //值类型存储在 栈空间 ——— 系统自动分配，自动回收，小而快
            //引用类型 存储在 堆空间 ———— 手动申请和释放 大而慢
            
            //new 就是开辟新房间 和之前无关 所以arr不会变
            arr2 = new int[] { 99, 3, 2, 1 };
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            #endregion
        }
    }
}
