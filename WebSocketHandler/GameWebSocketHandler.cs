using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CriseClimat.WebSocketHandlers
{
    public class GameWebSocketHandler
    {
        public async Task HandleWebSocketAsync(HttpContext context)
        {
            var socket = await context.WebSockets.AcceptWebSocketAsync();
            // Implémentation des messages WebSocket
        }
    }
}
