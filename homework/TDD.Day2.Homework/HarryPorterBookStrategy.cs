namespace TDD.Day2.Homework
{
    #region

    using System.Collections.Generic;
    using System.Linq;

    #endregion

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

        private void AssignVolumeGroups(List<Book> tempBookGroup, ref List<VolumeGroup> volumeGroups)
        {
            switch (tempBookGroup.Count)
            {
                case 1:
                    volumeGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group1)
                        .Books.AddRange(tempBookGroup);
                    break;
                case 2:
                    volumeGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group2)
                        .Books.AddRange(tempBookGroup);
                    break;
                case 3:
                    volumeGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group3)
                        .Books.AddRange(tempBookGroup);
                    break;
                case 4:
                    volumeGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group4)
                        .Books.AddRange(tempBookGroup);
                    break;
                case 5:
                    volumeGroups.First(x => x.VolumeGroupType == VolumeGroupTypeEnum.Group5)
                        .Books.AddRange(tempBookGroup);
                    break;
            }
        }

        private List<VolumeGroup> SeparateBookGroup(IList<Book> books)
        {
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

            return this.UpdateVolumeGroups(tempBookGroups);
        }

        private List<VolumeGroup> UpdateVolumeGroups(List<List<Book>> tempBookGroups)
        {
            var volumeGroups = new List<VolumeGroup>
                                   {
                                       new VolumeGroup(VolumeGroupTypeEnum.Group1),
                                       new VolumeGroup(VolumeGroupTypeEnum.Group2),
                                       new VolumeGroup(VolumeGroupTypeEnum.Group3),
                                       new VolumeGroup(VolumeGroupTypeEnum.Group4),
                                       new VolumeGroup(VolumeGroupTypeEnum.Group5)
                                   };

            tempBookGroups.ForEach(x => this.AssignVolumeGroups(x, ref volumeGroups));

            return volumeGroups;
        }
    }
}