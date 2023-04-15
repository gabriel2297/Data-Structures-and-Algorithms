namespace DataStructures.Tests;

public class ParenthesisTests
{
	[Fact]
	public void TestValidParenthesis()
	{
		var test = "()[]{}";
		var expected = true;

		var actual = Program.IsValid(test);

		Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestInvalidParenthesis()
    {
        var test = "(]";
        var expected = false;

        var actual = Program.IsValid(test);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMixedParenthesis()
    {
        var test = "(())[{}]";
        var expected = true;

        var actual = Program.IsValid(test);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSingleParenthesis()
    {
        var test = "(";
        var expected = false;

        var actual = Program.IsValid(test);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestOnlyOpeningParenthesis()
    {
        var test = "((";
        var expected = false;

        var actual = Program.IsValid(test);

        Assert.Equal(expected, actual);
    }
}

