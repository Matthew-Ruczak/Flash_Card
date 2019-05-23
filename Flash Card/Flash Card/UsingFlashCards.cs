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
    public partial class UsingFlashCards : Form
    {
        //Fields
        private ListOfCards listOfCards = new ListOfCards();
        private string currentAnswer;


        public UsingFlashCards()
        {
            InitializeComponent();

            //Test cards (Only for testing, remove when finished)
            listOfCards.addCard(new Card("What year did Canada become a country?", "1867"));
            listOfCards.addCard(new Card("What is the capital of Canada?", "Ottawa"));
            listOfCards.addCard(new Card("What colours are in the Canadian Flag?", "Red and White"));

            //Loading first question when the form loads
            loadQuestion(listOfCards.getNextCard());
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            loadQuestion(listOfCards.getNextCard());
        }

        private void btnPreviousQuestion_Click(object sender, EventArgs e)
        {
            loadQuestion(listOfCards.getPreviousCard());
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            richTextBoxAnswer.Text = currentAnswer;
        }

        private void loadQuestion(Card c)
        {
            richTextBoxQuestion.Text = c.getQuestion();
            richTextBoxAnswer.Text = "Click button below to reveal!";
            currentAnswer = c.getAnswer();
        }
    }
}
