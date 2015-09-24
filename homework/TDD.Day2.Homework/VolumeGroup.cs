namespace TDD.Day2.Homework
{
    #region

    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class VolumeGroup
    {
        public VolumeGroup(VolumeGroupTypeEnum type)
        {
            this.VolumeGroupType = type;
            this.Books = new List<Book>();
        }

        public decimal Amount
        {
            get
            {
                return this.Books.Sum(book => book.Price) * (int)this.VolumeGroupType / 100;
            }
        }

        public List<Book> Books { get; set; }

        public VolumeGroupTypeEnum VolumeGroupType { get; set; }
    }
}