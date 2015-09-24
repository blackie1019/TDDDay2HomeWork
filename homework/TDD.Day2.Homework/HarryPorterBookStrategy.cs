
namespace TDD.Day2.Homework
{
    using System.Collections.Generic;
    using System.Linq;

    public class HarryPorterBookStrategy : IShoppingCartStrategy<Book>
    {
        public decimal DiscountAmount(IList<Book> books)
        {
            decimal result = books.Sum(book => book.Price);

            return result;
        }
    }
}
