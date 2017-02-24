namespace COMP1004_W2017_MidTermAssignment
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.cultistRadioButton = new System.Windows.Forms.RadioButton();
            this.magickerRadioButton = new System.Windows.Forms.RadioButton();
            this.rogueRadioButton = new System.Windows.Forms.RadioButton();
            this.soldierRadioButton = new System.Windows.Forms.RadioButton();
            this.healthPointLabel = new System.Windows.Forms.Label();
            this.healthPointTextBox = new System.Windows.Forms.TextBox();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.NextButton.Location = new System.Drawing.Point(512, 446);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.cultistRadioButton);
            this.jobGroupBox.Controls.Add(this.magickerRadioButton);
            this.jobGroupBox.Controls.Add(this.rogueRadioButton);
            this.jobGroupBox.Controls.Add(this.soldierRadioButton);
            this.jobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.jobGroupBox.Location = new System.Drawing.Point(34, 55);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(202, 237);
            this.jobGroupBox.TabIndex = 4;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Job";
            // 
            // cultistRadioButton
            // 
            this.cultistRadioButton.AutoSize = true;
            this.cultistRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cultistRadioButton.Location = new System.Drawing.Point(7, 189);
            this.cultistRadioButton.Name = "cultistRadioButton";
            this.cultistRadioButton.Size = new System.Drawing.Size(77, 28);
            this.cultistRadioButton.TabIndex = 3;
            this.cultistRadioButton.Text = "Cultist";
            this.cultistRadioButton.UseVisualStyleBackColor = true;
            this.cultistRadioButton.CheckedChanged += new System.EventHandler(this.CultistRadioButton_CheckedChanged);
            // 
            // magickerRadioButton
            // 
            this.magickerRadioButton.AutoSize = true;
            this.magickerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.magickerRadioButton.Location = new System.Drawing.Point(6, 136);
            this.magickerRadioButton.Name = "magickerRadioButton";
            this.magickerRadioButton.Size = new System.Drawing.Size(105, 28);
            this.magickerRadioButton.TabIndex = 2;
            this.magickerRadioButton.Text = "Magicker";
            this.magickerRadioButton.UseVisualStyleBackColor = true;
            this.magickerRadioButton.CheckedChanged += new System.EventHandler(this.MagickerRadioButton_CheckedChanged);
            // 
            // rogueRadioButton
            // 
            this.rogueRadioButton.AutoSize = true;
            this.rogueRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.rogueRadioButton.Location = new System.Drawing.Point(7, 83);
            this.rogueRadioButton.Name = "rogueRadioButton";
            this.rogueRadioButton.Size = new System.Drawing.Size(85, 28);
            this.rogueRadioButton.TabIndex = 1;
            this.rogueRadioButton.Text = "Rogue";
            this.rogueRadioButton.UseVisualStyleBackColor = true;
            this.rogueRadioButton.CheckedChanged += new System.EventHandler(this.RogueRadioButton_CheckedChanged);
            // 
            // soldierRadioButton
            // 
            this.soldierRadioButton.AutoSize = true;
            this.soldierRadioButton.Checked = true;
            this.soldierRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldierRadioButton.Location = new System.Drawing.Point(7, 32);
            this.soldierRadioButton.Name = "soldierRadioButton";
            this.soldierRadioButton.Size = new System.Drawing.Size(87, 28);
            this.soldierRadioButton.TabIndex = 0;
            this.soldierRadioButton.TabStop = true;
            this.soldierRadioButton.Text = "Soldier";
            this.soldierRadioButton.UseVisualStyleBackColor = true;
            this.soldierRadioButton.CheckedChanged += new System.EventHandler(this.SoldierRadioButton_CheckedChanged);
            // 
            // healthPointLabel
            // 
            this.healthPointLabel.AutoSize = true;
            this.healthPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPointLabel.Location = new System.Drawing.Point(30, 348);
            this.healthPointLabel.Name = "healthPointLabel";
            this.healthPointLabel.Size = new System.Drawing.Size(104, 20);
            this.healthPointLabel.TabIndex = 5;
            this.healthPointLabel.Text = "Health Points";
            // 
            // healthPointTextBox
            // 
            this.healthPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.healthPointTextBox.Location = new System.Drawing.Point(34, 389);
            this.healthPointTextBox.Name = "healthPointTextBox";
            this.healthPointTextBox.Size = new System.Drawing.Size(552, 26);
            this.healthPointTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthPointTextBox);
            this.Controls.Add(this.healthPointLabel);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobForm";
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.RadioButton cultistRadioButton;
        private System.Windows.Forms.RadioButton magickerRadioButton;
        private System.Windows.Forms.RadioButton rogueRadioButton;
        private System.Windows.Forms.RadioButton soldierRadioButton;
        private System.Windows.Forms.Label healthPointLabel;
        private System.Windows.Forms.TextBox healthPointTextBox;

    }
}