﻿/*
 *      *** Class Notes ***
 *      
 *  This class is used to create instances of a Card object
        - To create a Card Object you need to supply two strings arguments
            + The first is for the variable 'question'
            + The Second is for the variable 'answer'
        - You will then be able to get the value of these variables through the Card Objects Method.
*/

//      *** Import Statements ***
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_Card
{
    public class Card
    {
        //Fields
        private string question, answer;  //These hold the question and the answer for this card

        //Constructor
        public Card(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }

        //Returns the question
        public string getQuestion() { return question; }

        //Returns the answer
        public string getAnswer() { return answer; }

        //Sets the question
        public void setQuestion(string question)
        {
            this.question = question;
        }

        //Sets the answer
        public void setAnswer(string answer)
        {
            this.answer = answer;
        }
    }
}
