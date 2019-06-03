/*
 *      *** Class Notes ***
*/

//      *** Import Statements ***
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flash_Card
{
    public partial class CreateAndModify : Form
    {
        //Holds the list of Cards currently being worked on
        ListOfCards listOfCards;


        //Constructor #1 (for creating a new set of flash cards)
        public CreateAndModify()
        {
            InitializeComponent();

            //creating a new list of cards (empty)
            listOfCards = new ListOfCards();
        }

        //Constructor #2 (for modifying an existing set of flash cards)
        public CreateAndModify(Object listOfCards)  //Takes an Object because it does not like that it when it is of type ListOfCards
        {
            this.listOfCards = (ListOfCards)listOfCards;    //Casting the object to be a list of cards
        }

        //An event hanlder that executes when the user click's on the add button
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creating an instance of the add card form to get input from the user
            AddCard addFrm = new AddCard();

            //Displaying form and waiting till the user has finished entering the their input
            if (addFrm.ShowDialog(this) == DialogResult.OK)
            {
                // *** Need to add validation ***

                //Adding the new card based on the public variables (holds the user's input)
                listOfCards.addCard(new Card(addFrm.question, addFrm.answer));

                //Adding the new card to the list
                listBoxOfQuestions.Items.Add(listOfCards.getNumOfCards() + ". " + addFrm.question);
            }
        }

        //An event handler that executes when the user click's on the delete button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Checking if the user has nothing selected in the listBox
            if (listBoxOfQuestions.SelectedIndex <= -1)       //*** Need to test this ***
            {
                MessageBox.Show("Please select something to delete in the list first!");
            }
            else
            {
                try
                {
                    //Finding the item the user has selected in 'listOfCards'
                    Card selectedCard = listOfCards.getCardAt(listBoxOfQuestions.SelectedIndex);

                    //Checking if the item the user has selected exists (not null)
                    if (selectedCard != null)
                    {
                        //removing selected card
                        listBoxOfQuestions.Items.RemoveAt(listBoxOfQuestions.SelectedIndex);    //Removing it from the listBox
                        listOfCards.removeCard(selectedCard);   //Removing it from the list of cards
                    }
                    else
                    {
                        //Telling the user an error has happened
                        MessageBox.Show("The card you have selected was not deleted becuase of an error (1)");
                    }
                }
                catch
                {
                    //Telling the user an error has happened
                    MessageBox.Show("The card you have selected was not deleted becuase of an error (2)");
                }
            }
        }
    }
}
