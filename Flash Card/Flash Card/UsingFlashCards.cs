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
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Flash_Card
{
    public partial class UsingFlashCards : Form
    {
        //Fields
        private ListOfCards listOfCards = new ListOfCards();    //The list of cards the user will be using
        private string currentAnswer;   //Holds the answer to the question
        private string answerHiddenMessage; //This holds the message that will be displayed when the answer is hidden
        private bool answerShown;   //Tells us whether the answer is being shown


        public UsingFlashCards(ListOfCards c, string fileName)
        {
            InitializeComponent();

            //Setting the name of the form
            this.Text = "Flash Card: " + fileName;

            //Putting the Card into the listOfCards
            listOfCards = c;

            //Setting variable to there default
            answerShown = false;    //This is becuase the answer is first hidden
            answerHiddenMessage = "Click the button below to reveal!";  //This is the message that will be displayed when the answer is hidden

            //Loading first question when the form loads
            loadQuestion(listOfCards.getNextCard());

        }

        //An event handler that executes when the "Next" button is pressed
        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            loadQuestion(listOfCards.getNextCard());
        }
        //An event handler that executes when the "Previous" button is pressed
        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            loadQuestion(listOfCards.getPreviousCard());
        }
        //An event handler that executes when the "Show Answer" button is pressed
        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            //Check if the answer is already being shown
            if (answerShown)
            {
                //Hidding the answer
                richTextBoxAnswer.Text = answerHiddenMessage;
                btnShowAnswer.Text = "Show Answer";
                answerShown = false;
            }
            else
            {
                //Showing the answer
                richTextBoxAnswer.Text = currentAnswer;
                btnShowAnswer.Text = "Hide Answer";
                answerShown = true;
            }
        }
        //Loads the question in to the form (Hides the answer until the user wants to reveal it)
        private void loadQuestion(Card c)
        {
            richTextBoxQuestion.Text = c.getQuestion();     //Displaying the Question in the question rich text box
            richTextBoxAnswer.Text = answerHiddenMessage;   //Instructions to the user
            answerShown = false;    //Setting the boolean answerShown to false
            btnShowAnswer.Text = "Show Answer";
            currentAnswer = c.getAnswer();  //Storing the answer to the question, so it can be revealed when the user wants it

            //Updating the counter that shows the user what card they are on, out of the total number of cards
            labelCardCounter.Text = (listOfCards.getCurrentPosition() + 1) + " / " + listOfCards.getNumOfCards();
        }

        //Handles the Hotkeys
        private void UsingFlashCards_KeyDown(object sender, KeyEventArgs e)
        {
            //Determining the action the key that was press represents
            switch (e.KeyValue.ToString().ToUpper())
            {
                //Previous Question Hotkey (Currently set to "A")
                case "65": btnPreviousQuestion_Click(null, null);
                    break;
                //Next Question Hotkey (Currently set to "D")
                case "68": btnNextQuestion_Click(null, null);
                    break;
                //Up Arrow Key (Currently set to "S")
                case "83": btnShowAnswer_Click(null, null);
                    break;
            }
        }
    }
}
