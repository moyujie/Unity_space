using System;
namespace 特殊引用类型string
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 复习值和引用类型
            //值类型 它变我不变 存储在栈内存中
            //无符号整型 有符号整型 浮点数 char bool 结构体

            //引用类型 它变我也变 存储在堆内存中
            //数组（一维、二维、交错） string 类
            #endregion
            #region 知识点二 它变我不变
            string str1 = "123";
            string str2 = str1;
            //因为string是引用类型 按理说 它变我也变
            //string非常特殊 具备值类型的特征 它变我不变
            //重新赋值会在 堆中 重新分配空间
            str2 = "321";

            Console.WriteLine(str1);
            Console.WriteLine(str2);

            //string虽然方便 但是频繁改变 重新赋值
            //会产生 内存垃圾
            //优化替代方案
            #endregion

            //通过断点调试 在监视窗口中查看
        }
    }
}
