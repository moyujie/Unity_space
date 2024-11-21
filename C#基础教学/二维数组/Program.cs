using System;
namespace 二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本概念
            //二维数组 是使用两个下标（索引）来确定元素的数组
            //两个下标可以理解成 行标 和 列标
            //比如矩阵
            //1 2 3
            //4 5 6
            //可以用二维数组 int(2,3)表示
            //好比 两行 三列的数据集合
            #endregion
            #region 知识点二 二维数组的申明
            //变量类型[ , ] 二维数组变量名;
            int[,] arr;//申明过后 会在后面进行初始化

            //变量类型[,] 二维数组变量名 = new 变量类型[行,列];
            int[,] arr2 = new int[3, 3];

            //变量类型[,] 二维数组变量名 = new 变量类型[行,列]{{0行内容1，0行内容2，0行内容3...},{1行内容1，1行内容2，1行内容3...},{2行内容1，2行内容2，2行内容3...}...};
            int[,] arr3 = new int[3, 3] { { 1, 2, 3 }, 
                                          { 4, 5, 6 }, 
                                          { 7, 8, 9 } };

            //变量类型[,] 二维数组变量名 = new 变量类型[,]{{0行内容1，0行内容2，0行内容3...},{1行内容1，1行内容2，1行内容3...},{2行内容1，2行内容2，2行内容3...}...};
            int[,] arr4 = new int[, ] { { 1, 2, 3 },
                                          { 4, 5, 6 },
                                          { 7, 8, 9 } };

            //变量类型[,] 二维数组变量名 = {{0行内容1，0行内容2，0行内容3...},{1行内容1，1行内容2，1行内容3...},{2行内容1，2行内容2，2行内容3...}...};
            int[,] arr5 = { { 1, 2, 3 },
                            { 4, 5, 6 },
                            { 7, 8, 9 } };
            #endregion
            #region 知识点三 二维数组的使用 
            int[,] array = new int[,] { { 1, 2, 3 },
                                        { 4, 5, 6 } };
            //1.二维数组的长度
            //分别获取 行和列是多长
            //得到多少行
            Console.WriteLine(array.GetLength(0));
            //得到多少列
            Console.WriteLine(array.GetLength(1));

            //2.获取二维数组中的元素
            //注意：第一个元素的索引是0 最后一个元素的索引 肯定是长度-1
            Console.WriteLine(array[0, 1]);
            Console.WriteLine(array[1, 2]);

            //3.修改二维数组中的元素
            array[0, 0] = 99;
            Console.WriteLine(array[0, 0]);

            //4.遍历二维数组
            for(int i = 0;i< array.GetLength(0); i++)
            {
                for(int j = 0;j< array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }

            //5.增加二维数组的元素
            //数组声明初始化后 就不能在原有基础上进行 添加或者删除
            int[,] array2 = new int[3, 3];
            for(int i=0;i< array.GetLength(0); i++)
            {
                for(int j=0;j< array.GetLength(1); j++)
                {
                    array2[i,j] = array[i, j];
                }
            }
            array = array2;
            array[2, 0] = 7;
            array[2, 1] = 8;
            array[2, 2] = 9;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //i行 0 1
                    //j列 0 1 2
                    Console.WriteLine($"{array[i, j]}");
                    //0,0 0,1 0,2
                    //1,0 1,1 1,2
                }
            }
            //6.删除数组的元素
            
            //

            //

            //
            #endregion
        }
    }
}
