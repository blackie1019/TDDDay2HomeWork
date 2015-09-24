namespace TDD.Day2.Homework
{
    using System.Collections.Generic;

    public interface IShoppingCartStrategy<T>
    {
        decimal DiscountAmount(IList<T> products);
    }
}