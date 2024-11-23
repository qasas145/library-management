
public class OrderRepository : IRepository<Order>
{
    List<Order> orders = new List<Order>
    {
        new Order
        {
            Id = 1,
            UserId = 101,
            OrderDate = new DateTime(2024, 11, 20),
            OrderItems = new List<OrderItem>
            {
                new OrderItem { OrderId = 1, BookId = 1, Quantity = 1, Price = 50 },
                new OrderItem { OrderId = 1, BookId = 2, Quantity = 2, Price = 25 }
            }
        },
        new Order
        {
            Id = 2,
            UserId = 102,
            OrderDate = new DateTime(2024, 11, 21),
            OrderItems = new List<OrderItem>
            {
                new OrderItem { OrderId = 2, BookId = 3, Quantity = 1, Price = 75 },
                new OrderItem { OrderId = 2, BookId = 1, Quantity = 1, Price = 125 }
            }
        }
    };
    public void Add(Order obj)
    {
        orders.Add(obj);
    }

    public void Delete(int id)
    {
        orders.Remove(orders.FirstOrDefault(o=>o.Id == id));
    }

    public IEnumerable<Order> GetAll()
    {
        return this.orders;
    }

    public Order GetById(int id)
    {
        return this.orders.FirstOrDefault(o=>o.Id == id);
    }

    public void Update(Order obj)
    {
        throw new NotImplementedException();
    }
}