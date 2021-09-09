namespace Delegate
{
    public interface IUser
    {
        string Name { get; set; }

        ShopingCart shopingCart { get; set; }

        decimal GetDiscountedPrice(decimal totalPrice);
    }
}