using AutoFixture;
using BlackJack.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using Xunit;

namespace BlackJack.Core.Tests.Services
{
    public class DeckBuilderTests
    {
        private IFixture _fixture;
        private IDeckBuilder _deckBuilder;
        private ISuitBuilder _suitBuilder;

        public DeckBuilderTests()
        {
            _fixture = new Fixture();
            _suitBuilder = Substitute.For<ISuitBuilder>();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient(provider => _suitBuilder);
            serviceCollection.AddTransient<IDeckBuilder, DeckBuilder>();

            var container = serviceCollection.BuildServiceProvider();
            _deckBuilder = container.GetService<IDeckBuilder>();
        }

        [Fact]
        public void GivenBuildIsCalled()
        {
            var result = _deckBuilder.Build();
            _suitBuilder.Received(4).Reset().WithSuit(Arg.Any<string>()).Build();
        }
    }
}
