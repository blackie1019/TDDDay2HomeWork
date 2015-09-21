namespace TDD.Day2.Homework
{
    public class BookShoppingCartService : BaseShoppingCartService
    {
        public static BookShoppingCartService NewCart()
        {
            return new BookShoppingCartService();
        }
    }
}