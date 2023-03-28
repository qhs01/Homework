using project1;

public class project5
{
    public static void Main()
    {
        OrderService os = new OrderService();
        os.addOrder();     //添加订单测试
        os.ShowOrder();

        os.changeOrder();  //修改订单测试
        os.ShowOrder();

        os.deleteOrder();  //删除订单测试
        os.ShowOrder();

        os.orderOrder();   //排序订单测试
        os.selectOrder();  //查找订单测试
    }
}
