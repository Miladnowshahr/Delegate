namespace Delegate
{
    public class GoldenUser : IUser
    {
        public string Name { get; set; }
        public ShopingCart shopingCart { get; set; } = new();

        public decimal GetDiscountedPrice(decimal totalPrice)
        {
            return totalPrice * (1 - 0.3M);
        }
    }
}