public class Cart {
    public int Id{get;set;}
    public int UserId{get;set;}
    private IList<CartItem> cartItems;
    public void AddToCart(CartItem cart) {
        this.cartItems.Add(cart);
    }
}
