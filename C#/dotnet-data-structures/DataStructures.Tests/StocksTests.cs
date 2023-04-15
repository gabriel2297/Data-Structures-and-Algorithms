using System;
namespace DataStructures.Tests
{
	public class StocksTests
	{
		[Fact]
		public void TestStockHighInMiddle()
		{
            int[] prices = { 7, 1, 1, 1234, 1, 1 };
			int expected = 1233;

			int actual = Program.MaxProfit(prices);

			Assert.Equal(expected, actual);
        }

		[Fact]
		public void TestStockHighInStart()
		{
            int[] prices = { 1, 7, 1, 1, 1, 1 };
            int expected = 6;

            int actual = Program.MaxProfit(prices);

            Assert.Equal(expected, actual);
        }

		[Fact]
		public void TestStockHighInEnd()
		{
			int[] prices = { 7, 3, 5, 1, 2, 6 };
            int expected = 5;

            int actual = Program.MaxProfit(prices);

            Assert.Equal(expected, actual);

        }

		[Fact]
		public void TestNoProfit()
		{
			int[] prices = { 7, 6, 4, 3, 1 };
            int expected = 0;

            int actual = Program.MaxProfit(prices);

            Assert.Equal(expected, actual);
        }
    }
}

