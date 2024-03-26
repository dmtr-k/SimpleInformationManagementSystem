using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BookApplication.authenticate;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using BookApplication;  // Importing the entire WinFormsDemo namespace
using System.Diagnostics;


namespace BookApplication
{
    public partial class signIn : Form
    {
        SqlConnection sqlCon;
        public signIn()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string user = userNameTextBox.Text;
            string pass = passwordTextBox.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Database welcome = new Database(authenticatedUser);
                    welcome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }
    }
}
