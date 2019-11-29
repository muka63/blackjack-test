using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoFixture;
using BlackJack.Core.Models;
using BlackJack.Core.Services;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlackJack.Core.Tests.Services
{
    public class CardServiceTests
    {
        private ICardService _cardService;
        private IFixture _fixture;

        public CardServiceTests()
        {
            var serviceCollection =  new ServiceCollection();
            serviceCollection.AddTransient<ICardService, CardService>();
            var container = serviceCollection.BuildServiceProvider();
            _cardService = container.GetService<ICardService>();
        }

        [Fact]
        public void GivenShuffleCardsIsCalled()
        {
            _fixture = new Fixture();
            var cards = _fixture.CreateMany<Card>();
            var result = _cardService.ShuffleCards(cards);
            result.Count().Should().Be(cards.Count());
            result.Should().BeEquivalentTo(cards);
        }

    }
}
