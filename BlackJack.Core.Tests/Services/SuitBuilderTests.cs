using System.Collections.Generic;
using BlackJack.Core.Models;
using BlackJack.Core.Services;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace BlackJack.Core.Tests.Services
{
    public class SuitBuilderTests
    {
        private ISuitBuilder _suitBuilder;

        public SuitBuilderTests()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<ISuitBuilder, SuitBuilder>();
            var container = serviceCollection.BuildServiceProvider();
            _suitBuilder = container.GetService<ISuitBuilder>();
        }

        [Fact]
        public void GivenBuildIsCalled()
        {
            var expected = new List<Card>
            {
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Ace, Values = new[] {1, 11}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Two, Values = new[] {2}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue { Face = Constants.Constants.Faces.Nine, Values = new[] { 9 } }

                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Three, Values = new[] {3}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Four, Values = new[] {4}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Five, Values = new[] {5}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Six, Values = new[] {6}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Seven, Values = new[] {7}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue {Face = Constants.Constants.Faces.Eight, Values = new[] {8}}
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue { Face = Constants.Constants.Faces.Ten, Values = new[] { 10 } }
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue { Face = Constants.Constants.Faces.Jack, Values = new[] { 10 } }
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue { Face = Constants.Constants.Faces.King, Values = new[] { 10 } }
                },
                new Card
                {
                    Suit = Constants.Constants.Suits.Hearts,
                    FaceValue = new FaceValue { Face = Constants.Constants.Faces.Queen, Values = new[] { 10 } } 
                }
            };
            var result = _suitBuilder.Reset().WithSuit(Constants.Constants.Suits.Hearts).Build();
            result.Should().BeEquivalentTo(expected);
        }
    }
}
