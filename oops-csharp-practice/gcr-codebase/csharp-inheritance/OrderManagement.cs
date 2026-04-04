using System;
class Order{ // Base Class — Order
    public int OrderId;
    public string OrderDate;
    public Order(int orderId, string orderDate){
    OrderId = orderId;
    OrderDate = orderDate;
    }
    public virtual string GetOrderStatus(){
    return "Order Placed";
    }
}
class ShippedOrder : Order{ // Subclass — ShippedOrder
    public string TrackingNumber;
    public ShippedOrder(int orderId, string orderDate, string trackingNumber): base(orderId, orderDate){
    TrackingNumber = trackingNumber;
    }
    public override string GetOrderStatus(){
    return "Order Shipped";
    }
}
class DeliveredOrder : ShippedOrder{ // Subclass — DeliveredOrder (Multilevel)
    public string DeliveryDate;
    public DeliveredOrder(int orderId, string orderDate,string trackingNumber, string deliveryDate): base(orderId, orderDate, trackingNumber){
    DeliveryDate = deliveryDate;
    }
    public override string GetOrderStatus(){
    return "Order Delivered";
    }
}
class OrderManagement{ // Main Class
    public static void Main(string[] args){
    DeliveredOrder order = new DeliveredOrder(1002,"10-July-2015","KSH345","14-Jun-2005");
    Console.WriteLine($"Order ID: {order.OrderId}");
    Console.WriteLine($"Order Date: {order.OrderDate}");
    Console.WriteLine($"Tracking Number: {order.TrackingNumber}");
    Console.WriteLine($"Delivery Date: {order.DeliveryDate}");
    Console.WriteLine($"Status: {order.GetOrderStatus()}");
    }
}