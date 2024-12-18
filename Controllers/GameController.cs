using Microsoft.AspNetCore.Mvc;

namespace CriseClimat.Controllers
{
    [Route("api/game")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly GameService _gameService;

        public GameController(GameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost("create")]
        public IActionResult CreateGame()
        {
            var gameId = _gameService.CreateGame();
            return Ok(new { GameId = gameId });
        }

        [HttpPost("join/{gameId}")]
        public IActionResult JoinGame(string gameId, [FromBody] Player player)
        {
            if (_gameService.JoinGame(gameId, player))
            {
                return Ok();
            }
            return NotFound("Game not found");
        }
    }
}
