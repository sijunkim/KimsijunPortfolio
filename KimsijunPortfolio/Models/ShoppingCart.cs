using KimsijunPortfolio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KimsijunPortfolio.Models
{
    public class ShoppingCart
    {
        private IValueCalculator calc;

        public ShoppingCart(IValueCalculator calculator)
        {
            calc = calculator;
        }

        public IEnumerable<Product> products { get; set; }

        public decimal CalculateProductTotal()
        {
            return calc.ValueProducts(products);
        }
    }
}
