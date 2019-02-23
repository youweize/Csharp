using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pls input your first num");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("pls the next one");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the ans: {1} * {2} = {0}",num1 * num2,num1,num2);
            Console.ReadLine();
        }
    }
}
