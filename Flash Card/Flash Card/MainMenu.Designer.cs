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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToCreateFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseFlashCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUpdateTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateFlashCard
            // 
            this.btnCreateFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateFlashCard.Location = new System.Drawing.Point(12, 34);
            this.btnCreateFlashCard.Name = "btnCreateFlashCard";
            this.btnCreateFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnCreateFlashCard.TabIndex = 0;
            this.btnCreateFlashCard.Text = "Create FlashCardz";
            this.btnCreateFlashCard.UseVisualStyleBackColor = true;
            this.btnCreateFlashCard.Click += new System.EventHandler(this.btnCreateFlashCard_Click);
            // 
            // btnOpenExistingFlashCard
            // 
            this.btnOpenExistingFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenExistingFlashCard.Location = new System.Drawing.Point(118, 34);
            this.btnOpenExistingFlashCard.Name = "btnOpenExistingFlashCard";
            this.btnOpenExistingFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnOpenExistingFlashCard.TabIndex = 1;
            this.btnOpenExistingFlashCard.Text = "Open FlashCardz";
            this.btnOpenExistingFlashCard.UseVisualStyleBackColor = true;
            this.btnOpenExistingFlashCard.Click += new System.EventHandler(this.btnOpenExistingFlashCard_Click);
            // 
            // btnModifyExistingFlashCard
            // 
            this.btnModifyExistingFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyExistingFlashCard.Location = new System.Drawing.Point(224, 34);
            this.btnModifyExistingFlashCard.Name = "btnModifyExistingFlashCard";
            this.btnModifyExistingFlashCard.Size = new System.Drawing.Size(100, 100);
            this.btnModifyExistingFlashCard.TabIndex = 2;
            this.btnModifyExistingFlashCard.Text = "Modifying FlashCardz";
            this.btnModifyExistingFlashCard.UseVisualStyleBackColor = true;
            this.btnModifyExistingFlashCard.Click += new System.EventHandler(this.btnModifyExistingFlashCard_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "JSON|*.json";
            this.openFileDialog.Title = "Open Existing Flash Cards";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToCreateFlashCardsToolStripMenuItem,
            this.howToUseFlashCardsToolStripMenuItem,
            this.howToUpdateTheProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToCreateFlashCardsToolStripMenuItem
            // 
            this.howToCreateFlashCardsToolStripMenuItem.Name = "howToCreateFlashCardsToolStripMenuItem";
            this.howToCreateFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.howToCreateFlashCardsToolStripMenuItem.Text = "How to create flash cards?";
            // 
            // howToUseFlashCardsToolStripMenuItem
            // 
            this.howToUseFlashCardsToolStripMenuItem.Name = "howToUseFlashCardsToolStripMenuItem";
            this.howToUseFlashCardsToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.howToUseFlashCardsToolStripMenuItem.Text = "How to use flash cards?";
            // 
            // howToUpdateTheProgramToolStripMenuItem
            // 
            this.howToUpdateTheProgramToolStripMenuItem.Name = "howToUpdateTheProgramToolStripMenuItem";
            this.howToUpdateTheProgramToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.howToUpdateTheProgramToolStripMenuItem.Text = "How to update the program?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 143);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(330, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "470 Studios";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 165);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnModifyExistingFlashCard);
            this.Controls.Add(this.btnOpenExistingFlashCard);
            this.Controls.Add(this.btnCreateFlashCard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlashCardz: Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateFlashCard;
        private System.Windows.Forms.Button btnOpenExistingFlashCard;
        private System.Windows.Forms.Button btnModifyExistingFlashCard;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToCreateFlashCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseFlashCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUpdateTheProgramToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

