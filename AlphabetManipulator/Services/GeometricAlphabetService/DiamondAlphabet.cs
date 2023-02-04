namespace AlphabetManipulator.Services.GeometricAlphabetService
{
	public class DiamondAlphabet : IGeometricAlphabet
    {
        private readonly ILogger<DiamondAlphabet> _logger;

		public DiamondAlphabet(ILogger<DiamondAlphabet> logger)
		{
            _logger = logger;
		}   

        public string CreateFromChar(char character)
        {
            return "A";
        }
    }
}

