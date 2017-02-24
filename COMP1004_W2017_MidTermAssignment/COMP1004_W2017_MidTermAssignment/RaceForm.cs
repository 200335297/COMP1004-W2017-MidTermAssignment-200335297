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
    public partial class RaceForm : Form
    {

        public AbilityForm previousForm;
        private string _Race;        //instance variables

        private int _StrengthMod = Convert.ToInt32(Program.character.STR);
        private int _DexterityMod = Convert.ToInt32(Program.character.DEX);
        private int _EnduranceMod = Convert.ToInt32(Program.character.END);
        private int _IntellegenceMod = Convert.ToInt32(Program.character.INT);
        private int _PerceptionMod = Convert.ToInt32(Program.character.PER);
        private int _CharismaMod = Convert.ToInt32(Program.character.CHA);


        public RaceForm()
        {
            InitializeComponent();
          this._initialload();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = _Race;


            JobForm jobForm = new JobForm();
            jobForm.previousForm = this;

            jobForm.Show();
            this.Hide();
        }

        private void _initialload()
        {
            CharacterPictureBox.Image = Properties.Resources.Human;
            

            RacialBonusTextBox.Text = "Increase all abilities by 5";

            _StrengthMod = _StrengthMod + 5;
            _DexterityMod = _DexterityMod + 5;
            _EnduranceMod = _EnduranceMod + 5;
            _IntellegenceMod = _IntellegenceMod + 5;
            _PerceptionMod = _PerceptionMod + 5;
            _CharismaMod = _CharismaMod + 5;


            this._Race = "Human";
        }

        private void HumanRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.Human;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase all abilities by 5";

            _StrengthMod = _StrengthMod + 5;
            _DexterityMod = _DexterityMod + 5;
            _EnduranceMod = _EnduranceMod + 5;
            _IntellegenceMod = _IntellegenceMod + 5;
            _PerceptionMod = _PerceptionMod + 5;
            _CharismaMod = _CharismaMod + 5;


            this._Race = selectedRace.Text;
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CharacterPictureBox.Image = Properties.Resources.Elf;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase DEX and PER by 20";

            _DexterityMod = _DexterityMod + 20;
            _PerceptionMod = _PerceptionMod + 20;

            this._Race = selectedRace.Text;

        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.dwarf;
            RadioButton selectedRace = (RadioButton)sender;
            RacialBonusTextBox.Text = "Increase STR and PER by 20, Decrease CHA by 10";

            _StrengthMod = _StrengthMod + 20;
            _PerceptionMod = _PerceptionMod + 20;
            _CharismaMod = _CharismaMod - 10;
            this._Race = selectedRace.Text;

        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.Halfling;
            RadioButton selectedRace = (RadioButton)sender;

            RacialBonusTextBox.Text = "Increase DEX and INT by 20, Decrease STR by 10";
            _DexterityMod = _DexterityMod + 20;
            _IntellegenceMod = _IntellegenceMod + 20;
            _StrengthMod = _StrengthMod - 10;

            this._Race = selectedRace.Text;

        }


    }
}
