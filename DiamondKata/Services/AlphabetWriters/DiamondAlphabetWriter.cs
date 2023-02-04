namespace DiamondKata.Services.AlphabetWriters
{
	public class DiamondAlphabetWriter : IAlphabetWriter
    {
        private readonly ILogger<DiamondAlphabetWriter> _logger;

		public DiamondAlphabetWriter(ILogger<DiamondAlphabetWriter> logger)
		{
            _logger = logger;
		}   

        public string FromChar(char character, out string output)
        {
            throw new NotImplementedException();
        }
    }
}

