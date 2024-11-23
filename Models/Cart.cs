public class Cart {
    public int Id{get;set;}
    public int UserId{get;set;}
    public List<CartItem> CartItems {get;set;}
    
    public void AddToCart(CartItem cart) {
        if (CartItems is not null){
            this.CartItems.Add(cart);
        }
        else {
            CartItems = new List<CartItem>();
            CartItems.Add(cart);
        }
    }
}
