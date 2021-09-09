using System;
using System.Collections.Generic;

namespace Delegate
{
    public class ShopingCart
    {
        public List<ProductModel> Items { get; set; } = new();

        public delegate decimal ComputeDiscountPrice(decimal totalPrice);

        public delegate void PrintDiscountValue(decimal totalPrice, decimal finalPrice);

        public decimal GetFinalPrice(Func<List<ProductModel>, decimal> calculateTotal,
            ComputeDiscountPrice totalPrice,
            Action<decimal, decimal> displayDiscount)
        {
            var sum = calculateTotal(Items);
            var finalPrice = totalPrice(sum);
            displayDiscount(sum, finalPrice);
            return finalPrice;
        }
    }
}