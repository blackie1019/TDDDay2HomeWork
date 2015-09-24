
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

            //Five different bookGroups amount
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
            var tempBookGroups = new List<List<string>>();

            foreach (var book in books)
            {
                var isNotExist = true;
                if (tempBookGroups.Count > 0)
                {
                    foreach (var tempBookGroup in tempBookGroups)
                    {
                        if (tempBookGroup.All(name => name != book.BookType))
                        {
                            tempBookGroup.Add(book.BookType);
                            isNotExist = false;
                            break;
                        }
                    }
                }

                if (isNotExist)
                {
                    tempBookGroups.Add(new List<string> { book.BookType });
                }
            }

            foreach (var tempBookGroup in tempBookGroups)
            {
                switch (tempBookGroup.Count)
                {
                    case 1:
                        bookGroups[VolumeGroupEnum.Group1] += 1;
                        break;
                    case 2:
                        bookGroups[VolumeGroupEnum.Group2] += 1;
                        break;
                    case 3:
                        bookGroups[VolumeGroupEnum.Group3] += 1;
                        break;
                    case 4:
                        bookGroups[VolumeGroupEnum.Group4] += 1;
                        break;
                    case 5:
                        bookGroups[VolumeGroupEnum.Group5] += 1;
                        break;
                }
            }

            return bookGroups;
        }
    }
}
