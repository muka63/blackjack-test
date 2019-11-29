using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace BlackJack.Core.Models
{
    public class Deck
    {
        public IEnumerable<Card> Cards { get; set; }

        public IEnumerable<Card> DrawCards(int draw = 1)
        {
            var cards = new List<Card>();
            var currentList = Cards.ToList();
            for (var i = 0; i < draw; i++)
            {
                if (!currentList.Any()) {continue;}
                cards.Add(currentList.First());
                currentList.Remove(currentList.First());
            }

            return cards;
        }
    }
}
