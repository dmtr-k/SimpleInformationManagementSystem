using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.ComponentModel.DataAnnotations;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using static BookApplication.authenticate;



namespace BookApplication
{

    public partial class Database : Form
    {
        private authenticate.User authenticatedUser;  // Declaration of a private variable to store authenticated user information

        public Database(authenticate.User authenticatedUser)
        {
            InitializeComponent();

            this.authenticatedUser = authenticatedUser; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            welcome.Text = $"Welcome, {authenticatedUser.Username}!";  // Setting the text of a label

        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
            genreComboBox.SelectedIndex = 0;
            publisherComboBox.SelectedIndex = 0;
            publishYearComboBox.SelectedIndex = 0;
            priceRangeComboBox.SelectedIndex = 0;
            titleTextBox.Text = "";
            authorTextBox.Text = "";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Set default values for ComboBoxes when the form is loaded
            genreComboBox.SelectedIndex = 0;
            publisherComboBox.SelectedIndex = 0;
            publishYearComboBox.SelectedIndex = 0;
            priceRangeComboBox.SelectedIndex = 0;
        }
        // Event handler for when the form is loaded
        private void searchButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                sqlCon.Open(); // Open SQL connection

                // Start with a base SQL query
                string query = "SELECT * FROM Books WHERE 1 = 1";
                // Create a list to store the conditions for filtering
                List<string> conditions = new List<string>();

                // Check each ComboBox and add a condition if an item is selected
                if (genreComboBox.SelectedItem != "Genre")
                {
                    conditions.Add("Genre = @genre");
                }

                if (publisherComboBox.SelectedItem != "Publisher")
                {
                    conditions.Add("Publisher = @publisher");
                }

                if (publishYearComboBox.SelectedItem != "Published Year")
                {
                    switch (publishYearComboBox.SelectedItem.ToString())
                    {
                        case "1800 - 1849":
                            conditions.Add("PublishYear BETWEEN 1800 AND 1849");
                            break;
                        case "1850 - 1899":
                            conditions.Add("PublishYear BETWEEN 1850 AND 1899");
                            break;
                        case "1900 - 1949":
                            conditions.Add("PublishYear BETWEEN 1900 AND 1949");
                            break;
                        case "1950 - 1999":
                            conditions.Add("PublishYear BETWEEN 1950 AND 1999");
                            break;
                        case "2000 - 2024":
                            conditions.Add("PublishYear BETWEEN 2000 AND 2024");
                            break;

                            // Add more cases for other price ranges if needed
                    }
                }
                if (priceRangeComboBox.SelectedItem != "Price")
                {
                    switch (priceRangeComboBox.SelectedItem.ToString())
                    {
                        case "0 - 9.99":
                            conditions.Add("Price BETWEEN 0 AND 9.99");
                            break;
                        case "10 - 19.99":
                            conditions.Add("Price BETWEEN 10 AND 19.99");
                            break;
                            // Add more cases for other price ranges if needed
                    }
                }

                // Add search criteria for title and author
                if (!string.IsNullOrEmpty(titleTextBox.Text))
                {
                    conditions.Add("Title LIKE @title");
                }

                if (!string.IsNullOrEmpty(authorTextBox.Text))
                {
                    conditions.Add("Author LIKE @author");
                }

                // Combine the conditions into the SQL query
                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                // Set parameters based on selected values, handling the case where ComboBox is empty
                if (genreComboBox.SelectedItem != "Genre")
                {
                    cmd.Parameters.AddWithValue("@genre", genreComboBox.SelectedItem.ToString());
                }

                if (publisherComboBox.SelectedItem != "Publisher")
                {
                    cmd.Parameters.AddWithValue("@publisher", publisherComboBox.SelectedItem.ToString());
                }

                if (priceRangeComboBox.SelectedItem != "Price")
                {
                    cmd.Parameters.AddWithValue("@price", priceRangeComboBox.SelectedItem.ToString());
                }

                // Set parameters for title and author
                if (!string.IsNullOrEmpty(titleTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@title", "%" + titleTextBox.Text + "%");
                }

                if (!string.IsNullOrEmpty(authorTextBox.Text))
                {
                    cmd.Parameters.AddWithValue("@author", "%" + authorTextBox.Text + "%");
                }

                // Use SqlDataAdapter to fetch data and populate DataGridView
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }


        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            using (Form1 form1 = new Form1())
            {
                // Display the form as a dialog
                form1.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            {
                // Display the form as a dialog
                form2.ShowDialog();
            }
        }
    }
}

