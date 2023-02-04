using DiamondKata.Services.AlphabetWriters;
using Xunit;
using Moq;
using Microsoft.Extensions.Logging;

namespace DiamondKata.Tests;

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
