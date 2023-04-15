using System;
namespace DataStructures.Tests
{
	public class PalindromeTests
	{
		[Fact]
		public void TestValidPalindromeWithoutNonAlphaOrUppercase()
		{
            string s = "arriba la birra";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
		}

        [Fact]
        public void TestInvalidPalindromeWithoutNonAlphaOrUppercase()
        {
            string s = "arriba la birr";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidPalindromeWithNonAlpha()
        {
            string s = "arriba &a birra";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidPalindromeWithNonAlphaAndUppercase()
        {
            string s = "arribA la b[rra";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidPalindromeWithUppercase()
        {
            string s = "arribA la birra";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInvalidPalindromeWithNonAlpha()
        {
            string s = "arriba{ la b1rra";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInvalidPalindromeWithNonAlphaAndUppercase()
        {
            string s = "arribA la b1rr}";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInvalidPalindromeWithUppercase()
        {
            string s = "arribA la birr";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestEmptyString()
        {
            string s = "";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringWithCommas()
        {
            string s = "A man, a plan, a canal: Panama";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringWithWhitespaces()
        {
            string s = "race a car";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSingleCharString()
        {
            string s = "a";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestStringWithOnlyNonAlpha()
        {
            string s = ".,";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestValidStringWithOnlyDigits()
        {
            string s = "11";
            bool expected = true;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInvalidStringWithOnlyNonAlpha()
        {
            string s = "12";
            bool expected = false;

            bool actual = Program.IsPalindrome(s);

            Assert.Equal(expected, actual);
        }
    }
}

