using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Day2.Homework.Test
{
    [TestClass]
    public class ShoppingCartTest
    {
        #region Basic
        [TestMethod]
        public void Buy_1_Book_Vol_1()
        {
        }

        [TestMethod]
        public void Buy_1_Book_Vol_2()
        {
            //Scenario: 第一集買了一本，其他都沒買，價格應為100*1=100元

            //Given 第一集買了 1 本
            //And 第二集買了 0 本
            //And 第三集買了 0 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 100 元
        }

        [TestMethod]
        public void Buy_2_Book_Vol_1_And_2()
        {
            //Scenario: 第一集買了一本，第二集也買了一本，價格應為100 * 2 * 0.95 = 190

            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 0 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 190 元
        }

        [TestMethod]
        public void Buy_3_Book_Vol_1_And_2_And_3()
        {
            //Scenario: 一二三集各買了一本，價格應為100 * 3 * 0.9 = 270

            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 270 元
        }

        [TestMethod]
        public void Buy_4_Book_Vol_1_And_2_And_3_And_4()
        {
            //Scenario: 一二三四集各買了一本，價格應為100 * 4 * 0.8 = 320

            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 1 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 320 元
        }

        [TestMethod]
        public void Buy_5_Book_Vol_1_And_2_And_3_And_4_And_5()
        {
            //Scenario: 一次買了整套，一二三四五集各買了一本，價格應為100 * 5 * 0.75 = 375

            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 1 本
            //And 第四集買了 1 本
            //And 第五集買了 1 本
            //When 結帳
            //Then 價格應為 375 元
        }

        [TestMethod]
        public void Buy_4_Book_Vol_1_And_2_And_3_And_3()
        {
            //Scenario: 一二集各買了一本，第三集買了兩本，價格應為100 * 3 * 0.9 + 100 = 370

            //Given 第一集買了 1 本
            //And 第二集買了 1 本
            //And 第三集買了 2 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 370 元
        }

        [TestMethod]
        public void Buy_5_Book_Vol_1_And_2_And_2_And_3_And_3()
        {
            //Scenario: 第一集買了一本，第二三集各買了兩本，價格應為100 * 3 * 0.9 + 100 * 2 * 0.95 = 460

            //Given 第一集買了 1 本
            //And 第二集買了 2 本
            //And 第三集買了 2 本
            //And 第四集買了 0 本
            //And 第五集買了 0 本
            //When 結帳
            //Then 價格應為 460 元
        }

        #endregion

        #region Advanced

        [TestMethod]
        public void Buy_2_Book_Vol_1_And_1()
        {
        }

        [TestMethod]
        public void Buy_3_Book_Vol_1_And_1_And_2()
        {
        }

        #endregion Advanced
    }
}