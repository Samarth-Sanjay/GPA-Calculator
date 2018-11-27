using System;
using System.Linq;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            textBoxFirstName.Focus();
        }

        private void displayErrorBox(string errorMessage)
        {
            MessageBox.Show(errorMessage, "Entry Error");
        }

        public bool isValid()
        {
            var firstName = textBoxFirstName.Text;
            var lastName = textBoxLastName.Text;
            var uNumberTextBox1 = textBoxUnum1.Text;
            var uNumberTextBox2 = textBoxUnum2.Text;

            //decimal checkDecimal = 0m;
            if (string.IsNullOrWhiteSpace(firstName))
            {
                displayErrorBox("First Name is a required field.");
                return false;
            }

            if (!char.IsLetter(firstName.First()))
            {
                displayErrorBox("First Name must contain only letters");
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                displayErrorBox("Last Name is a required field.");
                return false;
            }

            if (!char.IsLetter(lastName.First()))
            {
                displayErrorBox("Last Name must contain only letters");
                return false;
            }

            if (string.IsNullOrWhiteSpace(uNumberTextBox1))
            {
                displayErrorBox("First half of U-number is a required field.");
                return false;
            }

            if (uNumberTextBox1.Length != 4)
            {
                displayErrorBox("First half of U-Number must contain 4 digits");
                return false;
            }

            if (string.IsNullOrWhiteSpace(uNumberTextBox2))
            {
                displayErrorBox("Second half of U-number is a required field.");
                return false;
            }


            if (uNumberTextBox2.Length != 4)
            {
                displayErrorBox("Second half of U-Number must contain 4 digits");
                return false;
            }

            return true;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var firstName = textBoxFirstName.Text.Trim();
            var lastName = textBoxLastName.Text.Trim();
            var unumber = textBoxUnum1.Text.Trim();
            var unum2 = textBoxUnum2.Text.Trim();
            if (isValid())
            {
                var dataEntry = new Form2();
                Hide();
                dataEntry.Text = $"Hello {firstName} {lastName} (U{unumber}-{unum2})";
                dataEntry.ShowDialog();
            }
        }
    }
}