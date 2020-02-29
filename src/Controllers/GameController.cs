using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using thegame.Models;

namespace thegame.Controllers
{
    [Route("api/game")]
    public class GameController : Controller
    {
        private IGame Gamelogic;
        private Dictionary<int, IGame> games;//возможно потом здесь будет БД
        private int currentIndex;
        GameController()
        {
            this.Gamelogic = new Game();
            games = new Dictionary<int, IGame>();
            currentIndex = 0;
        }
        
        [HttpGet("score")]
        public IActionResult Score(int id)
        {
            //var score = games[id].GetScore();
            var score = Gamelogic.GetScore();
            return Ok(score);
        }

        [HttpPost]
        public IActionResult RollCard(Card card)
        {
            //var card = games[id].RollCard(x, y);
            Gamelogic.Flip(card.x, card.y);
            return Ok();
        }

        [HttpPost]
        public IActionResult StartGame()
        {
            currentIndex++;
            games.Add(currentIndex, new Game());
            return Ok(currentIndex);
        }

        [HttpPost]
        public IActionResult EndGame(int id)
        {
            games.Remove(id);
            return Ok();
        }
    }
}
