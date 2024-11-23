public class Order {
    public int Id{get;set;}
    public int UserId{get;set;}
    public DateTime OrderDate{get;set;}
    public int TotalAmount =>OrderItems.Sum(o=>o.Quantity);
    public decimal TotalPrice => OrderItems.Sum(o=>o.Quantity*o.Price);
    public List<OrderItem> OrderItems{get;set;}
}