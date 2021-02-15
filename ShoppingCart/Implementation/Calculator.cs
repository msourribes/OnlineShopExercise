using System.Collections.Generic;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;

namespace ShoppingCart.Implementation
{
    public class Calculator
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IShippingCalculator _shippingCalculator;

        public Calculator(IShippingCalculator shippingCalculator, IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
            _shippingCalculator = shippingCalculator;
        }

        public double Total(IList<CartItem> cart)
        {
            if (cart == null || cart.Count == 0) return 0;

            double runningTotal = 0;
            foreach (var item in cart)
            {
                var product = _productRepository.Get(item.ProductId);
                if (product != null)
                {
                    runningTotal += item.UnitQuantity * product.Price;
                }
            }

            return runningTotal + _shippingCalculator.CalcShipping(runningTotal);
        }
    }
}