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
    public void FromChar_LetterZ_ReturnsCorrectDiamond()
    {
        const char LETTER_Z = 'Z';

        var stubLogger = Mock.Of<ILogger<DiamondAlphabet>>();
        var diamondAlphabet = new DiamondAlphabet(stubLogger);

        var diamond = diamondAlphabet.CreateFromChar(LETTER_Z);

        var expectedDiamond = "                         A                         \n                        B B                        \n                       C   C                       \n                      D     D                      \n                     E       E                     \n                    F         F                    \n                   G           G                   \n                  H             H                  \n                 I               I                 \n                J                 J                \n               K                   K               \n              L                     L              \n             M                       M             \n            N                         N            \n           O                           O           \n          P                             P          \n         Q                               Q         \n        R                                 R        \n       S                                   S       \n      T                                     T      \n     U                                       U     \n    V                                         V    \n   W                                           W   \n  X                                             X  \n Y                                               Y \nZ                                                 Z\n Y                                               Y \n  X                                             X  \n   W                                           W   \n    V                                         V    \n     U                                       U     \n      T                                     T      \n       S                                   S       \n        R                                 R        \n         Q                               Q         \n          P                             P          \n           O                           O           \n            N                         N            \n             M                       M             \n              L                     L              \n               K                   K               \n                J                 J                \n                 I               I                 \n                  H             H                  \n                   G           G                   \n                    F         F                    \n                     E       E                     \n                      D     D                      \n                       C   C                       \n                        B B                        \n                         A                         ";
        Assert.Equal(expectedDiamond, diamond);
    }
}
