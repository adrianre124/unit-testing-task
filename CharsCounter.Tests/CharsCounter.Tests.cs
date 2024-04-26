namespace CharsCounter.Tests;

[TestFixture]
public class CharsCounterTests
{
    private CharsCounter _charsCounter;

    [SetUp]
    public void Setup()
    {
        _charsCounter = new CharsCounter();
    }

    [Test]
    public void GetConsecutiveLatinCharsCount_StrParameterIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => _charsCounter.GetConsecutiveLatinCharsCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("a", ExpectedResult = 1)]
    [TestCase("abcdef", ExpectedResult = 1)]
    [TestCase("aaabbcccdddeeeffggghhiii", ExpectedResult = 3)]
    public int GetConsecutiveLatinCharsCount_StrParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return _charsCounter.GetConsecutiveLatinCharsCount(str);
    }

    [Test]
    public void GetConsecutiveDigitsCount_StrParameterIsNull_ThrowsException()
    {
        // Act
        Assert.Throws<ArgumentNullException>(() => _charsCounter.GetConsecutiveDigitsCount(null));
    }

    [TestCase("", ExpectedResult = 0)]
    [TestCase("1", ExpectedResult = 1)]
    [TestCase("123456", ExpectedResult = 1)]
    [TestCase("112233445566778899", ExpectedResult = 2)]
    public int GetConsecutiveDigitsCount_StrParameterIsValid_ReturnsResult(string str)
    {
        // Act
        return _charsCounter.GetConsecutiveDigitsCount(str);
    }

}