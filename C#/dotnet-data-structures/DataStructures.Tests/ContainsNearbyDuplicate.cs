using System;
namespace DataStructures.Tests
{
	public class ContainsNearbyDuplicate
	{
		[Fact]
		public void TestListWithDups()
		{
			int[] nums = { 1, 2, 3, 1 };
			int k = 3;
			bool expected = true;

			bool actual = Program.ContainsNearbyDuplicate(nums, k);

			Assert.Equal(expected, actual);
		}

		[Fact]
		public void TestListWithDups2()
		{
			int[] nums = { 1, 0, 1, 1 };
			int k = 1;
            bool expected = true;

            bool actual = Program.ContainsNearbyDuplicate(nums, k);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestListWithNoDups()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;
            bool expected = false;

            bool actual = Program.ContainsNearbyDuplicate(nums, k);

            Assert.Equal(expected, actual);
        }
    }
}

