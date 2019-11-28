using System.Collections.Generic;

namespace BlackJack.Core.Models
{
    public class FaceValue
    {
        public string Face { get; set; }
        public IEnumerable<int> Values { get; set; }
    }
}