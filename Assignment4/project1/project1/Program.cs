using System.Security.Cryptography.X509Certificates;

namespace project1 { 
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public T Sum
        {
            get; set;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action <Node<T>> action)
        {
            Node<T> t=head;
            while (t != null)
            {
                action(t);
                t = t.Next;
            }
        }
    }
    public class Test
    {
        public static void Main()
        {
            GenericList<int> Glist = new GenericList<int>();
            int sum = 0;
            int max = 0;
            int min = 0x7fffffff;
            Glist.Add(8);//创建链表
            Glist.Add(3);
            Glist.Add(-5);
            Glist.Add(-2); 
            Glist.Add(1);

            Console.Write("链表的元素为：");//逐个输出链表元素
            Glist.ForEach(n => Console.Write(n.Data+"->"));
            Console.WriteLine();

            Glist.ForEach(n => sum+=n.Data);//计算链表元素之和并输出
            Console.Write("链表的元素的和为："+sum);
            Console.WriteLine();

            Glist.ForEach(n => max = max < n.Data ? n.Data : max);//计算链表元素的最大值并输出
            Console.Write("链表元素的最大值为：" + max);
            Console.WriteLine();

            Glist.ForEach(n => min = min < n.Data ? min : n.Data);//计算链表元素的最小值并输出
            Console.Write("链表元素的最小值为：" + min);

        }
    }
}