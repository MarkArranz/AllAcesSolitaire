using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Solitaire
{
    // Create a "playing card" with suit and value.

    class PlayingCard : PictureBox
    {
        public int Value;
        public string Suit;

        public PlayingCard() { }

        public PlayingCard(int value, string suit)
        {
            this.Value = value;
            this.Suit = suit;
            this.Name = String.Format("{0} of {1}", value, suit);
            this.Size = new Size(90, 140);
            this.Visible = false;
        }
    }
}
