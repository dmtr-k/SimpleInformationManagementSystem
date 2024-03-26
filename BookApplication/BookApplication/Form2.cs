using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Security.Policy;

namespace BookApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            HideAllPanels();
        }

        private void deletePanelButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            deletePanel.Visible = true; // Show the delete panel
        }

        private void updatePanelButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            updatePanel.Visible = true; // Show the update panel
        }

        private void insertPanelButton_Click(object sender, EventArgs e)
        {
            HideAllPanels();
            insertPanel.Visible = true; // Show the insert panel
        }

        // Helper method to hide all panels
        private void HideAllPanels()
        {
            insertPanel.Visible = false;
            updatePanel.Visible = false;
            deletePanel.Visible = false;
        }
        

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            // Implement update logic here
            // You can update based on book ID or any other unique identifier
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET Title = @title, Author = @author, Publisher = @publisher, PublishYear = @publishYear, Price = @price, Quantity = @quanity, Genre = @genre WHERE BookID = @bookID");
                    cmd.Connection = sqlCon;
                    cmd.Parameters.AddWithValue("@title", insertTitleTextBox.Text);
                    cmd.Parameters.AddWithValue("@author", insertAuthorTextBox.Text);
                    cmd.Parameters.AddWithValue("@publisher", insertPublisherTextBox.Text);
                    cmd.Parameters.AddWithValue("@publishYear", Convert.ToInt32(insertPublishYearTextBox.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(updatePrice.Value));
                    cmd.Parameters.AddWithValue("@genre", insertGenreTextBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToDouble(updateQuantity.Text));

                    // Provide the BookID of the book you want to update
                    cmd.Parameters.AddWithValue("@bookID", updateBookIDTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            // Implement insert logic here
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Books (Title, Author, Publisher, PublishYear, Price, Genre, Quantity) VALUES (@title, @author, @publisher, @publishYear, @price, @genre, @quantity)");
                    cmd.Connection = sqlCon;
                    cmd.Parameters.AddWithValue("@title", insertTitleTextBox.Text);
                    cmd.Parameters.AddWithValue("@author", insertAuthorTextBox.Text);
                    cmd.Parameters.AddWithValue("@publisher", insertPublisherTextBox.Text);
                    cmd.Parameters.AddWithValue("@publishYear", Convert.ToInt32(insertPublishYearTextBox.Text));
                    cmd.Parameters.AddWithValue("@price", Convert.ToDouble(insertPrice.Value));
                    cmd.Parameters.AddWithValue("@genre", insertGenreTextBox.Text);
                    cmd.Parameters.AddWithValue("@quantity", Convert.ToDouble(insertQuantityTextBox.Text));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            // Implement delete logic here
            // You can delete based on book ID or any other unique identifier
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC10\SQLEXPRESS; Initial Catalog=BookDB; Integrated Security=True;"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE BookID = @bookID");
                    cmd.Connection = sqlCon;
                    // Provide the BookID of the book you want to delete
                    cmd.Parameters.AddWithValue("@bookID", updateBookIDTextBox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}
