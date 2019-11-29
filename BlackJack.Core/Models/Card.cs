using System.Collections.Generic;
using System.Reflection.Metadata;

namespace BlackJack.Core.Models
{
    public class Card
    {
        public string Suit { get; set; }
        public FaceValue FaceValue { get; set; }

        public static IEnumerable<string> Suits()
        {
            return new List<string>
            {
                Constants.Constants.Suits.Hearts,
                Constants.Constants.Suits.Clubs,
                Constants.Constants.Suits.Diamonds,
                Constants.Constants.Suits.Spades
            };
        }

        public static List<FaceValue> FaceValues()
        {
            var values = new List<FaceValue>
            {
                new FaceValue {Face = Constants.Constants.Faces.Ace, Values = new[] {1, 11}},
                new FaceValue {Face = Constants.Constants.Faces.Two, Values = new[] {2}},
                new FaceValue{Face = Constants.Constants.Faces.Three, Values = new[] {3}},
                new FaceValue{Face = Constants.Constants.Faces.Four, Values = new[] {4}},
                new FaceValue{Face = Constants.Constants.Faces.Five, Values = new[] {5}},
                new FaceValue{Face = Constants.Constants.Faces.Six, Values = new[] {6}},
                new FaceValue{Face = Constants.Constants.Faces.Seven, Values = new[] {7}},
                new FaceValue{Face = Constants.Constants.Faces.Eight, Values = new[] {8}},
                new FaceValue{Face = Constants.Constants.Faces.Nine, Values = new[] {9}},
                new FaceValue{Face = Constants.Constants.Faces.Ten, Values = new[] {10}},
                new FaceValue{Face = Constants.Constants.Faces.Jack, Values = new[] {10}},
                new FaceValue{Face = Constants.Constants.Faces.Queen, Values = new[] {10}},
                new FaceValue{Face = Constants.Constants.Faces.King, Values = new[] {10}},
            };
            return values;
        }
    }
}
