using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BlackJack.Core.Models;

namespace BlackJack.Core.Services
{
    public interface ICardService
    {
        IEnumerable<Card> ShuffleCards(IEnumerable<Card> cards);
    }

    public class CardService : ICardService
    {
        public IEnumerable<Card> ShuffleCards(IEnumerable<Card> cards)
        {
           var random = new Random();
           var enumerable = cards as Card[] ?? cards.ToArray();
           var randomize = Enumerable.Range(0, enumerable.Count()).OrderBy(x => random.Next());
           return randomize.Select(num => enumerable.ElementAt(num)).ToList();
        }
    }
}
