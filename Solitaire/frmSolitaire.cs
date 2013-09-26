using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solitaire
{
    public partial class AllAcesSolitaire : Form
    {
        allAcesGame currentGame = new allAcesGame();
        public int movingCardIndex;
        public Stack<int> stackOfMovingCard;

        public AllAcesSolitaire()
        {
            InitializeComponent();
        }
        
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            currentGame.NewGame();
            
            /* VIEW
             * Show game is ready by displaying a "loaded deck" at PictureBox pbDeck,
             * and clearing images from PictureBoxes for all four positions and 
             * discardPile.
             */
            Image deckBack = imgListCardBack.Images[0];
            pbDeck.Image = deckBack;
            pbPosition1.Image = null;
            pbPosition2.Image = null;
            pbPosition3.Image = null;
            pbPosition4.Image = null;
            pbDiscardPile.Image = null;

            pbDeck.BorderStyle = BorderStyle.None;
            pbPosition1.BorderStyle = BorderStyle.FixedSingle;
            pbPosition2.BorderStyle = BorderStyle.FixedSingle;
            pbPosition3.BorderStyle = BorderStyle.FixedSingle;
            pbPosition4.BorderStyle = BorderStyle.FixedSingle;
            pbDiscardPile.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbDeck_Click(object sender, EventArgs e)
        {
            currentGame.DealHand();

            /* VIEW
             * Show image of card at the top of each position stack. 
             */
            pbPosition1.Image = imgListOrderedDeck.Images[currentGame.position1.Peek()];
            pbPosition2.Image = imgListOrderedDeck.Images[currentGame.position2.Peek()];
            pbPosition3.Image = imgListOrderedDeck.Images[currentGame.position3.Peek()];
            pbPosition4.Image = imgListOrderedDeck.Images[currentGame.position4.Peek()];
            //pbPosition1.BorderStyle = BorderStyle.None;
            //pbPosition2.BorderStyle = BorderStyle.None;
            //pbPosition3.BorderStyle = BorderStyle.None;
            //pbPosition4.BorderStyle = BorderStyle.None;

            /* VIEW
             * If deck is empty, show that no cards are left.
             */
            if (currentGame.shuffledDeckIndex.Count.Equals(0))
            {
                pbDeck.BorderStyle = BorderStyle.Fixed3D;
                pbDeck.Image = null;
            }

            /* TEST (VIEW AND MODEL)
                 * Test block to check that value and suit are matching pictures.
                 */
            textBox1.Text = currentGame.playingCardDeck[currentGame.position1.Peek()].Value +
                                " : " + currentGame.playingCardDeck[currentGame.position1.Peek()].Suit
                                + " : " + currentGame.position1.Count;
            textBox2.Text = currentGame.playingCardDeck[currentGame.position2.Peek()].Value +
                                " : " + currentGame.playingCardDeck[currentGame.position2.Peek()].Suit
                                + " : " + currentGame.position2.Count;
            textBox3.Text = currentGame.playingCardDeck[currentGame.position3.Peek()].Value +
                                " : " + currentGame.playingCardDeck[currentGame.position3.Peek()].Suit
                                + " : " + currentGame.position1.Count;
            textBox4.Text = currentGame.playingCardDeck[currentGame.position4.Peek()].Value +
                                " : " + currentGame.playingCardDeck[currentGame.position4.Peek()].Suit
                                + " : " + currentGame.position1.Count;
        }
    }
}
