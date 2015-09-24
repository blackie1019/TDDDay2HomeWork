
namespace TDD.Day2.Homework
{
    using System.Collections.Generic;
    using System.Linq;

    public class HarryPorterBookStrategy : IShoppingCartStrategy<Book>
    {
        public decimal DiscountAmount(IList<Book> books)
        {
            // decimal result = books.Sum(book => book.Price);
            decimal result = 0;
            var bookGroups = this.SeparateBookGroup(books);

            return result;
        }

        private Dictionary<string, int> SeparateBookGroup(IList<Book> books)
        {
            var bookGroups = new Dictionary<string, int>();
            foreach (var book in books)
            {
                if (bookGroups.Any(x => x.Key == book.BookType))
                {
                    var bookGroup = bookGroups.First(x => x.Key == book.BookType);
                    bookGroups[book.BookType] = bookGroup.Value + 1;
                }
                else
                {
                    bookGroups.Add(book.BookType, 1);
                }
            }
            return bookGroups;
        }
    }
}
