using System.Text;

namespace AlphabetManipulator.Services.GeometricAlphabetService
{
	public class DiamondAlphabetService : IGeometricAlphabetService
    {
        private readonly ILogger<DiamondAlphabetService> _logger;
        private const int ASCIIDecimal_A = 65;

		public DiamondAlphabetService(ILogger<DiamondAlphabetService> logger)
		{
            _logger = logger;
		}

        public  string CreateFromChar(char maxLetter)
        {
            var lineList = new List<string>();

            BuildAlphabetTriangle(lineList, maxLetter);
            TransformAlphabetTriangleToDiamond(lineList);

            return string.Join("\n", lineList);
        }

        private static void BuildAlphabetTriangle(List<string> lineList, char maxLetter)
        {
            for (var letter = 'A'; letter <= maxLetter; letter++)
            {
                var line = CreateLine(letter, maxLetter);
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

        private static string CreateLine(char letter, char maxLetter)
        {
            var lineBuilder = new StringBuilder();

            var outerSpacing = GetExteriorSpacing(letter, maxLetter);
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

        private static int GetExteriorSpacing(char letter, char maxLetter)
        {
            return maxLetter - letter;
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

