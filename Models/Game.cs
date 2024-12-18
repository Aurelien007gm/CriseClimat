using System.Collections.Generic;

namespace CriseClimat.Models
{
    public class Game
    {
        public string Id { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
    }
}