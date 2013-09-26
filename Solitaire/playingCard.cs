using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    // Create a "card" class with suit and value.
    class playingCard
    {
        public int Value { get; set; }
        public string Suit { get; set; }
        public playingCard(int value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
        }
    }


}
