using System;
namespace 交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本概念
            //交错数组 是 数组的数组，每个维度的数量可以不同

            //注：二维数组的每行的列数相同，交错数组每行的列数可能不同
            #endregion
            #region 知识点二 数组的申明
            //变量类型[][] 交错数组名；
            int[][] arr1;

            //变量类型[][] 交错数组名 = new 变量类型[行数][]；
            int[][] arr2 = new int[3][];

            //变量类型[][] 交错数组名 = new 变量类型[行数][]{一维数组1，一维数组2，...}；
            int[][] arr3 = new int[3][] { new int[] { 1, 2, 3 },
                                          new int[] {1,2 },
                                          new int[] {1 } };

            //变量类型[][] 交错数组名 = new 变量类型[][]{一维数组1，一维数组2，...}；
            int[][] arr4 = new int[][] { new int[] { 1, 2, 3 },
                                          new int[] {1,2 },
                                          new int[] {1 } };


            //变量类型[][] 交错数组名 = {一维数组1，一维数组2，...}；
            int[][] arr5 = { new int[] { 1, 2, 3 },
                             new int[] {1,2 },
                             new int[] {1 } };

            #endregion
            #region 知识点三 数组的使用
            int[][] array = { new int[] { 1, 2, 3 },
                              new int[] {4,5}};
            //1.数组的长度
            //行
            Console.WriteLine(array.GetLength(0));
            //列（某一行的）
            Console.WriteLine(array[0].Length);

            //2.获取交错数组中的元素
            Console.WriteLine(array[0][1]);

            //3.修改交错数组中的元素
            array[0][1] = 99;
            Console.WriteLine(array[0][1]);
            
            //4.遍历交错数组
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]+" ");
                }
            }

            

            //

            //总结
            //1.概念：交错数组 可以存储同一类型的m行不确定列的数据
            //2.
            //3.所有变量类型都可以申明为 交错数组
            //4.一般很少用到
            #endregion
        }
    }
}