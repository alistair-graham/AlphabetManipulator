namespace DiamondKata.Services.AlphabetWriters
{
	public interface IAlphabetWriter
	{
		public string FromChar(char character, out string output);
	}
}