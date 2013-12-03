using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace Solitaire
{
    public partial class AllAcesSolitaire : Form
    {
        #region Class Variables
        Form settingsForm = new frmSettings();
        allAcesGame currentGame = new allAcesGame();

        private int startStackIndex = -1;
        private List<PlayingCard> stack0 = new List<PlayingCard>();
        private List<PlayingCard> stack1 = new List<PlayingCard>();
        private List<PlayingCard> stack2 = new List<PlayingCard>();
        private List<PlayingCard> stack3 = new List<PlayingCard>();
        private List<List<PlayingCard>> stackList = new List<List<PlayingCard>>();
        private List<RectangleShape> stackBaseList;
        #endregion

        public AllAcesSolitaire()
        {
            InitializeComponent();
            settingsForm = new frmSettings(ref pbDeck, ref imgListCardBack);
            
            stackList.Add(stack0);
            stackList.Add(stack1);
            stackList.Add(stack2);
            stackList.Add(stack3);
            stackBaseList = new List<RectangleShape>{rectangleStackBase0, rectangleStackBase1, rectangleStackBase2, rectangleStackBase3};
        }

        #region Debugging Boxes
        
        private void UpdateTestBoxes()
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
                List<PlayingCard> playingCardStack = stackList[i];
                
                if (playingCardStack.Count != 0)
                {
                    PlayingCard topPlayingCard = playingCardStack[playingCardStack.Count - 1];
                    TestBoxList[i].Text = String.Format("{0} of {1} : {2}", 
                                                        topPlayingCard.Value,
                                                        topPlayingCard.Suit,
                                                        playingCardStack.Count);
                }
                else
                {
                    TestBoxList[i].Text = "(none) : 0";
                }
            }
            testBox4.Text = "Selected Stack: " + startStackIndex;
            testBox5.Text = "Count: " + currentGame.discardStack.Count;
            testBox6.Text = "Cards Left: " + currentGame.shuffledDeckIndex.Count;
        }

        #endregion

        #region Business Rules

        private bool CanDeal()
        {
            if (currentGame.shuffledDeckIndex.Count == 0)
                return false;
            if (currentGame.shuffledDeckIndex.Count == 4)
                pbDeck.Image = null;
            return true;
        }

        private bool CanDiscard(int stackIndex)
        {
            /* Bool to test if card is eligible to be discarded.
             * Called by pbDiscardPile_Click() and 
             * pbCardImage_DoubleClick(). */
            PlayingCard cardToDiscard = new PlayingCard();
            List<PlayingCard> OtherTopCards = new List<PlayingCard>();
            foreach (List<PlayingCard> cardStack in stackList)
            {
                if (stackList.IndexOf(cardStack) == stackIndex)
                    cardToDiscard = cardStack[cardStack.Count - 1];
                else if (cardStack.Count > 0)
                    OtherTopCards.Add(cardStack[cardStack.Count - 1]);
            }
            foreach (PlayingCard otherTopCard in OtherTopCards)
            {
                if (cardToDiscard.Suit == otherTopCard.Suit &&
                    cardToDiscard.Value < otherTopCard.Value)
                    return true;
            }
            return false;

        }

        #endregion

        #region PlayingCard Manipulation

        private void SetDeckBackImage()
        {
            RadioButton redBack = (RadioButton)settingsForm.Controls.Find("rbtnRed", false)[0];
            if (redBack.Checked == true)
                pbDeck.Image = imgListCardBack.Images[0];
            else
                pbDeck.Image = imgListCardBack.Images[1];
        }

        private void DealPlayingCards()
        {
            // Deals new PlayingCards to each PlayingCard stack.
            int currentStackIndex = 0;
            Point cardToLocation;
            foreach (Stack<int> intStack in currentGame.indexStacksList)
            {
                int dealtCardIndex = intStack.Peek();
                Image dealCardImage = imgListOrderedDeck.Images[dealtCardIndex];
                PlayingCard displayCard = currentGame.playingCardDeck[dealtCardIndex];
                List<PlayingCard> currentStack = stackList[currentStackIndex];

                if (intStack.Count == 1)
                    displayCard.Location = stackBaseList[currentStackIndex].Location;
                else
                {
                    cardToLocation = currentStack[currentStack.Count - 1].Location;
                    displayCard.Location = new Point(cardToLocation.X, cardToLocation.Y + 30);
                }

                displayCard.Visible = true;
                displayCard.Image = dealCardImage;
                displayCard.Click += pbCardImage_Click;
                displayCard.DoubleClick += pbCardImage_DoubleClick;
                displayCard.Anchor = AnchorStyles.Top;

                currentStack.Add(displayCard);
                this.Controls.Add(displayCard); 
                displayCard.BringToFront();

                currentStackIndex++;
            }
        }

        private void ClearAllPlayingCards()
        {
            // Clears all the card images.
            pbDiscardStack.Image = null;
            foreach (List<PlayingCard> stack in stackList)
                stack.RemoveRange(0, stack.Count);

            for (int i = this.Controls.Count - 1; i >= 0; i--)
                if (this.Controls[i] is PlayingCard)
                    this.Controls.RemoveAt(i);
        }

        private int SetStackIndex(object sender)
        {
            /* Used by event handlers to set stackIndexes for moving and 
             * discarding playingCards. */
            try
            {
                PlayingCard pbCardImage = (PlayingCard)sender;
                foreach (List<PlayingCard> stack in stackList)
                    if (stack.Contains(pbCardImage))
                        return stackList.IndexOf(stack);
                return -1;
            }
            catch (InvalidCastException e)
            {
                RectangleShape stackBase = (RectangleShape)sender;
                foreach (RectangleShape Base in stackBaseList)
                    if (Base == stackBase)
                        return stackBaseList.IndexOf(stackBase);
                return -1;
            }
        }
        
        private void MoveCardImage(int selectedStackIndex, int currentStackIndex)
        {
            // "Moves" playingCard object from one stack to another
            List<PlayingCard> selectedStack = stackList[selectedStackIndex];
            List<PlayingCard> currentStack = stackList[currentStackIndex];
            PlayingCard moveCard = selectedStack[selectedStack.Count - 1];

            selectedStack.RemoveAt(selectedStack.Count - 1);
            if (currentStack.Count == 0)
            {
                moveCard.Location = stackBaseList[currentStackIndex].Location;
            }
            else
            {
                Point newLocation = currentStack[currentStack.Count - 1].Location;
                moveCard.Location = new Point(newLocation.X, newLocation.Y + 30);
            }
            currentStack.Add(moveCard);
            moveCard.BringToFront();
            startStackIndex = -1;
        }

        private void DiscardPlayingCardObject(int startStackIndex)
        {
            /* Combines all discard methods into one method. 
             * Used by event handlers pbDiscardPile_Click() 
             * and pbCardImage_DoubleClick(). */
            if (CanDiscard(startStackIndex))
            {
                currentGame.DiscardCardIndex(startStackIndex);
                MoveToDiscard(startStackIndex);
                UpdateTestBoxes();
            }
        }
            
            #region DiscardPlayingCardObject() sub-methods
    
            private void MoveToDiscard(int selectedStackIndex)
            {
                // "Moves" playingCard object in field to discard pile
                List<PlayingCard> selectedStack = stackList[selectedStackIndex];
                PlayingCard throwAwayCard = selectedStack[selectedStack.Count - 1];
                pbDiscardStack.Image = throwAwayCard.Image;
                selectedStack.RemoveAt(selectedStack.Count - 1);
                RemovePlayingCard(throwAwayCard);
                startStackIndex = -1;
            }

            private void RemovePlayingCard(PlayingCard cardToRemove)
            {
                // Disposes playingCard object from Controls. Meant to be called by other methods.
                for (int i = 0; i < this.Controls.Count - 1; i++)
                    if (this.Controls[i] is PlayingCard && 
                        this.Controls[i].Name == cardToRemove.Name)
                        this.Controls.RemoveAt(i);
            }
        
            #endregion

        #endregion

        #region Event Handlers

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            /* Event handler that calls the NewGame() method 
             * and updates the view. */
            ClearAllPlayingCards();
            currentGame.NewGame();
            SetDeckBackImage();
            pbDeck.BorderStyle = BorderStyle.None;
            EnableMenuItems();
            UpdateTestBoxes();
        }

        private void pbDeck_Click(object sender, EventArgs e)
        {
            // Calls the DealHand() method and updates the view.
            if (CanDeal())
            {
                currentGame.DealHand();
                DealPlayingCards();
                UpdateTestBoxes();
            }
        }

        private void pbDiscardPile_Click(object sender, EventArgs e)
        {
            DiscardPlayingCardObject(startStackIndex);
        }

        private void pbCardImage_Click(object sender, EventArgs e)
        {
            /* Method that sets the selectedStack variable to use to move
            * cards from one game stack to another. */
            int targetStackIndex = SetStackIndex(sender);
            
            Stack<int> targetStack = currentGame.indexStacksList[targetStackIndex];

            if (startStackIndex > -1 && targetStack.Count == 0)
            {
                currentGame.MoveCardTo(startStackIndex, targetStackIndex);
                MoveCardImage(startStackIndex, targetStackIndex);
            }
            else if (targetStack.Count > 0)
            {
                startStackIndex = targetStackIndex;
            }
            UpdateTestBoxes();
        }

        private void pbCardImage_DoubleClick(object sender, EventArgs e)
        {
            // Discards the double clicked card if allowed.
            startStackIndex = SetStackIndex(sender);
            DiscardPlayingCardObject(startStackIndex);            
        }

        #endregion

        #region Menu Items

        private void EnableMenuItems()
        {
            cardBackToolStripMenuItem.Enabled = true;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNewGame_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void valueBoxesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // Toggles display of value boxes used primarily for debugging
            if (valueBoxesToolStripMenuItem.Checked == true)
            {
                testBox0.Visible = true;
                testBox1.Visible = true;
                testBox2.Visible = true;
                testBox3.Visible = true;
                testBox4.Visible = true;
                testBox5.Visible = true;
                testBox6.Visible = true;
            }
            else
            {
                testBox0.Visible = false;
                testBox1.Visible = false;
                testBox2.Visible = false;
                testBox3.Visible = false;
                testBox4.Visible = false;
                testBox5.Visible = false;
                testBox6.Visible = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsForm.Visible = true;
        }
        
        #endregion

    }
}