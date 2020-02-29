using System.Linq;
using thegame.Game.Primitives;
using thegame.Game.Tools;

namespace thegame.Game
{
	public class Game
	{
		public GameBoard Board { get; }
		public GameState State { get; private set; }

		private IPlayer player;
		private Card openCard;


		public Game()
		{
			player = null;
			State = GameState.IN_PROCESS;
			var generator = new BoardGenerator();
			Board = generator.Generate(4, 4);
		}

		public Game(IPlayer player)
		{
			this.player = player;
			State = GameState.IN_PROCESS;
			var generator = new BoardGenerator();
			Board = generator.Generate(4, 4);
		}

		public Card GetCard(int height, int width)
		{
			var card = Board.Cards[height, width];

			CheckMatch(card);

			return card;
		}

		public int GetScore()
		{
			return GetCountOfCardsGuessed() * 100;
		}


		private void CheckMatch(Card card)
		{
			if (openCard == null)
			{
				openCard = card;
			}
			else if (IsPair(card))
			{
				openCard.Status = CardStatus.GUESSED;
				card.Status = CardStatus.GUESSED;
				openCard = null;
				UpdateGameState();
			}
			else
			{
				openCard = null;
			}
		}

		private void UpdateGameState()
		{
			var count = GetCountOfCardsGuessed();

			if (count == Board.Cards.Length)
			{
				State = GameState.FINISHED;
			}
		}

		private bool IsPair(Card card)
		{
			if (openCard == null)
				return false;
			
			return openCard.Color == card.Color;
		}

		private int GetCountOfCardsGuessed()
		{
			return Board.Cards.Cast<Card>().Count(card => card.Status == CardStatus.GUESSED);
		}
	}
}