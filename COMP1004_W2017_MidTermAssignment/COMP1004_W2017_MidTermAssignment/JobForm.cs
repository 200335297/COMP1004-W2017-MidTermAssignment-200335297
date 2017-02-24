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
        private string _Job;

        private int _DexterityHealthMod = Convert.ToInt32(Program.val.DEX);
        private int _EnduranceHealthMod = Convert.ToInt32(Program.val.END);
        private int _IntellegenceHealthMod = Convert.ToInt32(Program.val.INT);
        private int _CharismaHealthMod = Convert.ToInt32(Program.val.CHA);



        public JobForm()
        {
            InitializeComponent();
            this._initialload();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Value character = Program.val;

            character.Health = healthPointTextBox.Text;
            character.Job = this._Job;

            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
        private void _initialload()
        {
            healthPointTextBox.Text = (this._Soldier + _EnduranceHealthMod).ToString();
            this._Job = "Soilder";

        }

      
        private void RadioButton_CheckeChanged(object sender, EventArgs e)
        {
            RadioButton selected = sender as RadioButton;
            switch (selected.Text)
            {
                case "Soldier":
                    healthPointTextBox.Text = (this._Soldier + _EnduranceHealthMod).ToString();
                    this._Job = selected.Text;
                    break;
                case "Rogue":
                    healthPointTextBox.Text = (this._Rogue + _DexterityHealthMod).ToString();
                    this._Job = selected.Text;
                    break;
                case "Magicker":
                    healthPointTextBox.Text = (this._Magicker + _IntellegenceHealthMod).ToString();
                    this._Job = selected.Text;
                    break;
                case "Cultist":
                    healthPointTextBox.Text = (this._Cultist + _CharismaHealthMod).ToString();
                    this._Job = selected.Text;
                    break;
            }

        }
    }
}
