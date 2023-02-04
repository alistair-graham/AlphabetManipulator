using DiamondKata.Services.AlphabetWriters;
using Xunit;
using Moq;

namespace DiamondKata.Tests.Unit.Services.AlphabetWriters;

public class DiamondAlphabetWriterTests
{
    [Fact]
    public void FromChar_LetterA_ReturnsA()
    {
        var stubLogger = Mock.Of<ILogger<DiamondAlphabetWriter>>();
        var diamondAlphabetWriter = new DiamondAlphabetWriter(stubLogger);
        const char LETTER_A = 'a';

        diamondAlphabetWriter.FromChar(LETTER_A, out var output);


        Assert.Equal("A", output);
    }
}
