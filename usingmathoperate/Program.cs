/*
 * 輸入整數並取出計算
 * 
 * 
 */

using System;

namespace usingmathoperate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter int number = x");
            int val_x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter int number = y");
            int val_y = int.Parse(Console.ReadLine());
            Console.WriteLine("x + y = {0}", val_x + val_y);
            Console.WriteLine("x - y = {0}", val_x - val_y);
            Console.WriteLine("x * y = {0}", val_x * val_y);
            Console.WriteLine("x / y = {0}", val_x / val_y);
            Console.WriteLine("x % y = {0}", val_x % val_y);

            //號碼決定後面的順序
            Console.WriteLine("x={0} \n y={1} \n x+y={2}", val_x , val_y, val_x+val_y);
            //也可以用一樣的
            Console.WriteLine("x={0} \n x={0} \n y={1}", val_x, val_y);

        }
    }
}
