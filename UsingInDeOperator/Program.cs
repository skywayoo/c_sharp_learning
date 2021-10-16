using System;

namespace UsingInDeOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter int number = x 整數初值");
            int x0 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter int number = 整數要加總的值");
            int add = int.Parse(Console.ReadLine());

            int x = x0;
            Console.WriteLine("int x = x0;, x="+x);
            x = x + add;
            Console.WriteLine("x = x + add;, x="+x);
            x = x0;
            Console.WriteLine("x = x + add;, x="+x);
            x += add;  //效率較好 > x = x + add
            Console.WriteLine("x = x + add;, x="+ x);

            int post;
            x = x0;
            post = x++;
            //x+1但post沒+1;   => post = x ; / x++;
            Console.WriteLine("x++; x={0} / post={1}",x, post);

            int pre;
            x = x0;
            pre = ++x;
            //x & pre 都+1
            Console.WriteLine("++x;, x={0} / pre={1}",x, pre);

            /*
                Enter int number = x 整數初值
                10
                Enter int number = 整數要加總的值
                5
                int x = x0;, x=10
                x = x + add;, x=15
                x = x + add;, x=10
                x = x + add;, x=15
                x++; x=11 / post=10
                ++x;, x=11 / pre=11
            */


        }
    }
}
