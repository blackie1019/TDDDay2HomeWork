namespace TDD.Day2.Homework
{
    using System.Collections.Generic;
    using System.Linq;

    public class BaseShoppingCartService<T>
    {
        public BaseShoppingCartService(IShoppingCartStrategy<T> strategy)
        {
            this.Products = new List<T>();
            this.ShoppingCartStrategy = strategy;
        }

        private IShoppingCartStrategy<T> ShoppingCartStrategy { get; set; }

        private IList<T> Products { get; set; } 

        public void AddItem(T product)
        {
            this.Products.Add(product);
        }

        public decimal CalculateAmount()
        {
            return this.ShoppingCartStrategy.DiscountAmount(this.Products);
        }
    }
}