namespace DTOS;
public class CartDTO {
    public int Id{get;set;}
    public int UserId{get;set;}
    public IEnumerable<CartItem> cartItems{get;set;}
}