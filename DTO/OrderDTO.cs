namespace DTOS;
public class OrderDTO {
    public int Id{get;set;}
    public int UserId{get;set;}
    
    public DateTime OrderDate{get;set;}
    public int TotalAmount{get;set;}
    public decimal TotalPrice{get;set;}
}