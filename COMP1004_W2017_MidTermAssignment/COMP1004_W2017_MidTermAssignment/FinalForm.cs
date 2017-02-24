using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssignment
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }


        //Calls the variable that fills all the read only text boxes with information gathered from other forms
        //Done this way instead of one at a time to maximize cpu and uses less space.
        private void FinalForm_Load(object sender, EventArgs e)
        {
            Stats();
            if (raceTextBox.Text == "Human")
            {
                pictureBox.Image = Properties.Resources.Human;
            }
            else if (raceTextBox.Text == "Elf")
            {
                pictureBox.Image = Properties.Resources.Elf;
            }
            else if (raceTextBox.Text == "Dwarf")
            {
                pictureBox.Image = Properties.Resources.dwarf;
            }
            else if (raceTextBox.Text == "Halfling")
            {
                pictureBox.Image = Properties.Resources.Halfling;
            }
        }

        /// <summary>
        /// this method sends the message to printer for printing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Printing.....");
        }

        /// <summary>
        /// this method helps to exit from the running program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// this method changes the font of the labels and the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowDialog();
            textBox1.Font = fontDialog.Font;
            textBox2.Font = fontDialog.Font;
            textBox3.Font = fontDialog.Font;
            textBox4.Font = fontDialog.Font;
            jobTextBox.Font = fontDialog.Font;
            raceTextBox.Font = fontDialog.Font;
            healthTextBox.Font = fontDialog.Font;
            nameLabel.Font = fontDialog.Font;
            ageLabel.Font = fontDialog.Font;
            heightLabel.Font = fontDialog.Font;
            weightLabel.Font = fontDialog.Font;
            jobLabel.Font = fontDialog.Font;
            raceLabel.Font = fontDialog.Font;
            healthPointsLabel.Font = fontDialog.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutBox = new AboutBox();

            AboutBox.ShowDialog();
        }

        public void Stats()
        {
            healthTextBox.Text = Program.val.Health;
            raceTextBox.Text = Program.val.Race;
            jobTextBox.Text = Program.val.Job;
            STRTextBox.Text = Program.val.STR;
            DEXTextBox.Text = Program.val.DEX;
            ENDTextBox.Text = Program.val.END;
            INTTextBox.Text = Program.val.INT;
            PERTextBox.Text = Program.val.PER;
            CHATextBox.Text = Program.val.CHA;
        }
    }
}
