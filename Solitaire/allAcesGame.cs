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

        public List<int> orderedDeckIndex = new List<int>();
        public List<int> copyOrderedDeckIndex;
        public Stack<int> shuffledDeckIndex = new Stack<int>();

        public List<PlayingCard> playingCardDeck = new List<PlayingCard>();
        public string[] suitList = new string[] { "Clubs", "Diamnds", 
                                                  "Hearts", "Spades" };

        public allAcesGame()
        {
            // Adds each position stacks to positions list.
            indexStacksList.Add(stack0);
            indexStacksList.Add(stack1);
            indexStacksList.Add(stack2);
            indexStacksList.Add(stack3);

            CreatePlayingCardDeck();
            CreateOrderedIndexDeck();
        }

        private void CreatePlayingCardDeck()
        {
            /* CREATE DATA MODEL FOR CARD IMAGES IN IMGLIST
             * Create instances of playingCard object with value and suit 
             * that corresponds to the image kept in imgListGameDeck.
             */
            for (int i = 0; i < this.suitList.Length; i++)
            {
                string suit = this.suitList[i];
                for (int value = 2; value <= 14; value++)
                {
                    PlayingCard card = new PlayingCard(value, suit);
                    this.playingCardDeck.Add(card);
                }
            }
        }

        private void CreateOrderedIndexDeck()
        {
            /* CREATE ORDERED LIST OF CARD INDICES
             * Creates an ordered list "orderedDeckIndex" with indeces 0 - 51.
             * This ordered list will be used to create a "shuffled deck"
             */
            for (int i = 0; i < 52; i++)
            {
                orderedDeckIndex.Add(i);
            }
        }

        private void CreateNewShuffledDeckIndex()
        {
            /* CREATE NEW SHUFFLED DECK
                * Take random indices from orderedDeckInex and add to gameDeckIndex
                * stack without any repeating indeces. */

            copyOrderedDeckIndex = orderedDeckIndex.ToList();
            Random rndCardIndex = new Random();

            for (int i = 0; i < 52; i++)
            {
                int newCardIndex = rndCardIndex.Next(copyOrderedDeckIndex.Count);
                this.shuffledDeckIndex.Push(copyOrderedDeckIndex[newCardIndex]);
                copyOrderedDeckIndex.RemoveAt(newCardIndex);
            }
        }

        private void ClearAllStacks()
        {
            /* RESET GAME STACKS
             * Clear position index stacks (poition1 through position4),
             * discardPile and shuffledDeck.
             */
            shuffledDeckIndex.Clear();
            discardStack.Clear();
            foreach (Stack<int> indexStack in this.indexStacksList)
                indexStack.Clear();
        }

        public void NewGame()
        {
            /* Creates a new game by deleteing game stacks and creating
            * a new "shuffled" deck of cards. */
            ClearAllStacks();
            CreateNewShuffledDeckIndex();            
        }
        
        public void DealHand()
        {            
            /* Take a card index out of the deck (shuffledDeckIndex) and push
             * one index onto each position of the four position stacks. */
            int dealCardIndex;
            for (int i = 0; i < 4; i++)
            {
                dealCardIndex = this.shuffledDeckIndex.Pop();
                this.indexStacksList[i].Push(dealCardIndex);
            }            
        }

        public void MoveCardTo(int startingCardPosition, int endingCardPosition)
        {
            /* Pops card from one game stack and pushes it onto another game
            * stack. */
            int cardIndexToMove = indexStacksList[startingCardPosition].Pop();
            indexStacksList[endingCardPosition].Push(cardIndexToMove);
        }

        public void DiscardCardIndex(int selectedStackIndex)
        {
            // Pops card from one game stack and pushes it onto the discard pile.
            int discardCardIndex = indexStacksList[selectedStackIndex].Pop();
            discardStack.Push(discardCardIndex);
        }   
    }
}