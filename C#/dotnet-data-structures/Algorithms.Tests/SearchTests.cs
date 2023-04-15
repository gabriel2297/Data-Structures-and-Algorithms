namespace Algorithms.Tests;

public class SearchTests
{
    [Fact]
    public void TestWhenNumberIsAvailable()
    {
        // Arrange
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 9;
        int expected = 4;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenNumberIsNotAvailable()
    {
        // Arrange
        int[] nums = { -1, 0, 3, 5, 9, 12 };
        int target = 2;
        int expected = -1;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenUnavailableNumberIsLessThanAll()
    {
        // Arrange
        int[] nums = { 2, 5 };
        int target = 0;
        int expected = -1;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenUnavailableNumberIsGreaterThanAll()
    {
        // Arrange
        int[] nums = { 2, 5 };
        int target = 7;
        int expected = -1;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenListIsEmpty()
    {
        // Arrange
        int[] nums = {};
        int target = 7;
        int expected = -1;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenAvailableNumberIsFirstInList()
    {
        // Arrange
        int[] nums = { 2, 5 };
        int target = 2;
        int expected = 0;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenAvailableNumberIsLastInList()
    {
        // Arrange
        int[] nums = { 2, 5, 8 };
        int target = 8;
        int expected = 2;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenAvailableNumberIsOnlyNumber()
    {
        // Arrange
        int[] nums = { 1 };
        int target = 1;
        int expected = 0;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestWhenNotAvailableNumberIsOnlyNumber()
    {
        // Arrange
        int[] nums = { 1 };
        int target = 2;
        int expected = -1;

        // Act
        int actual = Program.Search(nums, target);

        // Assert
        Assert.Equal(expected, actual);
    }
}