using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        /// <summary>
        /// Validates that the TextBox which raised the Validating event
        /// is not empty or made up only of whitespace.
        ///
        /// This method can be used by multiple TextBox controls because
        /// the 'sender' parameter identifies which TextBox triggered the event.
        ///
        /// If the TextBox is empty:
        /// - Validation is canceled.
        /// - The cursor remains in the TextBox.
        /// - An error message is displayed.
        ///
        /// If the TextBox contains text:
        /// - Validation succeeds.
        /// - Any existing error message is removed.
        /// </summary>
        private void ValidateTextBoxNotEmptyUI(object sender, CancelEventArgs e)
        {
            // The TextBox that triggered the Validating event.
            TextBox senderTextBox = (TextBox)sender;

            // The text entered by the user.
            string senderText = senderTextBox.Text;

            // Error message displayed when the TextBox is empty.
            string message = "Must Enter";

            // Check whether the TextBox is empty or contains only whitespace.
            if (string.IsNullOrWhiteSpace(senderText))
            {
                // Prevent the user from leaving the TextBox.
                e.Cancel = true;

                // Keep the cursor in the current TextBox.
                senderTextBox.Focus();

                // Display the validation error.
                ErrorProvidderForLogin.SetError(senderTextBox, message);
            }
            else
            {
                // Allow the user to continue.
                e.Cancel = false;

                // Remove the validation error.
                ErrorProvidderForLogin.SetError(senderTextBox, "");
            }
        }
        private void btLogin_Click(object sender, EventArgs e)
        {

        }
     

        private void txUsername_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBoxNotEmptyUI(sender, e);

            
        }

        private void txPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBoxNotEmptyUI(sender, e);
        }
    }
}
