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
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {

            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }

            return result;
        }


        //In essence rolls 3, 10 sided die and inputs the string value into appropriate text boxes

        private void RollAbilities()
        {
            STRTextBox.Text = this.Roll3D10().ToString();
            DEXTextBox.Text = this.Roll3D10().ToString();
            ENDTextBox.Text = this.Roll3D10().ToString();
            INTTextBox.Text = this.Roll3D10().ToString();
            PERTextBox.Text = this.Roll3D10().ToString();
            CHATextBox.Text = this.Roll3D10().ToString();
        }


        private void RollButton_Click(object sender, EventArgs e)
        {
            RollAbilities();
            
        }


        //Inputs the proper information to Character.cs then switches the forms. Uses try Catch for validation
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            try
            {

                character.STR = STRTextBox.Text;
                character.DEX = DEXTextBox.Text;
                character.END = ENDTextBox.Text;
                character.INT = INTTextBox.Text;
                character.PER = PERTextBox.Text;
                character.CHA = CHATextBox.Text;

                if (STRTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (DEXTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (ENDTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (INTTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (PERTextBox.Text == "")
                {
                    throw new Exception();
                }
                if (CHATextBox.Text == "")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please fill in a valid Response or press roll");
                return;
            }
            this.Hide();

            RaceForm raceForm = new RaceForm();

            raceForm.previousForm = this;

            raceForm.Show();
        }
    }
}
