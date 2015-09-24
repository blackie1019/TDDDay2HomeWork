using System.Collections.Generic;
using System.Linq;

namespace TDD.Day2.Homework
{
    public class VolumeGroup
    {
        public VolumeGroup(VolumeGroupTypeEnum type)
        {
            this.VolumeGroupType = type;
            this.Books = new List<Book>();
        }

        public List<Book> Books { get; set; }
        public VolumeGroupTypeEnum VolumeGroupType { get; set; }
        public decimal Amount
        {
            get
            {
                return Books.Sum(book => book.Price) * (int)this.VolumeGroupType / 100;
            }
        }
    }
}