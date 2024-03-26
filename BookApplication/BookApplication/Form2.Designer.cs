namespace BookApplication
{
    partial class Form2
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
            label1 = new Label();
            insertPanel = new Panel();
            insertButton = new Button();
            insertPrice = new NumericUpDown();
            insertPublisherTextBox = new TextBox();
            insertQuantityTextBox = new TextBox();
            insertPublishYearTextBox = new TextBox();
            insertGenreTextBox = new TextBox();
            insertAuthorTextBox = new TextBox();
            insertTitleTextBox = new TextBox();
            updatePanel = new Panel();
            updateBookIDTextBox = new TextBox();
            updateButton = new Button();
            updatePrice = new NumericUpDown();
            updatePublisherTextBox = new TextBox();
            updateQuantity = new TextBox();
            updatePublishYearTextBox = new TextBox();
            updateGenreTextBox = new TextBox();
            updateAuthorTextBox = new TextBox();
            updateTitleTextBox = new TextBox();
            deletePanel = new Panel();
            deleteBookID = new TextBox();
            deleteButton = new Button();
            insertPanelButton = new Button();
            updatePanelButton = new Button();
            deletePanelButton = new Button();
            insertPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)insertPrice).BeginInit();
            updatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)updatePrice).BeginInit();
            deletePanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(268, 35);
            label1.Name = "label1";
            label1.Size = new Size(265, 38);
            label1.TabIndex = 7;
            label1.Text = "Changing Data";
            // 
            // insertPanel
            // 
            insertPanel.Controls.Add(insertButton);
            insertPanel.Controls.Add(insertPrice);
            insertPanel.Controls.Add(insertPublisherTextBox);
            insertPanel.Controls.Add(insertQuantityTextBox);
            insertPanel.Controls.Add(insertPublishYearTextBox);
            insertPanel.Controls.Add(insertGenreTextBox);
            insertPanel.Controls.Add(insertAuthorTextBox);
            insertPanel.Controls.Add(insertTitleTextBox);
            insertPanel.Location = new Point(63, 165);
            insertPanel.Name = "insertPanel";
            insertPanel.Size = new Size(674, 154);
            insertPanel.TabIndex = 8;
            // 
            // insertButton
            // 
            insertButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            insertButton.Location = new Point(522, 103);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(127, 26);
            insertButton.TabIndex = 20;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click_1;
            // 
            // insertPrice
            // 
            insertPrice.Location = new Point(443, 68);
            insertPrice.Name = "insertPrice";
            insertPrice.Size = new Size(67, 23);
            insertPrice.TabIndex = 19;
            // 
            // insertPublisherTextBox
            // 
            insertPublisherTextBox.Location = new Point(522, 68);
            insertPublisherTextBox.Name = "insertPublisherTextBox";
            insertPublisherTextBox.PlaceholderText = "Publisher";
            insertPublisherTextBox.Size = new Size(127, 23);
            insertPublisherTextBox.TabIndex = 18;
            // 
            // insertQuantityTextBox
            // 
            insertQuantityTextBox.Location = new Point(304, 68);
            insertQuantityTextBox.Name = "insertQuantityTextBox";
            insertQuantityTextBox.PlaceholderText = "Quantity";
            insertQuantityTextBox.Size = new Size(127, 23);
            insertQuantityTextBox.TabIndex = 17;
            // 
            // insertPublishYearTextBox
            // 
            insertPublishYearTextBox.Location = new Point(165, 68);
            insertPublishYearTextBox.Name = "insertPublishYearTextBox";
            insertPublishYearTextBox.PlaceholderText = "Publish Year";
            insertPublishYearTextBox.Size = new Size(127, 23);
            insertPublishYearTextBox.TabIndex = 16;
            // 
            // insertGenreTextBox
            // 
            insertGenreTextBox.Location = new Point(26, 68);
            insertGenreTextBox.Name = "insertGenreTextBox";
            insertGenreTextBox.PlaceholderText = "Genre";
            insertGenreTextBox.Size = new Size(127, 23);
            insertGenreTextBox.TabIndex = 15;
            // 
            // insertAuthorTextBox
            // 
            insertAuthorTextBox.Location = new Point(344, 25);
            insertAuthorTextBox.Name = "insertAuthorTextBox";
            insertAuthorTextBox.PlaceholderText = "Author";
            insertAuthorTextBox.Size = new Size(305, 23);
            insertAuthorTextBox.TabIndex = 14;
            // 
            // insertTitleTextBox
            // 
            insertTitleTextBox.Location = new Point(26, 25);
            insertTitleTextBox.Name = "insertTitleTextBox";
            insertTitleTextBox.PlaceholderText = "Title";
            insertTitleTextBox.Size = new Size(305, 23);
            insertTitleTextBox.TabIndex = 13;
            // 
            // updatePanel
            // 
            updatePanel.Controls.Add(updateBookIDTextBox);
            updatePanel.Controls.Add(updateButton);
            updatePanel.Controls.Add(updatePrice);
            updatePanel.Controls.Add(updatePublisherTextBox);
            updatePanel.Controls.Add(updateQuantity);
            updatePanel.Controls.Add(updatePublishYearTextBox);
            updatePanel.Controls.Add(updateGenreTextBox);
            updatePanel.Controls.Add(updateAuthorTextBox);
            updatePanel.Controls.Add(updateTitleTextBox);
            updatePanel.Location = new Point(63, 325);
            updatePanel.Name = "updatePanel";
            updatePanel.Size = new Size(674, 152);
            updatePanel.TabIndex = 21;
            // 
            // updateBookIDTextBox
            // 
            updateBookIDTextBox.Location = new Point(26, 25);
            updateBookIDTextBox.Name = "updateBookIDTextBox";
            updateBookIDTextBox.PlaceholderText = "BookID";
            updateBookIDTextBox.Size = new Size(67, 23);
            updateBookIDTextBox.TabIndex = 21;
            // 
            // updateButton
            // 
            updateButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.Location = new Point(522, 103);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(127, 26);
            updateButton.TabIndex = 20;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click_1;
            // 
            // updatePrice
            // 
            updatePrice.Location = new Point(443, 68);
            updatePrice.Name = "updatePrice";
            updatePrice.Size = new Size(67, 23);
            updatePrice.TabIndex = 19;
            // 
            // updatePublisherTextBox
            // 
            updatePublisherTextBox.Location = new Point(522, 68);
            updatePublisherTextBox.Name = "updatePublisherTextBox";
            updatePublisherTextBox.PlaceholderText = "Publisher";
            updatePublisherTextBox.Size = new Size(127, 23);
            updatePublisherTextBox.TabIndex = 18;
            // 
            // updateQuantity
            // 
            updateQuantity.Location = new Point(304, 68);
            updateQuantity.Name = "updateQuantity";
            updateQuantity.PlaceholderText = "Quantity";
            updateQuantity.Size = new Size(127, 23);
            updateQuantity.TabIndex = 17;
            // 
            // updatePublishYearTextBox
            // 
            updatePublishYearTextBox.Location = new Point(165, 68);
            updatePublishYearTextBox.Name = "updatePublishYearTextBox";
            updatePublishYearTextBox.PlaceholderText = "Publish Year";
            updatePublishYearTextBox.Size = new Size(127, 23);
            updatePublishYearTextBox.TabIndex = 16;
            // 
            // updateGenreTextBox
            // 
            updateGenreTextBox.Location = new Point(26, 68);
            updateGenreTextBox.Name = "updateGenreTextBox";
            updateGenreTextBox.PlaceholderText = "Genre";
            updateGenreTextBox.Size = new Size(127, 23);
            updateGenreTextBox.TabIndex = 15;
            // 
            // updateAuthorTextBox
            // 
            updateAuthorTextBox.Location = new Point(408, 25);
            updateAuthorTextBox.Name = "updateAuthorTextBox";
            updateAuthorTextBox.PlaceholderText = "Author";
            updateAuthorTextBox.Size = new Size(241, 23);
            updateAuthorTextBox.TabIndex = 14;
            // 
            // updateTitleTextBox
            // 
            updateTitleTextBox.Location = new Point(130, 25);
            updateTitleTextBox.Name = "updateTitleTextBox";
            updateTitleTextBox.PlaceholderText = "Title";
            updateTitleTextBox.Size = new Size(241, 23);
            updateTitleTextBox.TabIndex = 13;
            // 
            // deletePanel
            // 
            deletePanel.Controls.Add(deleteBookID);
            deletePanel.Controls.Add(deleteButton);
            deletePanel.Location = new Point(63, 483);
            deletePanel.Name = "deletePanel";
            deletePanel.Size = new Size(674, 152);
            deletePanel.TabIndex = 22;
            // 
            // deleteBookID
            // 
            deleteBookID.Location = new Point(223, 54);
            deleteBookID.Name = "deleteBookID";
            deleteBookID.PlaceholderText = "BookID";
            deleteBookID.Size = new Size(67, 23);
            deleteBookID.TabIndex = 21;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.Location = new Point(324, 52);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(127, 26);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click_1;
            // 
            // insertPanelButton
            // 
            insertPanelButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertPanelButton.Location = new Point(63, 105);
            insertPanelButton.Name = "insertPanelButton";
            insertPanelButton.Size = new Size(161, 33);
            insertPanelButton.TabIndex = 10;
            insertPanelButton.Text = "Insert Book Data";
            insertPanelButton.UseVisualStyleBackColor = true;
            insertPanelButton.Click += insertPanelButton_Click;
            // 
            // updatePanelButton
            // 
            updatePanelButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updatePanelButton.Location = new Point(319, 105);
            updatePanelButton.Name = "updatePanelButton";
            updatePanelButton.Size = new Size(161, 33);
            updatePanelButton.TabIndex = 11;
            updatePanelButton.Text = "Update Book Data";
            updatePanelButton.UseVisualStyleBackColor = true;
            updatePanelButton.Click += updatePanelButton_Click;
            // 
            // deletePanelButton
            // 
            deletePanelButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            deletePanelButton.Location = new Point(575, 105);
            deletePanelButton.Name = "deletePanelButton";
            deletePanelButton.Size = new Size(161, 33);
            deletePanelButton.TabIndex = 12;
            deletePanelButton.Text = "Delete Book Data";
            deletePanelButton.UseVisualStyleBackColor = true;
            deletePanelButton.Click += deletePanelButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(deletePanel);
            Controls.Add(updatePanel);
            Controls.Add(deletePanelButton);
            Controls.Add(updatePanelButton);
            Controls.Add(insertPanelButton);
            Controls.Add(insertPanel);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Changing Data in Book Database";
            insertPanel.ResumeLayout(false);
            insertPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)insertPrice).EndInit();
            updatePanel.ResumeLayout(false);
            updatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)updatePrice).EndInit();
            deletePanel.ResumeLayout(false);
            deletePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel insertPanel;
        private Button insertPanelButton;
        private Button updatePanelButton;
        private Button deletePanelButton;
        private TextBox insertPublishYearTextBox;
        private TextBox insertGenreTextBox;
        private TextBox insertAuthorTextBox;
        private TextBox insertTitleTextBox;
        private TextBox insertQuantityTextBox;
        private TextBox insertPublisherTextBox;
        private Panel updatePanel;
        private Button updateButton;
        private NumericUpDown updatePrice;
        private TextBox updatePublisherTextBox;
        private TextBox updateQuantity;
        private TextBox updatePublishYearTextBox;
        private TextBox updateGenreTextBox;
        private TextBox updateAuthorTextBox;
        private TextBox updateTitleTextBox;
        private Button insertButton;
        private NumericUpDown insertPrice;
        private TextBox updateBookIDTextBox;
        private Panel deletePanel;
        private TextBox deleteBookID;
        private Button deleteButton;
        private Button goBackButton;
    }
}