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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        //An event handler that executes when the "Open Existing Flash Card" button is pressed
        private void btnOpenExistingFlashCard_Click(object sender, EventArgs e)
        {
            UsingFlashCards frm = new UsingFlashCards();
            frm.Show();
        }
        //An event handler that executes when the "Create Flash Card" button is pressed
        private void btnCreateFlashCard_Click(object sender, EventArgs e)
        {
            CreateAndModify frm = new CreateAndModify();
            frm.Show();
        }
        //An event handler that executes when the "Modify Existing Flash Card" button is pressed
        private void btnModifyExistingFlashCard_Click(object sender, EventArgs e)
        {
            try
            {
                //Showing Dialog to select file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //opening and reading the file
                    CreateAndModify frm = new CreateAndModify(ReadAndWriteToFile.readFromFile(openFileDialog.FileName));
                    //Displaying the 'CreateAndModify' form, with the cards inside of it
                    frm.Show();
                }
            }
            catch (Exception err)
            {
                //Displaying the error that occurred
                MessageBox.Show("Error: " + err);
            }
        }
    }
}
