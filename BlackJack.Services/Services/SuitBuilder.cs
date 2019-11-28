using System;
using System.Collections.Generic;
using System.Text;
using BlackJack.Core.Models;

namespace BlackJack.Core.Services
{
    public interface ISuitBuilder
    {
        ISuitBuilder Reset();
        ISuitBuilder WithSuit(string suitName);
        IEnumerable<Card> Build();
    }

    public class SuitBuilder : ISuitBuilder
    {
        private string _suitName;

        public ISuitBuilder Reset()
        {
            _suitName = string.Empty;
            return this;
        }

        public ISuitBuilder WithSuit(string suitName)
        {
            _suitName = suitName;
            return this;
        }

        public IEnumerable<Card> Build()
        {
            if (string.IsNullOrWhiteSpace(_suitName))
            {
                throw  new Exception("missing SuitName");
            }

            var suit = new List<Card>();
            foreach (var faceValue in Card.FaceValues())
            {
                suit.Add(new Card { FaceValue = faceValue, Suit = _suitName });
            }

            return suit;
        }
    }
}
