using Xunit;
using Moq;
using AlphabetManipulator.Services.AlphabetWriters;

namespace AlphabetManipulator.Tests.Unit.Services.AlphabetWriters;

public class DiamondAlphabetWriterTests
{
    [Fact]
    public void FromChar_LetterA_ReturnsA()
    {
        // Arrange
        const char LETTER_A = 'a';

        var stubLogger = Mock.Of<ILogger<DiamondAlphabet>>();
        var diamondAlphabet = new DiamondAlphabet(stubLogger);

        var diamond = diamondAlphabet.CreateFromChar(LETTER_A);

        Assert.Equal("A", diamond);
    }
}
