using Xunit;
using Moq;
using AlphabetManipulator.Services.GeometricAlphabetService;
using System.Diagnostics.Metrics;

namespace AlphabetManipulator.Tests.Unit.Services.GeometricAlphabetService;

public class DiamondAlphabetServiceTests
{
    private readonly ILogger<DiamondAlphabetService> _stubLogger;
    private readonly DiamondAlphabetService _diamondAlphabetService;

    public DiamondAlphabetServiceTests()
    {
        _stubLogger = Mock.Of<ILogger<DiamondAlphabetService>>();
        _diamondAlphabetService = new DiamondAlphabetService(_stubLogger);
    }

    [Fact]
    public void CreateFromChar_LetterA_ReturnsA()
    {
        const char LETTER_A = 'A';

        var result = _diamondAlphabetService.CreateFromLetter(LETTER_A);

        Assert.Equal("A", result);
    }

    [Fact]
    public void CreateFromChar_LetterM_ReturnsDiamondUpToLetterM()
    {
        const char LETTER_M = 'M';

        var result = _diamondAlphabetService.CreateFromLetter(LETTER_M);

        var expectedDiamond = "            A            \n           B B           \n          C   C          \n         D     D         \n        E       E        \n       F         F       \n      G           G      \n     H             H     \n    I               I    \n   J                 J   \n  K                   K  \n L                     L \nM                       M\n L                     L \n  K                   K  \n   J                 J   \n    I               I    \n     H             H     \n      G           G      \n       F         F       \n        E       E        \n         D     D         \n          C   C          \n           B B           \n            A            ";
        Assert.Equal(expectedDiamond, result);
    }

    [Fact]
    public void CreateFromChar_LetterZ_ReturnsFullDiamond()
    {
        const char LETTER_Z = 'Z';

        var result = _diamondAlphabetService.CreateFromLetter(LETTER_Z);

        var expectedDiamond = "                         A                         \n                        B B                        \n                       C   C                       \n                      D     D                      \n                     E       E                     \n                    F         F                    \n                   G           G                   \n                  H             H                  \n                 I               I                 \n                J                 J                \n               K                   K               \n              L                     L              \n             M                       M             \n            N                         N            \n           O                           O           \n          P                             P          \n         Q                               Q         \n        R                                 R        \n       S                                   S       \n      T                                     T      \n     U                                       U     \n    V                                         V    \n   W                                           W   \n  X                                             X  \n Y                                               Y \nZ                                                 Z\n Y                                               Y \n  X                                             X  \n   W                                           W   \n    V                                         V    \n     U                                       U     \n      T                                     T      \n       S                                   S       \n        R                                 R        \n         Q                               Q         \n          P                             P          \n           O                           O           \n            N                         N            \n             M                       M             \n              L                     L              \n               K                   K               \n                J                 J                \n                 I               I                 \n                  H             H                  \n                   G           G                   \n                    F         F                    \n                     E       E                     \n                      D     D                      \n                       C   C                       \n                        B B                        \n                         A                         ";
        Assert.Equal(expectedDiamond, result);
    }

    [Fact]
    public void CreateFromChar_LowerCaseB_ReturnsUpperCaseDiamond()
    {
        const char LOWERCASE_B = 'b';

        var result = _diamondAlphabetService.CreateFromLetter(LOWERCASE_B);

        var expectedDiamond = @" A 
B B
 A ";
        Assert.Equal(expectedDiamond, result);
    }

    [Fact]
    public void CreateFromChar_NonAlphabeticalCharacter_ThrowsArgumentOutOfBoundsException()
    {
        const char NON_ALPHABETICAL_CHARACTER = ']';

        var action = () => _diamondAlphabetService.CreateFromLetter(NON_ALPHABETICAL_CHARACTER);

        var exception = Assert.Throws<ArgumentOutOfRangeException>(action);
        Assert.Equal("Argument must be a letter, instead was <]> (Parameter 'highestLetter')", exception.Message);
    }
}
