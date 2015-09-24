namespace TDD.Day2.Homework
{
    using System.Collections.Generic;
    using System.Linq;

    public class HarryPorterBookStrategy : IShoppingCartStrategy<Book>
    {
        public decimal DiscountAmount(IList<Book> books)
        {
            // decimal result = books.Sum(book => book.Price);
            var bookGroups = this.SeparateBookGroup(books);

            // Five different bookGroups amount
            var result = bookGroups.Sum(bookGroup => bookGroup.Amount);

            return result;
        }

        private List<VolumeGroup> SeparateBookGroup(IList<Book> books)
        {
            var bookGroups = new List<VolumeGroup>
                                 {
                                     new VolumeGroup(VolumeGroupTypeEnum.Group1),
                                     new VolumeGroup(VolumeGroupTypeEnum.Group2),
                                     new VolumeGroup(VolumeGroupTypeEnum.Group3),
                                     new VolumeGroup(VolumeGroupTypeEnum.Group4),
                                     new VolumeGroup(VolumeGroupTypeEnum.Group5)
                                 };

            var tempBookGroups = new List<List<Book>>();

            foreach (var book in books)
            {
                var isNotExist = true;
                if (tempBookGroups.Count > 0)
                {
                    foreach (var tempBookGroup in tempBookGroups)
                    {
                        if (tempBookGroup.All(x => x.BookType != book.BookType))
                        {
                            tempBookGroup.Add(book);
                            isNotExist = false;
                            break;
                        }
                    }
                }

                if (isNotExist)
                {
                    tempBookGroups.Add(new List<Book> { book });
                }
            }

            foreach (var tempBookGroup in tempBookGroups)
            {
                switch (tempBookGroup.Count)
                {
                    case 1:
                        bookGroups.First(x=>x.VolumeGroupType==VolumeGroupTypeEnum.Group1).Books.AddRange(tempBookGroup);
                        break;

                    case 2:
                        bookGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group2).Books.AddRange(tempBookGroup);
                        break;

                    case 3:
                        bookGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group3).Books.AddRange(tempBookGroup);
                        break;

                    case 4:
                        bookGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group4).Books.AddRange(tempBookGroup);
                        break;

                    case 5:
                        bookGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group5).Books.AddRange(tempBookGroup);
                        break;
                }
            }

            return bookGroups;
        }
    }
}