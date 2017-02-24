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
    public partial class JobForm : Form
    {

        public RaceForm previousForm;

        private int _Soldier = 30;
        private int _Rogue = 28;
        private int _Magicker = 15;
        private int _Cultist = 24;


        private int _DexterityHealthMod = Convert.ToInt32(Program.character.DEX);
        private int _EnduranceHealthMod = Convert.ToInt32(Program.character.END);
        private int _IntellegenceHealthMod = Convert.ToInt32(Program.character.INT);
        private int _CharismaHealthMod = Convert.ToInt32(Program.character.CHA);



        public JobForm()
        {
            InitializeComponent();
            this._initialload();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Health = healthPointTextBox.Text;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
        private void _initialload()
        {
            healthPointTextBox.Text = (this._Soldier + _EnduranceHealthMod).ToString();

        }

      
        private void RadioButton_CheckeChanged(object sender, EventArgs e)
        {
            RadioButton selected = sender as RadioButton;
            switch (selected.Text)
            {
                case "Soldier":
                    healthPointTextBox.Text = (this._Soldier + _EnduranceHealthMod).ToString();
                    break;
                case "Rogue":
                    healthPointTextBox.Text = (this._Rogue + _DexterityHealthMod).ToString();
                    break;
                case "Magicker":
                    healthPointTextBox.Text = (this._Magicker + _IntellegenceHealthMod).ToString();
                    break;
                case "Cultist":
                    healthPointTextBox.Text = (this._Cultist + _CharismaHealthMod).ToString();
                    break;
            }

        }
    }
}
