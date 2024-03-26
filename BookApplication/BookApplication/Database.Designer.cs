namespace BookApplication
{
    partial class Database
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            genreComboBox = new ComboBox();
            publisherComboBox = new ComboBox();
            priceRangeComboBox = new ComboBox();
            welcome = new Label();
            searchButton = new Button();
            clearButton = new Button();
            orderButton = new Button();
            publishYearComboBox = new ComboBox();
            titleTextBox = new TextBox();
            authorTextBox = new TextBox();
            changeDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.Window;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(87, 173);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(626, 191);
            dataGridView.TabIndex = 0;
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Items.AddRange(new object[] { "Genre", "Fiction", "Romance", "Science Fiction" });
            genreComboBox.Location = new Point(87, 127);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(146, 23);
            genreComboBox.TabIndex = 1;
            // 
            // publisherComboBox
            // 
            publisherComboBox.FormattingEnabled = true;
            publisherComboBox.Items.AddRange(new object[] { "Publisher", "Penguin Random House", "Simon & Schuster", "Pink Unicorn" });
            publisherComboBox.Location = new Point(246, 127);
            publisherComboBox.Name = "publisherComboBox";
            publisherComboBox.Size = new Size(146, 23);
            publisherComboBox.TabIndex = 3;
            // 
            // priceRangeComboBox
            // 
            priceRangeComboBox.FormattingEnabled = true;
            priceRangeComboBox.Items.AddRange(new object[] { "Price Range", "0 - 9.99", "10 - 19.99" });
            priceRangeComboBox.Location = new Point(564, 127);
            priceRangeComboBox.Name = "priceRangeComboBox";
            priceRangeComboBox.Size = new Size(146, 23);
            priceRangeComboBox.TabIndex = 4;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.BackColor = Color.Transparent;
            welcome.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            welcome.Location = new Point(198, 25);
            welcome.Name = "welcome";
            welcome.Size = new Size(0, 38);
            welcome.TabIndex = 5;
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(214, 381);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(111, 33);
            searchButton.TabIndex = 7;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(88, 381);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(111, 33);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear Filters";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // orderButton
            // 
            orderButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderButton.Location = new Point(603, 381);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(111, 33);
            orderButton.TabIndex = 9;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // publishYearComboBox
            // 
            publishYearComboBox.FormattingEnabled = true;
            publishYearComboBox.Items.AddRange(new object[] { "Published Year", "1800 - 1849", "1850 - 1899", "1900 - 1949", "1950 - 1999", "2000 - 2024" });
            publishYearComboBox.Location = new Point(405, 127);
            publishYearComboBox.Name = "publishYearComboBox";
            publishYearComboBox.Size = new Size(146, 23);
            publishYearComboBox.TabIndex = 10;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(87, 85);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.PlaceholderText = "Title";
            titleTextBox.Size = new Size(305, 23);
            titleTextBox.TabIndex = 11;
            // 
            // authorTextBox
            // 
            authorTextBox.Location = new Point(405, 85);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.PlaceholderText = "Author";
            authorTextBox.Size = new Size(305, 23);
            authorTextBox.TabIndex = 12;
            // 
            // changeDataButton
            // 
            changeDataButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            changeDataButton.Location = new Point(449, 381);
            changeDataButton.Name = "changeDataButton";
            changeDataButton.Size = new Size(136, 33);
            changeDataButton.TabIndex = 13;
            changeDataButton.Text = "Change Data";
            changeDataButton.UseVisualStyleBackColor = true;
            changeDataButton.Click += button1_Click;
            // 
            // Database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(changeDataButton);
            Controls.Add(authorTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(publishYearComboBox);
            Controls.Add(orderButton);
            Controls.Add(clearButton);
            Controls.Add(searchButton);
            Controls.Add(welcome);
            Controls.Add(priceRangeComboBox);
            Controls.Add(publisherComboBox);
            Controls.Add(genreComboBox);
            Controls.Add(dataGridView);
            Name = "Database";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore Database";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private ComboBox genreComboBox;
        private PictureBox pictureBox1;
        private ComboBox publisherComboBox;
        private ComboBox priceRangeComboBox;
        private Label welcome;
        private Label label2;
        private Button searchButton;
        private Button clearButton;
        private Button orderButton;
        private ComboBox publishYearComboBox;
        private TextBox titleTextBox;
        private TextBox authorTextBox;
        private Button button1;
        private Button changeDataButton;
    }
}