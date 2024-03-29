﻿using System;
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
    public partial class AddCard : Form
    {
        //Field
        public string question { get; set; }    //Will hold the question that will be accessible from outside this form
        public string answer { get; set; }      //Will hold the answer that will be accessible from outside this form

        //This is for adding a new card
        public AddCard()
        {
            InitializeComponent();
        }

        //This is for modifying an existing card
        public AddCard(string question, string answer)
        {
            InitializeComponent();

            //Changing the name of the form
            this.Text = "Modify Question";
            btnAdd.Text = "Modify";

            //Setting the question and the answer in the textboxs, of the card the user is modifying
            textBoxQuestion.Text = question;
            textBoxAnswer.Text = answer;
        }

        //An event handler that executes when the user clicks the add button
        //It then return an okay signal to the CreateAndModify form to read the public variables in this form
        private void btnAdd_Click(object sender, EventArgs e)
        {
            question = textBoxQuestion.Text;
            answer = textBoxAnswer.Text;
        }
    }
}
