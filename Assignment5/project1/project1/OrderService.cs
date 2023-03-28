using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class OrderService
    {
        public List<Order> order = new List<Order>();
        public OrderService()
        {
        }
        public void ShowOrder()             //展示订单表中所有的订单
        {
            foreach (Order o in this.order)
            {
                Console.WriteLine(o);
            }
        }
        public void addOrder()              //增加订单
        {
            try
            {
                bool next = true;
                while (next)
                {
                    Console.WriteLine("请输入订单号：");
                    string Order_Id = Console.ReadLine();
                    Console.WriteLine("请输入订单名：");
                    string Order_Name = Console.ReadLine();
                    bool same = false;
                    foreach (Order m in this.order)
                    {
                        if (m.Order_Id == Order_Id || m.Order_Name == Order_Name) same = true;
                    }
                    if (same)
                    {
                        Console.WriteLine("订单号或订单名重复");
                        Console.WriteLine("-----------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("请输入客户姓名：");
                        string Client_Name = Console.ReadLine();
                        Console.WriteLine("请输入客户地址：");
                        string Client_Location = Console.ReadLine();
                        Console.WriteLine("请输入客户电话：");
                        string Client_Number = Console.ReadLine();
                        Console.WriteLine("请输入货物名：");
                        string Goods_Name = Console.ReadLine();
                        Console.WriteLine("请输入货物数量：");
                        int Goods_Amount = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("请输入货物单价：");
                        double Goods_Price = Convert.ToDouble(Console.ReadLine());

                        Order o = new Order(Order_Id, Order_Name, new OrderDetails(new Client(Client_Name, Client_Location, Client_Number), new Goods(Goods_Name, Goods_Amount, Goods_Price)));
                        order.Add(o);
                        Console.WriteLine("添加成功");
                        Console.WriteLine("-----------------------------------");

                        Console.WriteLine("是否继续添加订单（是1否0）：");
                        string x = Console.ReadLine();
                        if (x == "0") { next = false; }
                        else { continue; }
                    }
                }

            }
            catch
            {
                Console.WriteLine("添加订单错误");
                Console.WriteLine("-----------------------------------");
            }
        }
        public void deleteOrder()           //删除订单
        {
            try
            {
                bool next = true;
                while (next)
                {
                    Console.WriteLine("请输入要删除的订单号：");
                    string id = Console.ReadLine();
                    int index = 0;
                    foreach (Order o in this.order)
                    {
                        if (o.Order_Id == id) index = this.order.IndexOf(o);
                    }
                    this.order.RemoveAt(index);
                    Console.WriteLine("删除成功");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("是否继续删除订单（是1否0）：");
                    string x = Console.ReadLine();
                    if (x == "0") { next = false; }
                    else { continue; }
                }
            }
            catch
            {
                Console.WriteLine("删除订单错误");
                Console.WriteLine("-----------------------------------");
            }
        }
        public void selectOrder()           //查询订单
        {
            try
            {
                bool next = true;
                while (next)
                {
                    Console.WriteLine("请输入要查询的内容（输入1为订单号、2为货物名称、3为客户名称、0退出此功能）：");
                    int choose = Convert.ToInt32(Console.ReadLine());
                    switch (choose)
                    {
                        case 0:
                            Console.WriteLine("退出查询订单功能");
                            Console.WriteLine("-----------------------------------");
                            next = false;
                            break;
                        case 1:
                            Console.WriteLine("请输入要查询的订单号：");
                            string id = Console.ReadLine();
                            var query1 = from o in order
                                         where o.Order_Id == id
                                         orderby o.orderdetails.SumPrince
                                         select o;
                            Console.WriteLine("按订单号的查询结果为（按订单总金额降序排序）：");
                            foreach (Order q in query1)
                            {
                                Console.WriteLine(q);
                            }
                            Console.WriteLine("-----------------------------------");
                            break;
                        case 2:
                            Console.WriteLine("请输入要查询的货物名称：");
                            string goods_name = Console.ReadLine();
                            var query2 = from o in order
                                         where o.orderdetails.goods.Goods_Name == goods_name
                                         orderby o.orderdetails.SumPrince
                                         select o;
                            Console.WriteLine("按货物名的查询结果为（按订单总金额降序排序）：");
                            foreach (Order q in query2)
                            {
                                Console.WriteLine(q);
                            }
                            Console.WriteLine("-----------------------------------");
                            break;
                        case 3:
                            Console.WriteLine("请输入要查询的客户名称：");
                            string client_name = Console.ReadLine();
                            var query3 = from o in order
                                         where o.orderdetails.client.Client_Name == client_name
                                         orderby o.orderdetails.SumPrince
                                         select o;
                            Console.WriteLine("按客户名的查询结果为（按订单总金额降序排序）：");
                            foreach (Order q in query3)
                            {
                                Console.WriteLine(q);
                            }
                            Console.WriteLine("-----------------------------------");
                            break;
                    }
                }
            }
            catch
            {
                Console.WriteLine("查询订单错误");
                Console.WriteLine("-----------------------------------");
            }
        }
        public void orderOrder()            //排序订单
        {
            try
            {
                Console.WriteLine("按订单号排序：");
                var query = order.OrderBy(o => o.Order_Id);
                foreach (Order o in query)
                {
                    Console.WriteLine(o);
                }
            }
            catch
            {
                Console.WriteLine("排序订单错误");
                Console.WriteLine("-----------------------------------");
            }
        }
        public void changeOrder()           //修改订单
        {
            try
            {
                bool next = true;
                while (next)
                {
                    Console.WriteLine("请输入要修改的订单号：");
                    string id = Console.ReadLine();
                    int index = 0;
                    foreach (Order o in this.order)
                    {
                        if (o.Order_Id == id) index = this.order.IndexOf(o);
                    }
                    Console.WriteLine("请输入修改后的客户姓名：");
                    string Client_Name = Console.ReadLine();
                    Console.WriteLine("请输入修改后的客户地址：");
                    string Client_Location = Console.ReadLine();
                    Console.WriteLine("请输入修改后的客户电话：");
                    string Client_Number = Console.ReadLine();
                    Console.WriteLine("请输入修改后的货物名：");
                    string Goods_Name = Console.ReadLine();
                    Console.WriteLine("请输入修改后的货物数量：");
                    int Goods_Amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("请输入修改后的货物单价：");
                    double Goods_Price = Convert.ToDouble(Console.ReadLine());

                    Order a = new Order(order[index].Order_Id, order[index].Order_Name, new OrderDetails(new Client(Client_Name, Client_Location, Client_Number), new Goods(Goods_Name, Goods_Amount, Goods_Price)));
                    order[index] = a;

                    Console.WriteLine("修改成功");
                    Console.WriteLine("-----------------------------------");
                    Console.WriteLine("是否继续修改订单（是1否0）：");
                    string x = Console.ReadLine();
                    if (x == "0") { next = false; }
                    else { continue; }
                }
            }
            catch
            {
                Console.WriteLine("修改订单错误");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
