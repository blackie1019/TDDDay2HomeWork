namespace TDD.Day2.Homework
{
    #region

    using System.Collections.Generic;

    #endregion

    public interface IShoppingCartStrategy<T>
    {
        decimal DiscountAmount(IList<T> products);
    }
}