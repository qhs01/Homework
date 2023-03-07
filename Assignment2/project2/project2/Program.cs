namespace project2
{
    class Project2
    {
        int returnMax(int[] a)
        {
            int length = a.GetLength(0);
            int max = a[0];
            for (int i = 1; i < length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        int returnMin(int[] a)
        {
            int length = a.GetLength(0);
            int min = a[0];
            for (int i = 1; i < length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }
        int returnSum(int[] a)
        {
            int length = a.GetLength(0);
            int sum = 0;
            for (int i = 1; i < length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        decimal returnAve(int[] a)
        {
            int length = a.GetLength(0);
            int sum = 0;
            for (int i = 1; i < length; i++)
            {
                sum += a[i];
            }
            decimal ave = (decimal)sum / length;
            return ave;
        }
        static void Main(string[] args)
        {
            Project2 p2 = new Project2();
            int[] a = { 5, 6, 8 };
            Console.WriteLine($"数组的最大值为：{p2.returnMax(a)}");
            Console.WriteLine($"数组的最小值为：{p2.returnMin(a)}");
            Console.WriteLine($"数组的总和为：{p2.returnSum(a)}");
            Console.WriteLine($"数组的平均值为：{p2.returnAve(a)}");
        }
    }
}