using System;
namespace DataStructures.Tests
{
	public class ContainsDuplicateTests
	{
		[Fact]
		public void TestListWithDuplicates()
		{
			int[] nums = { 1, 2, 3, 1 };
			bool expected = true;

			bool actual = Program.ContainsDuplicate(nums);

			Assert.Equal(expected, actual);
		}

        [Fact]
        public void TestListWithNoDuplicates()
        {
            int[] nums = { 1, 2, 3, 4 };
            bool expected = false;

            bool actual = Program.ContainsDuplicate(nums);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLargeListWithDuplicates()
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };
            bool expected = true;

            bool actual = Program.ContainsDuplicate(nums);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestLargeListNoDuplicates()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8 };
            bool expected = false;

            bool actual = Program.ContainsDuplicate(nums);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmptyList()
        {
            int[] nums = { };
            bool expected = false;

            bool actual = Program.ContainsDuplicate(nums);

            Assert.Equal(expected, actual);
        }
    }
}

