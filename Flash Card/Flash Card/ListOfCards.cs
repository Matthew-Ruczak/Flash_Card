using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Flash_Card
{
    class ListOfCards
    {
        //Fields
        private ArrayList listOfCards = new ArrayList();
        private int currentPosition = -1;
        
        //Constructor 1 (Takes not arguments)
        public ListOfCards()
        {
        }

        //Constructor 2 (Takes a existing ArrayList of Cards)
        //      **** Note ****
        //  No validation is done for this constructor and should only be used for testing purposes
        public ListOfCards(ArrayList listOfCards)
        {
            this.listOfCards = listOfCards;
        }

        //Getting the total number of cards in the list
        public int getNumOfCards() { return listOfCards.Count; }

        //Getting the current position
        public int getCurrentPosition() { return currentPosition; }

        //Getting the Card at a certain position (Will return a null card if it is not valid)
        public Card getCardAt(int num) {
            //Checking if the requested card # is valid
            if (num < (getCurrentPosition() - 1) && num >= 0)   //Check if the num is greater than the # of items in the ArrayList or less than 0
                return (Card)listOfCards[num];
            else
                return null;
        }

        //Getting the next card
        public Card getNextCard()
        {
            //Checking if we are at the end of the of the array of cards
            if (currentPosition == (listOfCards.Count - 1)){ //Minusing 1 from listOfCards because currentPosition starts at 0
                //Setting current position to -1 so we start from the beginning
                currentPosition = -1;
            }
            //Returning the card at the currentPosition + 1 
            //  (Also incrementing currentPosition plus 1, to reflect the new current position)
            return (Card)listOfCards[++currentPosition]; //Casting the object at the position to be of type Card
        }

        //Getting the previous card
        public Card getPreviousCard()
        {
            //Checking if we are at the beginning of the array of cards
            if (currentPosition == 0)
            {
                //Setting current position to the end of the array of cards
                currentPosition = listOfCards.Count; // Not Minusing 1 from listOfCards becuase it will be minused below when returned
            }
            //Returning the card at the currentPostion - 1
            //  (Also decrementing currentPosition by 1 to reflect the new current position)
            return (Card)listOfCards[--currentPosition]; //Casting the object at the position to be of type Card
        }

        //Add's a card to the list
        public void addCard(Card c)
        {
            listOfCards.Add(c);
        }

        //Remove's a card from the list
        public Boolean removeCard(Card c)
        {
            try
            {
                listOfCards.Remove(c);
                return true; //Returning true tells us it was removed
            }
            catch
            {
                return false; //Returing false tells us that it was not
            }
        }
    }
}
