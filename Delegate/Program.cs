using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUser normalUser = new NormalUser() { Name = "Milad" };
            IUser goldenUser = new GoldenUser() { Name = "Saeideh" };

            normalUser.shopingCart = FillShopingCart();
            goldenUser.shopingCart = FillShopingCart();

            decimal normalUserFinalPrice = normalUser.shopingCart.GetFinalPrice(ComputeTotal, normalUser.GetDiscountedPrice,
                (totalPrice, finalPrice) => Print(totalPrice, finalPrice));

            Console.WriteLine($"Normal User: {normalUserFinalPrice:c2}");

            decimal goldenUserFinalPrice = goldenUser.shopingCart.GetFinalPrice(ComputeTotal, goldenUser.GetDiscountedPrice,
                (totalPrice, finalPrice) => Console.WriteLine($"Your discount is :{totalPrice - finalPrice}"));

            Console.WriteLine($"Golden User: {goldenUserFinalPrice:c2}");
        }

        private static decimal ComputeTotal(List<ProductModel> item)
        {
            return item.Sum(x => x.Price);
        }

        private static void Print(decimal totalprice, decimal disPrice)
        {
            Console.WriteLine($"your discount is :{(totalprice - disPrice)}");
        }

        private static ShopingCart FillShopingCart()
        {
            ShopingCart cart = new();
            cart.Items.Add(new ProductModel { Name = "Tshirt1", Price = 10.5M });
            cart.Items.Add(new ProductModel { Name = "Tshirt1", Price = 10.5M });
            cart.Items.Add(new ProductModel { Name = "Tshirt1", Price = 10.5M });
            cart.Items.Add(new ProductModel { Name = "Tshirt1", Price = 10.5M });
            return cart;
        }
    }
}