using System.Collections.Generic;
using System.Linq;

namespace TDD.Day2.Homework
{
    public class BaseShoppingCartService
    {
        private readonly List<BaseProduct> _productList;

        public BaseShoppingCartService()
        {
            _productList = new List<BaseProduct>();
        }

        public void AddItem(BaseProduct product)
        {
            _productList.Add(product);
        }

        public decimal CalculateAmount()
        {
            return _productList.Sum(item => item.Price);
        }
    }
}