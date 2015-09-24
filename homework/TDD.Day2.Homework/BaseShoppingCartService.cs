namespace TDD.Day2.Homework
{
    #region

    using System.Collections.Generic;

    #endregion

    public class BaseShoppingCartService<T>
    {
        public BaseShoppingCartService(IShoppingCartStrategy<T> strategy)
        {
            this.Products = new List<T>();
            this.ShoppingCartStrategy = strategy;
        }

        private IList<T> Products { get; set; }

        private IShoppingCartStrategy<T> ShoppingCartStrategy { get; set; }

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