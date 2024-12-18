using System;
using System.Collections.Generic;
using CriseClimat.Models;

namespace CriseClimat.Services
{
    public class GameService
    {
        private readonly Dictionary<string, Game> _games = new Dictionary<string, Game>();

        public string CreateGame()
        {
            var gameId = Guid.NewGuid().ToString();
            _games[gameId] = new Game { Id = gameId };
            return gameId;
        }

        public bool JoinGame(string gameId, Player player)
        {
            if (_games.TryGetValue(gameId, out var game))
            {
                game.Players.Add(player);
                return true;
            }
            return false;
        }
    }
}
