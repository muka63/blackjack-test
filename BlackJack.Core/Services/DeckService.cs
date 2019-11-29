using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.Core.Models;

namespace BlackJack.Core.Services
{
    public interface IDeckService
    {
        Deck RetrieveNewDeck();
        Deck ShuffleDeck(Deck deck);
    }

    public class DeckService : IDeckService
    {
        private readonly IDeckBuilder _builder;
        private readonly ICardService _cardService;

        public DeckService(IDeckBuilder builder, ICardService cardService)
        {
            _builder = builder;
            _cardService = cardService;
        }

        public Deck RetrieveNewDeck()
        {
            return _builder.Build();
        }

        public Deck ShuffleDeck(Deck deck)
        {
            deck.Cards = _cardService.ShuffleCards(deck.Cards);
            return deck;
        }


    }
}
