using System;

namespace 面向对象相关_string
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 字符串指定位置获取

            //字符串本质是char数组
            string str = "myj";
            Console.WriteLine(str[1]);
            //转为char数组
            char[] chars = str.ToCharArray();
            Console.WriteLine(chars[0]);

            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
            
            #endregion

            #region 知识点二 字符串拼接

            str = string.Format("{0}{1}", 1, 3333);
            Console.WriteLine(str);


            #endregion

            #region 知识点三 正向查找字符位置

            str = "myj";
            int index = str.IndexOf("m");
            Console.WriteLine(index);

            int index2 = str.IndexOf("k");
            Console.WriteLine(index);
            
            #endregion

            #region 知识点四 反向查找指定字符串的位置

            str = "myjmyj";
            index = str.LastIndexOf("myj");
            Console.WriteLine(index);

            index = str.LastIndexOf("p");
            Console.WriteLine(index);

            #endregion

            #region 知识点五 移除指定位置后的字符

            str = "myj";
            str=str.Remove(1);
            Console.WriteLine(str);
            
            //执行两个参数进行移除
            //参数1 开始位置
            //参数2 字符个数
            str = str.Remove(0, 1);
            Console.WriteLine(str);

            #endregion

            #region 知识点六 替换指定字符串

            str = "immyj";
            str.Replace("myj", "zsy");
            Console.WriteLine(str);
            str=str.Replace("myj", "zsy");
            Console.WriteLine(str);
            #endregion

            #region 知识点七 大小写转换

            str = "afssdasvrbv";
            str=str.ToUpper();
            Console.WriteLine(str);

            str = str.ToLower();
            Console.WriteLine(str);

            #endregion

            #region 知识点八 字符串截取

            str = "myjmyj";
            //截取从指定位置开始之后的字符串
            str=str.Substring(2);
            Console.WriteLine(str);
    
            //参数一 开始位置
            //参数二 指定个数
            //不会自动判断是否越界
            str = str.Substring(2, 2);
            Console.WriteLine(str);

            #endregion

            #region 知识点九 字符串切割

            str = "1,2,3,4,5,6";
            string[] strs = str.Split(',');
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }

            #endregion
        }    
    }
    
}

