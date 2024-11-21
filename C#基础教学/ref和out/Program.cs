using System;
namespace ref和out
{
    class Program
    {
        #region 知识点一 学习ref和out的原因
        //他们可以解决 在函数内部改变外部传入的内容 里面变了 外面也要变

        static void ChageValue(int value)
        {
            value = 3;

        }
        static void ChageArrayValue(int[] arr)
        {
            arr[0] = 99;
        }

        static void ChageArray(int[] arr)
        {
            //重新申明一个数组
            arr = new int[] { 10, 20, 99 };
        }
        #endregion
        #region 知识点二 ref和out的使用
        //函数参数的修饰符
        //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新申明时
        //外部的值会发生变化

         static void ChangeValueRef(ref int value)
        {
            value = 3;
        }

        static void ChangeArrayRef(ref int[] arr)
        {
            arr = new int[] { 10, 20, 99 };
        }

        //out
        static void ChangeValueOut(out int value)
        {
            value = 99;
        }
        static void ChangeArrayOut(out int[] arr)
        {
            arr = new int[] { 777,888,999 };
        }
        #endregion
        #region 知识点三 ref和out的区别
        //1.ref传入的变量必须初始化 out不用
        //2.out传入的变量必须在内部赋值 ref不用
        //有票上车 有票下车

        //ref传入变量必须初始化  在内部 可改可不改
        //out传入变量不用初始化 在内部 必须修改值
        #endregion


        //总结
        //1.ref和out的作用：解决值类型和引用类型 在函数内部 改值 或者 重新申明 能够影响外部传入的变量 让其也被修改
        //2.使用上：就是在申明参数的时候 前面加上 ref和out的 关键字即可 使用时 同上
        //3.区别
        //ref传入变量必须初始化  在内部 可改可不改
        //out传入变量不用初始化 在内部 必须修改值
        static void Main(string[] args)
        {
            int a = 1;
            ChageValue(a);
            Console.WriteLine(a);

            ChangeValueRef(ref a);
            Console.WriteLine(a);

            ChangeValueOut(out a);
            Console.WriteLine(a);

            int[] arr2 = {1,2,3};
            ChageArrayValue(arr2);
            Console.WriteLine(arr2[0]);

            ChageArray(arr2);
            Console.WriteLine(arr2[0]);

            ChangeArrayRef(ref arr2);
            Console.WriteLine(arr2[0]);

            ChangeArrayOut(out arr2);
            Console.WriteLine(arr2[0]);


            int b;
            ChangeValueRef(ref b);
            ChangeValueOut(out b);
        }
    }
}