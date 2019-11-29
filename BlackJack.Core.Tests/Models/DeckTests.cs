using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using BlackJack.Core.Models;
using FluentAssertions;
using Xunit;

namespace BlackJack.Core.Tests.Models
{
    public class DeckTests
    {
        private IFixture _fixture;

        public DeckTests()
        {
            _fixture = new Fixture();
        }

        [Fact]
        public void GivenDrawCardsIsCalled()
        {
            var cards = _fixture.Build<Card>().CreateMany(4);
            var deck = _fixture.Build<Deck>().With(deck1 => deck1.Cards ,cards).Create();

            var result = deck.DrawCards(3);
            result.Count().Should().Be(3);
            deck.Cards.Count().Should().Be(1);

            var expected = cards.ToList();
            expected.Remove(deck.Cards.First());
            result.Should().BeEquivalentTo(expected);
        }
    }
}
