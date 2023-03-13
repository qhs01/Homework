using System.Data;
using System.Drawing;
using System.Security.Principal;
using System.Text;
using System.Transactions;
using System.Windows.Markup;

namespace project1
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
}