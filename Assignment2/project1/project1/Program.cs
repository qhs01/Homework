using System.Net.Mail;
namespace project1
{
    class Project1
    {
        bool Prime(int num)
        {
            if (num == 2)
            {
                return true;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        void PrimeFactor(int num)
        {
            Console.WriteLine($"{num}的素数因子有：");
            for (int i = 2; i <= num; i++)
            {
                if (Prime(i) && num % i == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            string s = "";
            s = Console.ReadLine();
            int i = 0;
            i = Int32.Parse(s);
            Project1 project1 = new Project1();
            project1.PrimeFactor(i);
        }
    }
}