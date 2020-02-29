using System.Drawing;

namespace thegame.Game
{
	public class Card
	{
		public Card(Color color)
		{
			Color = Color;
			status = CardStatus.UNGUESSED;
		}

		protected enum CardStatus
		{
			GUESSED,
			UNGUESSED
		}

		protected CardStatus status { get; set; }
		public Color Color { get; }
	}
}