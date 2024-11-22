using System.ComponentModel.DataAnnotations.Schema;

public class OrderItem {
    public int Id{get;set;}
    public int OrderId{get;set;}
    [ForeignKey("OrderId")]
    public int BookId{get;set;}
    [ForeignKey("BookId")]
    public int Quantity{get;set;}
    public decimal Price{get;set;}
    public Order Order{get;set;}
    public Book Book{get;set;}
}