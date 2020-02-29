using thegame.Game.Tools;

namespace thegame.Game
{
	public class Game
	{
		private IPlayer player;
		private GameState state;
		private readonly GameBoard board;

		public Game()
		{
			player = null;
		}

		public Game(IPlayer player, GameState state)
		{
			this.player = player;
			this.state = state;
			var generator = new BoardGenerator();
			this.board = generator.Generate(4, 4);
		}

		public Card GetCard(int height, int width)
		{
			return board.Cards[height, width];
		}

		public int GetScore()
		{
			return 10;
		}


	}
}