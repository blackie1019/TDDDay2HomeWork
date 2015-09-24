
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

            //Five different books amount
            foreach (var bookGroup in bookGroups)
            {
                result += ((int)bookGroup.Key) * bookGroup.Value;
            }
               
            return result;
        }

        private Dictionary<VolumeGroupEnum, int> SeparateBookGroup(IList<Book> books)
        {
            var bookGroups = new Dictionary<VolumeGroupEnum, int>
                                 {
                                     { VolumeGroupEnum.Group1, 0 },
                                     { VolumeGroupEnum.Group2, 0 },
                                     { VolumeGroupEnum.Group3, 0 },
                                     { VolumeGroupEnum.Group4, 0 },
                                     { VolumeGroupEnum.Group5, 0 }
                                 };

            foreach (var book in books)
            {
                bookGroups[VolumeGroupEnum.Group1] += 1;
            }

            // VolumeGroupEnum.Group1;
            // VolumeGroupEnum.Group2;
            // VolumeGroupEnum.Group3;
            // VolumeGroupEnum.Group4;
            // VolumeGroupEnum.Group5;


            return bookGroups;
        }
    }
}
