using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadBooksData();
        }
        private void LoadBooksData()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT BookID, Title, Quantity, Price FROM Books";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
            }
        }
        private void txtTelephone_Validating(object sender, CancelEventArgs e)
        {
            string phoneNumber = telephoneTextBox.Text.Trim();
            // Regular expression pattern for a simple 10-digit phone number
            string pattern = @"^\d{10}$";

            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                // Display an error message if the phone number is not valid
                e.Cancel = true;
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                telephoneTextBox.Focus(); // Keep focus on the textbox for correction
            }
        }
        private decimal CalculateTotalPrice(int bookID, int quantity)
        {
            decimal price = 0;
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT Price FROM Books WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    price = Convert.ToDecimal(result);
                }
            }
            return price * quantity;
        }

        private void UpdateOrdersTable(string firstName, string lastName, string telephone, int bookID, int quantity, decimal totalPrice)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "INSERT INTO Orders (FirstName, LastName, BookID, Quantity, TotalPrice, Date) VALUES (@FirstName, @LastName, @BookID, @Quantity, @TotalPrice, @Date)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                //cmd.Parameters.AddWithValue("@Telephone", telephone);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.ExecuteNonQuery();
            }
        }

        private void UpdateBooksTable(int bookID, int quantity)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "UPDATE Books SET Quantity = Quantity - @Quantity WHERE BookID = @BookID";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@BookID", bookID);
                cmd.ExecuteNonQuery();
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();
            string lastName = lastNameTextBox.Text.Trim();
            string telephone = telephoneTextBox.Text.Trim();
            int bookID = Convert.ToInt32(bookIDTextBox.Text);
            int quantity = Convert.ToInt32(numberUpDown.Value);

            decimal totalPrice = CalculateTotalPrice(bookID, quantity);

            UpdateOrdersTable(firstName, lastName, telephone, bookID, quantity, totalPrice);
            UpdateBooksTable(bookID, quantity);

            MessageBox.Show("Order placed successfully!");
        }
        private void numberUpDown_ValueChanged(object sender, EventArgs e)
        {
            // Calculate and display the total price based on the quantity selected
            int bookID = Convert.ToInt32(bookIDTextBox.Text);
            int quantity = Convert.ToInt32(numberUpDown.Value);

            decimal totalPrice = CalculateTotalPrice(bookID, quantity);
            totalPriceLabel.Text = $"{totalPrice:C}";
        }
    }
}

