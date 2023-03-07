namespace project4
{
    class Project4
    {
        bool isSame(int m, int n, int[,] a, int i0, int j0)
        {
            int i = i0;
            int j = j0;

            while (i < m - 1 && j < n - 1)
            {
                if (a[i + 1, j + 1] != a[i, j])
                {
                    return false;
                }
                i++;
                j++;
            }
            return true;
        }
        bool isToplitz(int m, int n, int[,] a)
        {
            for (int i = 0; i < m; i++)
            {
                if (!isSame(m, n, a, i, 0))
                {
                    return false;
                }
            }
            for (int j = 0; j < n; j++)
            {
                if (!isSame(m, n, a, 0, j))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Project4 p4 = new Project4();
            int[,] a = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            if (p4.isToplitz(3, 4, a))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}