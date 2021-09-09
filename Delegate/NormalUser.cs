namespace Delegate
{
    public class NormalUser : IUser
    {
        public string Name { get; set; }
        public ShopingCart shopingCart { get; set; } = new();

        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            if (shopingCart.Items.Count > 5)
            {
                return totalPrice * (1 - .3M);
            }
            return totalPrice;
        }
    }
}