using System;
namespace 冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 排序的基本概念
            //排序是计算机内经常进行的一种操作 其目的是将一组“无序”的记录序列调整为“有序”的记录序列
            //常用的排序例子
            //8 7 1 5 4 2 6 3 9
            //把上面的这个无序序列 变为 有序（升序或降序） 序列的过程
            //1 2 3 4 5 6 7 8 9（升序）
            //9 8 7 6 5 4 3 2 1（降序）

            //在程序中 序列一般 存储在数组当中
            //所以 排序往往是对 数组进行排序
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            //把数组里面的内容变为有序的
            #endregion
            #region 知识点二 冒泡排序基本原则
            //8 7 1 5 4 2 6 3 9
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            #endregion
            #region 知识点三 代码实现
            //第一步 如何比较数组中两两相邻的数
            //8 7 1 5 4 2 6 3 9
            //从头开始
            //第n个数和第n+1个数比较
            
            //如何换m轮
            for(int m = 0; m < arr.Length; m++)
            {
                //进一次循环 就需要比较一轮
                for (int n = 0; n < arr.Length - 1; n++)
                {
                    //如果 第n个数 比第n+1个数大  就要交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        //交换位置
                        int tmp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = tmp;
                    }
                }
            }
            for(int i=0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //第四步 优化
            //1.确定位置的数字 不用比较
            //确定了一轮后 极值（最大或最小）已经放到了对应的位置（往后放）
            //所以 没完成n轮 后面位置的数 就不用再参与比较了
            for (int m = 0; m < arr.Length; m++)
            {
                //进一次循环 就需要比较一轮
                for (int n = 0; n < arr.Length - 1-m; n++)
                {
                    //如果 第n个数 比第n+1个数大  就要交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        //交换位置
                        int tmp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = tmp;
                    }
                }
            }

            //2.特殊情况优化（不用排完m轮）

            //外面申明一个标识 表示该轮是否进行了交换
            bool isSort = false;
            for (int m = 0; m < arr.Length; m++)
            {
                //每一轮开始时 默认没有进行过交换
                isSort = false;
                //进一次循环 就需要比较一轮
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    //如果 第n个数 比第n+1个数大  就要交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        isSort=true;
                        //交换位置
                        int tmp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = tmp;
                    }
                }
                //当一轮结束过后 如果isSort还是false
                //那就意味着 已经是最终的序列 不需要再判断交换
                if(!isSort)
                {
                    break;
                }
            }
            
            #endregion

            //总结
            //基本概念
            //两两相邻
            //不停比较
            //不停交换
            //比较m轮

            //套路写法
            //两层循环
            //外层轮数
            //内层比较
            //两值比较
            //满足交换

            //如果优化
            //1.比过不比
            //2.加入bool
        }
    }
}