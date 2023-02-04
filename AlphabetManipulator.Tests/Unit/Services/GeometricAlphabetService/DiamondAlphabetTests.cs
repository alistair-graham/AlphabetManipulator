using Xunit;
using Moq;
using AlphabetManipulator.Services.GeometricAlphabetService;

namespace AlphabetManipulator.Tests.Unit.Services.GeometricAlphabetService;

public class DiamondAlphabetWriterTests
{
    [Fact]
    public void FromChar_LetterA_ReturnsA()
    {
        const char LETTER_A = 'A';

        var stubLogger = Mock.Of<ILogger<DiamondAlphabet>>();
        var diamondAlphabet = new DiamondAlphabet(stubLogger);

        var diamond = diamondAlphabet.CreateFromChar(LETTER_A);

        Assert.Equal("A", diamond);
    }

    [Fact]
    public void FromChar_LetterB_ReturnsCorrectDiamond()
    {
        const char LETTER_A = 'A';

        var stubLogger = Mock.Of<ILogger<DiamondAlphabet>>();
        var diamondAlphabet = new DiamondAlphabet(stubLogger);

        var diamond = diamondAlphabet.CreateFromChar(LETTER_A);

        var expectedDiamond = @" A 
B B
 A ";
        Assert.Equal(expectedDiamond, diamond);
    }
}
