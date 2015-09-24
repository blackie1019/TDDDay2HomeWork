namespace TDD.Day2.Homework
{
    public class BookShoppingCartService : BaseShoppingCartService<Book>
    {
        public BookShoppingCartService(HarryPorterBookStrategy strategy)
            : base(strategy)
        {
        }

        public static BookShoppingCartService NewCart()
        {
            return new BookShoppingCartService(new HarryPorterBookStrategy());
        }
    }
}