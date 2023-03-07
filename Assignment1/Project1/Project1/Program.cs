using System.Data;
using System.Text;


namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            double n = 0;
            double m = 0;
            Console.WriteLine("请输入两个数字： ");
            s = Console.ReadLine();
            n = double.Parse(s);
            s = Console.ReadLine();
            m = double.Parse(s);
            Console.WriteLine("请输入一个运算符：");
            s = Console.ReadLine();
            switch (s)
            {
                case "+":
                    Console.WriteLine($"{n} + {m} = {n+m}");
                    break;
                case "-":
                    Console.WriteLine($"{n} - {m} = {n-m}");
                    break;
                case "*":
                    Console.WriteLine($"{n} * {m} = {n*m}");
                    break;
                case "/":
                    Console.WriteLine($"{n} / {m} = {n/m}");
                    break;
            }
        }

    }
}