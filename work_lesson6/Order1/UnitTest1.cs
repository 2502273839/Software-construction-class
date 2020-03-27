﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using work_lesson5;


namespace TestClass
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTest()
        {
            List<Order> lists;
            lists = InitOrder.CreatOrders();
            OrderService orderService=new OrderService(lists);
            orderService.deleteOrder("898");
            orderService.showOrders();

        }
        [TestMethod]
        public void WholeTest()
        {
            Console.WriteLine("测试方法正在执行！");

            List<OrderItem> orderItems1 = new List<OrderItem>();
            orderItems1.Add(new OrderItem("胡椒", 25.8, 10));
            orderItems1.Add(new OrderItem("牛奶", 15.8, 12));
            orderItems1.Add(new OrderItem("炸鸡", 44.2, 8));

            List<OrderItem> orderItems2 = new List<OrderItem>();
            orderItems2.Add(new OrderItem("土豆", 25.8, 10));
            orderItems2.Add(new OrderItem("番茄", 15.8, 12));
            orderItems2.Add(new OrderItem("黑人", 44.2, 8));

            List<OrderItem> orderItems3 = new List<OrderItem>();
            orderItems3.Add(new OrderItem("手机", 25.8, 10));
            orderItems3.Add(new OrderItem("电脑", 15.8, 12));
            orderItems3.Add(new OrderItem("平板", 44.2, 8));

            List<OrderItem> orderItems4 = new List<OrderItem>();
            orderItems4.Add(new OrderItem("a", 5.8, 10));
            orderItems4.Add(new OrderItem("b", 5.8, 12));
            orderItems4.Add(new OrderItem("c", 4.2, 8));

            Order order1 = new Order("Trump", orderItems1, "898");

            Order order2 = new Order("Donald", orderItems2, "787");

            Order order3 = new Order("Jobs", orderItems3, "999");

            Order order4 = new Order("Jobs", orderItems4, "323");

            List<Order> list = new List<Order>{ order1, order2, order3, order4 };
            OrderService service = new OrderService(list);

            service.addOrder(order1);
            service.addOrder(order2);
            service.addOrder(order3);
            service.addOrder(order4);
            service.addOrder(order3);

            service.sortOrders();

            service.showOrders();

            Console.WriteLine("查询ByNo：-------------------------");
            service.queryByNumber("898");
            Console.WriteLine("查询ByName：-------------------------");
            service.queryByName("Jobs");
            Console.WriteLine("查询ByProduct：---------------------");
            service.queryByProduct("手机");


            service.serialize(service.orders);

            service.deserialize();


        }
    }
}
