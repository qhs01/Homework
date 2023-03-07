namespace project3
{
    class Project3
    {
        static void Main(string[] args)
        {
            int[] a = new int[101];
            int[] b = new int[101];
            for (int i = 0; i <= 100; i++)
            {
                a[i] = i;
                b[i] = 1;
            }
            for (int num = 2; num <= 10; num++)
            {
                for (int i = 1; i <= 100; i++)
                {
                    if (i % num == 0)
                    {
                        b[i] = 0;
                    }
                }
            }
            b[1] = 0; b[2] = 1; b[3] = 1; b[5] = 1; b[7] = 1;
            Console.Write("2-100以内的素数为：");
            for (int i = 1; i <= 100; i++)
            {
                if (b[i] == 1)
                {
                    Console.Write($"{a[i]} ");
                }
            }
        }
    }
}
