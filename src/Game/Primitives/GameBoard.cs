namespace thegame.Game
{
	public class GameBoard
	{
		public GameBoard(Card[,] cards) //, string[] images)
		{
			Cards = cards;
		}

		public Card[,] Cards { get; }
		//public string[] Images { get; }
	}
}