namespace Flash_Card
{
    partial class MainMenu
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
            this.btnCreateFlashCard = new System.Windows.Forms.Button();
            this.btnOpenExistingFlashCard = new System.Windows.Forms.Button();
            this.btnModifyExistingFlashCard = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnCreateFlashCard
            // 
            this.btnCreateFlashCard.Location = new System.Drawing.Point(12, 25);
            this.btnCreateFlashCard.Name = "btnCreateFlashCard";
            this.btnCreateFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnCreateFlashCard.TabIndex = 0;
            this.btnCreateFlashCard.Text = "Create Flash Card";
            this.btnCreateFlashCard.UseVisualStyleBackColor = true;
            this.btnCreateFlashCard.Click += new System.EventHandler(this.btnCreateFlashCard_Click);
            // 
            // btnOpenExistingFlashCard
            // 
            this.btnOpenExistingFlashCard.Location = new System.Drawing.Point(118, 25);
            this.btnOpenExistingFlashCard.Name = "btnOpenExistingFlashCard";
            this.btnOpenExistingFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnOpenExistingFlashCard.TabIndex = 1;
            this.btnOpenExistingFlashCard.Text = "Open Existing Flash Card";
            this.btnOpenExistingFlashCard.UseVisualStyleBackColor = true;
            this.btnOpenExistingFlashCard.Click += new System.EventHandler(this.btnOpenExistingFlashCard_Click);
            // 
            // btnModifyExistingFlashCard
            // 
            this.btnModifyExistingFlashCard.Location = new System.Drawing.Point(224, 25);
            this.btnModifyExistingFlashCard.Name = "btnModifyExistingFlashCard";
            this.btnModifyExistingFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnModifyExistingFlashCard.TabIndex = 2;
            this.btnModifyExistingFlashCard.Text = "Modifying Existing Flash Card";
            this.btnModifyExistingFlashCard.UseVisualStyleBackColor = true;
            this.btnModifyExistingFlashCard.Click += new System.EventHandler(this.btnModifyExistingFlashCard_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON|*.json";
            this.openFileDialog.Title = "Open Existing Flash Cards";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 137);
            this.Controls.Add(this.btnModifyExistingFlashCard);
            this.Controls.Add(this.btnOpenExistingFlashCard);
            this.Controls.Add(this.btnCreateFlashCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flash Card: Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFlashCard;
        private System.Windows.Forms.Button btnOpenExistingFlashCard;
        private System.Windows.Forms.Button btnModifyExistingFlashCard;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

