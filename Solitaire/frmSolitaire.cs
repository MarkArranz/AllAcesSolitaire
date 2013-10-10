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
        private int selectedStack = -1;
        private List<List<PictureBox>> panelStackList = new List<List<PictureBox>> { };
        private List<PictureBox> pbStack0List = new List<PictureBox> { };
        private List<PictureBox> pbStack1List = new List<PictureBox> { };
        private List<PictureBox> pbStack2List = new List<PictureBox> { };
        private List<PictureBox> pbStack3List = new List<PictureBox> { };

        public AllAcesSolitaire()
        {
            InitializeComponent();

            pbStack0List.Add(pbStk0Pos0);
            pbStack0List.Add(pbStk0Pos1);
            pbStack0List.Add(pbStk0Pos2);
            pbStack0List.Add(pbStk0Pos3);
            pbStack0List.Add(pbStk0Pos4);
            pbStack0List.Add(pbStk0Pos5);
            pbStack0List.Add(pbStk0Pos6);
            pbStack0List.Add(pbStk0Pos7);
            pbStack0List.Add(pbStk0Pos8);
            pbStack0List.Add(pbStk0Pos9);
            pbStack0List.Add(pbStk0Pos10);
            pbStack0List.Add(pbStk0Pos11);
            pbStack0List.Add(pbStk0Pos12);

            pbStack1List.Add(pbStk1Pos0);
            pbStack1List.Add(pbStk1Pos1);
            pbStack1List.Add(pbStk1Pos2);
            pbStack1List.Add(pbStk1Pos3);
            pbStack1List.Add(pbStk1Pos4);
            pbStack1List.Add(pbStk1Pos5);
            pbStack1List.Add(pbStk1Pos6);
            pbStack1List.Add(pbStk1Pos7);
            pbStack1List.Add(pbStk1Pos8);
            pbStack1List.Add(pbStk1Pos9);
            pbStack1List.Add(pbStk1Pos10);
            pbStack1List.Add(pbStk1Pos11);
            pbStack1List.Add(pbStk1Pos12);

            pbStack2List.Add(pbStk2Pos0);
            pbStack2List.Add(pbStk2Pos1);
            pbStack2List.Add(pbStk2Pos2);
            pbStack2List.Add(pbStk2Pos3);
            pbStack2List.Add(pbStk2Pos4);
            pbStack2List.Add(pbStk2Pos5);
            pbStack2List.Add(pbStk2Pos6);
            pbStack2List.Add(pbStk2Pos7);
            pbStack2List.Add(pbStk2Pos8);
            pbStack2List.Add(pbStk2Pos9);
            pbStack2List.Add(pbStk2Pos10);
            pbStack2List.Add(pbStk2Pos11);
            pbStack2List.Add(pbStk2Pos12);

            pbStack3List.Add(pbStk3Pos0);
            pbStack3List.Add(pbStk3Pos1);
            pbStack3List.Add(pbStk3Pos2);
            pbStack3List.Add(pbStk3Pos3);
            pbStack3List.Add(pbStk3Pos4);
            pbStack3List.Add(pbStk3Pos5);
            pbStack3List.Add(pbStk3Pos6);
            pbStack3List.Add(pbStk3Pos7);
            pbStack3List.Add(pbStk3Pos8);
            pbStack3List.Add(pbStk3Pos9);
            pbStack3List.Add(pbStk3Pos10);
            pbStack3List.Add(pbStk3Pos11);
            pbStack3List.Add(pbStk3Pos12);

            // Adds each Panel object to a list.
            panelStackList.Add(pbStack0List);
            panelStackList.Add(pbStack1List);
            panelStackList.Add(pbStack2List);
            panelStackList.Add(pbStack3List);

            UpdateCardImages();
        }

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
            texsBox4.Text = "Selected Stack: " + selectedStack;
            testBox5.Text = "Count: " + currentGame.discardStack.Count;
        }

        private void UpdateCardImages()
        {
            foreach (List<PictureBox> pbStack in panelStackList)
            {
                int commonIndex = panelStackList.IndexOf(pbStack);
                Stack<int> intStack = currentGame.indexStacksList[commonIndex];

                int[] copyOfIntStack = intStack.ToArray();
                Array.Reverse(copyOfIntStack, 0, copyOfIntStack.Length);
                for (int i = 0; i < pbStack.Count; i++)
                {
                    if (i < intStack.Count)
                    {
                        int cardImageIndex = copyOfIntStack[i];
                        Image cardImage = imgListOrderedDeck.Images[cardImageIndex];
                        pbStack[i].Image = cardImage;
                        pbStack[i].BringToFront();
                        pbStack[i].Visible = true;
                    }
                    else 
                    {
                        pbStack[i].Image = null;
                        pbStack[i].Visible = false;
                    }
                }

                if (intStack.Count == 0)
                {
                    pbStack[0].BringToFront();
                    pbStack[0].Visible = true;
                }
            }

            if (currentGame.discardStack.Count > 0)
                pbDiscardStack.Image = imgListOrderedDeck.Images[currentGame.discardStack.Peek()];
            else
                pbDiscardStack.Image = null;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            currentGame.NewGame();
            
            /* VIEW
             * Show game is ready by displaying a "loaded deck" at PictureBox pbDeck,
             * and clearing images from PictureBoxes for all four positions and 
             * discardPile.
             */
            UpdateCardImages();
            pbDeck.Image = imgListCardBack.Images[0];
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

        private void pbDiscardPile_Click(object sender, EventArgs e)
        {
            if (selectedStack > -1)
            {
                currentGame.Discard(selectedStack);
                UpdateCardImages();
                selectedStack = -1;
            }
            UpdateTestBoxes();
        }

        private void pbCardImage_Click(object sender, EventArgs e)
        {
            PictureBox pbCardImage = (PictureBox)sender;
            int currentStackIndex = -1;
            foreach (List<PictureBox> panelStack in panelStackList)
            {
                if (panelStack.Contains(pbCardImage))
                {
                    currentStackIndex = panelStackList.IndexOf(panelStack);
                    break;
                }
            }
            
            Stack<int> currentStack = currentGame.indexStacksList[currentStackIndex];

            if (selectedStack > -1 && currentStack.Count == 0)
            {   
                currentGame.MoveCardTo(selectedStack, currentStackIndex);
                UpdateCardImages();
                selectedStack = -1;
            }
            else if (currentStack.Count > 0)
            {
                selectedStack = currentStackIndex;
            }
            UpdateTestBoxes();
        }

        private void pbCardImage_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pbCardImage = (PictureBox)sender;
            int currentStackIndex = -1;
            foreach (List<PictureBox> panelStack in panelStackList)
            {
                if (panelStack.Contains(pbCardImage))
                {
                    currentStackIndex = panelStackList.IndexOf(panelStack);
                    break;
                }
            }

            Stack<int> currentStack = currentGame.indexStacksList[currentStackIndex];

            if (currentStack.Count > 0)
            {
                currentGame.Discard(currentStackIndex);
                UpdateCardImages();
                selectedStack = -1;
            }
            UpdateTestBoxes();
        }
    }
}
