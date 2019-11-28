using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.Core.Models;

namespace BlackJack.Core.Services
{
    public interface IDeckBuilder
    {
        Deck Build();
    }

    public class DeckBuilder : IDeckBuilder
    {
        private readonly ISuitBuilder _suitBuilder;

        public DeckBuilder(ISuitBuilder suitBuilder)
        {
            _suitBuilder = suitBuilder;
        }

        public Deck Build()
        {
            var cards = new List<Card>();
            foreach (var suit in Card.Suits())
            {
                cards.AddRange(_suitBuilder.Reset().WithSuit(suit).Build());
            }


            return new Deck { Cards = cards};
        }
    }
}
