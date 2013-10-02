using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solitaire
{
    class allAcesGame
    {
        public Stack<int> stack0 = new Stack<int>();
        public Stack<int> stack1 = new Stack<int>();
        public Stack<int> stack2 = new Stack<int>();
        public Stack<int> stack3 = new Stack<int>();
        public Stack<int> discardStack = new Stack<int>();
        public List<Stack<int>> indexStacksList = new List<Stack<int>>();
        
        public Stack<int> shuffledDeckIndex = new Stack<int>();

        public List<playingCard> playingCardDeck = new List<playingCard>();
        public string[] suitList = new string[] { "club", "diamond", 
                                                  "heart", "spade" };

        public allAcesGame()
        {
            // Adds each position stacks to positions list.
            this.indexStacksList.Add(stack0);
            this.indexStacksList.Add(stack1);
            this.indexStacksList.Add(stack2);
            this.indexStacksList.Add(stack3);
            this.indexStacksList.Add(discardStack);

            /* CREATE DATA MODEL FOR CARD IMAGES IN IMGLIST
             * Create instances of playingCard object with value and suit 
             * that corresponds to the image kept in imgListGameDeck.
             */
            for (int i = 0; i < this.suitList.Length; i++)
            {
                string suit = this.suitList[i];
                for (int value = 2; value <= 14; value++)
                {
                    playingCard card = new playingCard (value, suit);
                    this.playingCardDeck.Add(card);
                }
            }
        }

        public void NewGame()
        {
            /* RESET GAME STACKS
             * Clear position index stacks (poition1 through position4),
             * discardPile and shuffledDeck.
             */
            shuffledDeckIndex.Clear();            
            foreach (Stack<int> position in this.indexStacksList)
                position.Clear();

            /* CREATE ORDERED LIST OF CARD INDICES
             * Creates an ordered list "orderedDeckIndex" with indeces 0 - 51.
             * This ordered list will be used to create a "shuffled deck"
             */
            List<int> orderedDeckIndex = new List<int>();
            for (int i = 0; i < 52; i++)
            {
                orderedDeckIndex.Add(i);
            }

            /* CREATE NEW SHUFFLED DECK
             * Take random indices from orderedDeckInex and add to gameDeckIndex
             * stack without any repeating indeces. */
            Random rndCardIndex = new Random();            
            for (int i = 0; i < 52; i++)
            {
                int newCardIndex = rndCardIndex.Next(orderedDeckIndex.Count - 1);
                this.shuffledDeckIndex.Push(orderedDeckIndex[newCardIndex]);
                orderedDeckIndex.RemoveAt(newCardIndex);
            }
        }

        public void DealHand()
        {
            // Check if there are card indeces loaded in the gameDeckIndex stack. 
            if (this.shuffledDeckIndex.Count > 0)
            {
                /* Take a card index out of the deck (shuffledDeckIndex) and push
                 * one index onto each position of the four position stacks.
                 */
                int dealCardIndex;
                for (int i = 0; i < 4; i++)
                {
                    dealCardIndex = this.shuffledDeckIndex.Pop();
                    this.indexStacksList[i].Push(dealCardIndex);
                }
            }
        }

        public void MoveCardTo(int startStack, int endStack)
        {
            int cardIndex = this.indexStacksList[startStack].Pop();
            this.indexStacksList[endStack].Push(cardIndex);
        }
    }
}