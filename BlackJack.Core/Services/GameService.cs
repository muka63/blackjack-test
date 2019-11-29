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
        private Deck _deck;

        public GameService(IDeckService deckService)
        {
            _deckService = deckService;
        }

        public Game Start(string playerName)
        {
            _deck = _deckService.RetrieveNewDeck();
            _deck = _deckService.ShuffleDeck(_deck);
            return new Game {Player = new Player {Name = playerName, Hand = new Hand { Cards = _deck.DrawCards(2)}}, Dealer = new Dealer { Deck = _deck, Hand = new Hand { Cards = _deck.DrawCards(2)}}};
        }

    }
}
