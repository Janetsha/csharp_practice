using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double num3, num4;
            num3 = 1234.567;
            num4 = -1234.567;
            //以货币方式显示资料_C/c3//
            //C3代表小数后面三位//
            Console.WriteLine("num3 = {0:C3}  num4 = {1:c3} ", num3, num4);

            //Dn or dn 表示显示十进位资料，空白处补0//
            num1 = 123456;
            num2 = -123456;
            Console.WriteLine("num1 = {0:D9} num2 = {0:d3} num2 = {0:D}", num1, num2, num2);
            //Console.ReadLine();

            //E or e表示以指数方式显示资料
            Console.WriteLine("num3 = {0:E} num4 = {0:e2}", num3, num4);
            //Console.ReadLine();

            //Fn or fn 表示以小数来显示资料
            //0：F3中，0代表正数，1代表负数
            Console.WriteLine("num3 = {0:F3} num4 = {1:f3}", num3, num4);
            //Console.ReadLine();

            //G or g 以一般格式显示资料
            Console.WriteLine("num3 = {0:G1} num4 = {0:G3} ", num3, num4);
            //Console.ReadLine();


            //N or n 表示使用千位符号，但是不使用$, N1代表保留至小数点第一位，N or N2都代表小数为后2位//
            Console.WriteLine("num3 = {0:N1} num4 = {0:N3} ", num3, num4);
            //Console.ReadLine();


            //X or x代表以十六进制显示
            Console.WriteLine("num1 = {0:X}  num2 = {1:x} ", num1, num2);
            //Console.ReadLine();


            double myvar1 = 0801234567;
            Console.WriteLine("1." + myvar1.ToString(" (0##) ###-####"));
            //Console.ReadLine();

            double myvar2 = -12345;
            Console.WriteLine("2." + myvar2.ToString("000000"));
            //Console.ReadLine();

        }
    }
}
