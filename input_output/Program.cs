/*
 * 測試輸入與輸出
 * 
 */


using System;

namespace input_output
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name 輸入你的名字拉");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("殺小拉 你叫"+name+"喔？");
        }
    }
}
