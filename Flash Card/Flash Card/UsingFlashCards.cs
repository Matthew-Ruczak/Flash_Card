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
        private string answerHiddenMessage = "Click the button below to reveal!";
        private bool answerShown;    //Tells us whether the answer is being shown


        public UsingFlashCards()
        {
            InitializeComponent();

            ////Test cards (Only for testing, remove when finished)
            //listOfCards.addCard(new Card("What year did Canada become a country?", "1867"));
            //listOfCards.addCard(new Card("What is the capital of Canada?", "Ottawa"));
            //listOfCards.addCard(new Card("What colours are in the Canadian Flag?", "Red and White"));

            //Opens a dialog for the user to select the file they would like to open (Still testing)
            openFileAndLoadQuestions();

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
            btnShowAnswer.Text = "Show Answer";
            currentAnswer = c.getAnswer();  //Storing the answer to the question, so it can be revealed when the user wants it
        }

        //Opening the file that contain the questions
        private void openFileAndLoadQuestions()
        {
            try
            {
                //Displaying Dialog box to user, and waiting from them to selected a file
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Reading the file and converting it in to a 'ListOfCards'
                    listOfCards = ReadAndWriteToFile.readFromFile(openFileDialog.FileName);
                }
                //Telling the user the file was successully opened
                MessageBox.Show("File was successfully opened!");
            }
            catch (Exception e) //An error occurred, displaying error message in a messagebox
            {
                MessageBox.Show("Error: " + e.Message);
            }
            
        }
    }
}
