﻿namespace Flash_Card
{
    partial class UsingFlashCards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.btnShowAnswer = new System.Windows.Forms.Button();
            this.btnNextQuestion = new System.Windows.Forms.Button();
            this.btnPreviousQuestion = new System.Windows.Forms.Button();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelCardCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(73, 53);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.ReadOnly = true;
            this.richTextBoxQuestion.Size = new System.Drawing.Size(340, 78);
            this.richTextBoxQuestion.TabIndex = 0;
            this.richTextBoxQuestion.TabStop = false;
            this.richTextBoxQuestion.Text = "";
            this.richTextBoxQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.Location = new System.Drawing.Point(73, 179);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(340, 78);
            this.richTextBoxAnswer.TabIndex = 1;
            this.richTextBoxAnswer.TabStop = false;
            this.richTextBoxAnswer.Text = "";
            this.richTextBoxAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            // 
            // btnShowAnswer
            // 
            this.btnShowAnswer.Location = new System.Drawing.Point(174, 289);
            this.btnShowAnswer.Name = "btnShowAnswer";
            this.btnShowAnswer.Size = new System.Drawing.Size(135, 23);
            this.btnShowAnswer.TabIndex = 2;
            this.btnShowAnswer.TabStop = false;
            this.btnShowAnswer.Text = "Show Answer";
            this.btnShowAnswer.UseVisualStyleBackColor = true;
            this.btnShowAnswer.Click += new System.EventHandler(this.btnShowAnswer_Click);
            this.btnShowAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            // 
            // btnNextQuestion
            // 
            this.btnNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextQuestion.Location = new System.Drawing.Point(419, 63);
            this.btnNextQuestion.Name = "btnNextQuestion";
            this.btnNextQuestion.Size = new System.Drawing.Size(57, 184);
            this.btnNextQuestion.TabIndex = 3;
            this.btnNextQuestion.TabStop = false;
            this.btnNextQuestion.Text = ">";
            this.btnNextQuestion.UseVisualStyleBackColor = true;
            this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
            this.btnNextQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            // 
            // btnPreviousQuestion
            // 
            this.btnPreviousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousQuestion.Location = new System.Drawing.Point(10, 63);
            this.btnPreviousQuestion.Name = "btnPreviousQuestion";
            this.btnPreviousQuestion.Size = new System.Drawing.Size(57, 184);
            this.btnPreviousQuestion.TabIndex = 4;
            this.btnPreviousQuestion.TabStop = false;
            this.btnPreviousQuestion.Text = "<";
            this.btnPreviousQuestion.UseVisualStyleBackColor = true;
            this.btnPreviousQuestion.Click += new System.EventHandler(this.btnPreviousQuestion_Click);
            this.btnPreviousQuestion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.Location = new System.Drawing.Point(194, 26);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(94, 24);
            this.labelInfo1.TabIndex = 5;
            this.labelInfo1.Text = "Question";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.Location = new System.Drawing.Point(201, 152);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(80, 24);
            this.labelInfo2.TabIndex = 6;
            this.labelInfo2.Text = "Answer";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "JSON|*.json";
            // 
            // labelCardCounter
            // 
            this.labelCardCounter.AutoSize = true;
            this.labelCardCounter.Location = new System.Drawing.Point(226, 260);
            this.labelCardCounter.Name = "labelCardCounter";
            this.labelCardCounter.Size = new System.Drawing.Size(30, 13);
            this.labelCardCounter.TabIndex = 7;
            this.labelCardCounter.Text = "0 / 0";
            // 
            // UsingFlashCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 324);
            this.Controls.Add(this.labelCardCounter);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.btnPreviousQuestion);
            this.Controls.Add(this.btnNextQuestion);
            this.Controls.Add(this.btnShowAnswer);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.richTextBoxQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "UsingFlashCards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card: nameOfFlashCard";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsingFlashCards_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private System.Windows.Forms.Button btnShowAnswer;
        private System.Windows.Forms.Button btnNextQuestion;
        private System.Windows.Forms.Button btnPreviousQuestion;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label labelCardCounter;
    }
}