using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Transactions;
using System.Windows.Markup;

namespace project2
{
    public interface shape   //定义接口，含有计算面积、判断是否合法函数
    {
        bool IsValid();
        double GetArea();
    }
    public class Triangle : shape  //定义三角形类，用两边及一夹角初始化三角形
    {
        private double side1;
        private double side2;
        private double angle;
        public Triangle() { }
        public Triangle(double side1, double side2, double angle)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.angle = angle;
        }
        public double Side1
        {
            get { return side1; }
            set { side1 = value; }
        }
        public double Side2
        {
            get { return side2; }
            set { side2 = value; }
        }
        public double Angle
        {
            get { return angle; }
            set { angle = value; }
        }
        public double GetArea()
        {
            return side1 * side2 * Math.Sin(angle) * 0.5;
        }
        public bool IsValid()
        {
            if (angle <= 0 || angle >= Math.PI || side1 <= 0 || side2 <= 0)
            {
                return false;
            }
            return true;
        }
    }
    public class Rectangle : Triangle  //定义长方形类，继承三角形类，夹角设为PI/2，用长宽初始化长方形
    {
        public Rectangle() { }
        public Rectangle(double length, double height)
        {
            Side1 = length;
            Side2 = height;
            Angle = Math.PI / 2;
        }
        new public double GetArea()
        {
            return Side1 * Side2;
        }
    }
    public class Square : Rectangle //定义正方形类，继承长方形类，夹角设为PI/2，用边长初始化正方形
    {
        public Square(double side)
        {
            Side1 = side;
            Side2 = side;
            Angle = Math.PI / 2;
        }
    }
    public class Circle : shape //定义圆类
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public bool IsValid()
        {
            if (radius <= 0)
            {
                return false;
            }
            return true;
        }
    }
    public class Ram //生成随机数类
    {
        public static double NextDouble(double minValue, double maxValue, int n)    //生成随机浮点数函数，保留n位小数
        {
            Random ran = new Random();
            double randNum = ran.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNum.ToString("f" + n));
        }
    }
    public class Project2
    {
        static void Main(string[] args)     //主函数
        {
            double sumare = 0;
            int count = 0;
            Random rand = new Random();
            while (count < 10)
            {
                switch (rand.Next(0, 5))
                {
                    case 1:
                        Rectangle r = new Rectangle(Ram.NextDouble(0.00, 10.00, 2), Ram.NextDouble(0.00, 10.00, 2));
                        if (r.IsValid())
                        {
                            Console.WriteLine("随机生成一个长方形，长为：{0}，宽为：{1}，面积为：{2}", r.Side1, r.Side2, Math.Round(r.GetArea(), 4));
                            sumare = r.GetArea() + sumare;
                            count++;
                        }
                        break;
                    case 2:
                        Square s = new Square(Ram.NextDouble(0.00, 10.00, 2));
                        if (s.IsValid())
                        {
                            Console.WriteLine("随机生成一个正方形，边长为：{0}，面积为：{1}", s.Side1, Math.Round(s.GetArea(), 4));
                            sumare = s.GetArea() + sumare;
                            count++;
                        }
                        break;
                    case 3:
                        Triangle t = new Triangle(Ram.NextDouble(0.00, 10.00, 2), Ram.NextDouble(0.00, 10.00, 2), Ram.NextDouble(0.00, 10.00, 2));
                        if (t.IsValid())
                        {
                            Console.WriteLine("随机生成一个三角形，一边长为：{0}，另一边长为：{1}，夹角为：{2}，面积为：{3}", t.Side1, t.Side2, t.Angle, Math.Round(t.GetArea(), 4));
                            sumare = t.GetArea() + sumare;
                            count++;
                        }
                        break;
                    case 4:
                        Circle c = new Circle(Ram.NextDouble(0.00, 10.00, 2));
                        if (c.IsValid())
                        {
                            Console.WriteLine("随机生成一个圆形，半径为：{0}，面积为：{1}", c.Radius, Math.Round(c.GetArea(), 4));
                            sumare = c.GetArea() + sumare;
                            count++;
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("十个图形的总面积为：{0}", Math.Round(sumare, 4));
        }
    }
}