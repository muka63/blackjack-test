using BlackJack.Core.Models;

namespace BlackJack.Core.Services
{
    public interface IGameService
    {
        Game Start(string playerName);
    }

    public class GameService : IGameService
    {
        private readonly IDeckService _deckService;

        public GameService(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public Game Start(string playerName)
        {
            return new Game {Player = new Player {Name = playerName}, Dealer = new Dealer()};
        }

    }
}
