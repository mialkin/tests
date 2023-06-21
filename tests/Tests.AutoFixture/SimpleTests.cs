namespace Tests.AutoFixture;

public class SimpleTests
{
    [Theory]
    [InlineData("one")]
    public void Test1(string value)
    {
        Assert.Equal("one", value);
    }
}