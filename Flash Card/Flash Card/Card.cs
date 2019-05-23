using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flash_Card
{
    class Card
    {
        //Fields
        private string question, answer; //These hold the question and the answer for this card

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
    }
}
