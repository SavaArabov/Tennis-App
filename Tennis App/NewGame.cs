using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tennis_App
{
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public (string, int) FirstPlayer { get; set; }

        public (string, int) SecondPlayer { get; set; }

        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirstPlayerPoints.Value;

            string secondPlayerName = textBoxSecondPlayerName.Text.Trim();
            int secondPlayerPoints = (int)numericUpDownSecondPlayerPoints.Value;


            FirstPlayer = (firstPlayerName, firstPlayerPoints);
            SecondPlayer = (secondPlayerName, secondPlayerPoints);

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid() => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty() => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);
        private bool CheckIfPlayerNamesAreSame() => this.FirstPlayer.Item1 == this.SecondPlayer.Item1;

        private void errorProvider1_RightToLeftChanged(object sender, EventArgs e)
        {

        }

        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }
        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerNameErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageFirstNameTextBox.Text = "First " + errorText;
            }
            else if (textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerNameErrorProvider.SetError(textBox, errorText);
                this.labelErrorMessageFirstNameTextBox.Text = "First " + errorText;
            }
        }
        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textBoxFirstPlayerName)
            {
                this.firstPlayerNameErrorProvider.SetError(textBox, "");
                this.labelErrorMessageFirstNameTextBox.Text = string.Empty;
            }
            else if (textBox == this.textBoxSecondPlayerName)
            {
                this.secondPlayerNameErrorProvider.SetError(textBox, "");
                this.labelErrorMessageFirstNameTextBox.Text = string.Empty;
            }
        }
        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.labelSameNamesErrorMessage.Text = "Both names shouldn't be the same!";
            }
            else
            {
                this.labelSameNamesErrorMessage.Text = string.Empty;
            }
        }

        private void NewGameForm_Load(object sender, EventArgs e)
        {

        }

        private void labelVs_Click(object sender, EventArgs e)
        {

        }
    }
}
