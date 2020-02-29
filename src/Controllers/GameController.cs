using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using thegame.Game;
using thegame.Models;

namespace thegame.Controllers
{
    [Route("api/game")]
    public class GameController : Controller
    {
        private Game.Game game;
        private Dictionary<int, Game.Game> games;//возможно потом здесь будет БД
        private int currentIndex;
        public GameController()
        {
            this.game = new Game.Game();
            games = new Dictionary<int, Game.Game>();
            currentIndex = 0;
        }
        
        [HttpGet("score")]
        public IActionResult Score(int id)
        {
            var score = games[id].GetScore();
            //var score = game.GetScore();
            return Ok(score);
        }

        [HttpPost("RollCard")]
        public IActionResult RollCard(int id, CardDTO card)
        {
            var cardFormGame = games[id].GetCard(card.x, card.y);
            //game.GetCard(card.x, card.y);
            return Ok();
        }

        [HttpPost("StartGame")]
        public IActionResult StartGame()
        {
            currentIndex++;
            games.Add(currentIndex, new Game.Game());
            return Ok(currentIndex);
        }

        [HttpPost("EndGame")]
        public IActionResult EndGame(int id)
        {
            games.Remove(id);
            return Ok();
        }
    }
}
