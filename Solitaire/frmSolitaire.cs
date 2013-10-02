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
        public static int moveCardFromStack = -1;
        public List<PictureBox> cardPBStacks = new List<PictureBox> {};

        public AllAcesSolitaire()
        {
            InitializeComponent();

            // Adds each PictureBox object to a list.
            cardPBStacks.Add(pbStack0);
            cardPBStacks.Add(pbStack1);
            cardPBStacks.Add(pbStack2);
            cardPBStacks.Add(pbStack3);
            cardPBStacks.Add(pbDiscardStack);
            
        }

        public void ClearCardImages()
        {
            foreach (PictureBox cardStack in cardPBStacks)
                cardStack.Image = null;            
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            currentGame.NewGame();
            
            /* VIEW
             * Show game is ready by displaying a "loaded deck" at PictureBox pbDeck,
             * and clearing images from PictureBoxes for all four positions and 
             * discardPile.
             */
            ClearCardImages();
            pbDeck.Image = imgListCardBack.Images[0];
        }

        public void UpdateTestBoxes()
        {
            /* TEST (VIEW AND MODEL)
             * Test block to check that value and suit are matching pictures.
             */
            List<TextBox> TestBoxList = new List<TextBox>();
            TestBoxList.Add(testBox0);
            TestBoxList.Add(testBox1);
            TestBoxList.Add(testBox2);
            TestBoxList.Add(testBox3);

            for (int i = 0; i < 4; i++)
            {
                Stack<int> currentStack = currentGame.indexStacksList[i];
                if (currentStack.Count != 0)
                {
                    TestBoxList[i].Text = currentGame.playingCardDeck[currentStack.Peek()].Value +
                                    " : " + currentGame.playingCardDeck[currentStack.Peek()].Suit
                                    + " : " + currentStack.Count;
                }
                else
                {
                    TestBoxList[i].Text = null;
                }
            }
            texsBox4.Text = "Selected Stack: " + moveCardFromStack;
            testBox5.Text = "Count: " + currentGame.discardStack.Count;
        }

        public void UpdateCardImages()
        {
            for (int i = 0; i < 5; i++)
            {
                Stack<int> currentStack = currentGame.indexStacksList[i];

                if (currentStack.Count == 0)
                {
                    cardPBStacks[i].Image = null;
                }
                else
                {
                    cardPBStacks[i].Image =
                        imgListOrderedDeck.Images[currentStack.Peek()];
                }
            }
        }

        private void pbDeck_Click(object sender, EventArgs e)
        {
            currentGame.DealHand();
            UpdateCardImages();

            if (currentGame.shuffledDeckIndex.Count.Equals(0))
            {
                pbDeck.Image = null;
            }
            UpdateTestBoxes();
        }

        private void pbStack_Click(object sender, EventArgs e)
        {
            PictureBox pbClicked = (PictureBox)sender;
            int currentStackIndex = cardPBStacks.IndexOf(pbClicked);
            Stack<int> currentStack = currentGame.indexStacksList[currentStackIndex];

            if (moveCardFromStack > -1 && currentStack.Count == 0)
            {   
                currentGame.MoveCardTo(moveCardFromStack, currentStackIndex);
                UpdateCardImages();
                moveCardFromStack = -1;
            }
            else if (currentStack.Count > 0)
            {
                moveCardFromStack = currentStackIndex;
            }
            UpdateTestBoxes();
        }

        private void pbDiscardPile_Click(object sender, EventArgs e)
        {
            if (moveCardFromStack > -1)
            {
                currentGame.MoveCardTo(moveCardFromStack, 4);
                UpdateCardImages();
                moveCardFromStack = -1;
            }
            UpdateTestBoxes();
        }
    }
}
