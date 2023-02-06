using System.Diagnostics.Metrics;
using System.Text;

namespace AlphabetManipulator.Services.GeometricAlphabetService
{
	public class DiamondAlphabetService : IGeometricAlphabetService
    {
        private readonly ILogger<DiamondAlphabetService> _logger;

		public DiamondAlphabetService(ILogger<DiamondAlphabetService> logger)
		{
            _logger = logger;
		}

        public string CreateFromLetter(char highestLetter)
        {
            if (!char.IsLetter(highestLetter))
            {
                _logger.LogError($"[CreateFromLetter] method argument '{nameof(highestLetter)}' must be a letter. Instead received <{highestLetter}>.");
                throw new ArgumentOutOfRangeException(nameof(highestLetter), $"Argument must be a letter, instead was <{highestLetter}>");
            }

            highestLetter = char.ToUpper(highestLetter);

            var lineList = new List<string>();

            BuildAlphabetTriangle(lineList, highestLetter);
            TransformAlphabetTriangleToDiamond(lineList);

            return string.Join("\n", lineList);
        }

        private static void BuildAlphabetTriangle(List<string> lineList, char highestLetter)
        {
            for (var letter = 'A'; letter <= highestLetter; letter++)
            {
                var line = CreateLine(letter, highestLetter);
                lineList.Add(line);
            }
        }

        private static void TransformAlphabetTriangleToDiamond(List<string> lineList)
        {
            for (var i = lineList.Count - 2; i >= 0; i--)
            {
                lineList.Add(lineList[i]);
            }
        }

        private static string CreateLine(char letter, char highestLetter)
        {
            var lineBuilder = new StringBuilder();

            var outerSpacing = GetExteriorSpacing(letter, highestLetter);
            var interiorSpacing = GetInteriorSpacing(letter);

            lineBuilder.Append(' ', outerSpacing);
            lineBuilder.Append(letter);

            if (letter != 'A')
            {
                lineBuilder.Append(' ', interiorSpacing);
                lineBuilder.Append(letter);
            }

            lineBuilder.Append(' ', outerSpacing);

            return lineBuilder.ToString();
        }

        private static int GetExteriorSpacing(char letter, char highestLetter)
        {
            return highestLetter - letter;
        }

        private static int GetInteriorSpacing(char letter)
        {
            if (letter == 'A')
            {
                return 0;
            }
            return (2 * (letter - 'A')) - 1;
        }
    }
}

