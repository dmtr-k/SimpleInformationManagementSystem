namespace BookApplication
{
    partial class Form1
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
            label2 = new Label();
            dataGridView = new DataGridView();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            telephoneTextBox = new TextBox();
            label4 = new Label();
            bookIDTextBox = new TextBox();
            numberUpDown = new NumericUpDown();
            orderButton = new Button();
            totalPriceLabel = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bookman Old Style", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(272, 28);
            label1.Name = "label1";
            label1.Size = new Size(257, 38);
            label1.TabIndex = 6;
            label1.Text = "Shopping Cart";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 92);
            label2.Name = "label2";
            label2.Size = new Size(175, 27);
            label2.TabIndex = 7;
            label2.Text = "Personal Info:";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(258, 92);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(479, 317);
            dataGridView.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(56, 135);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.PlaceholderText = "First Name";
            firstNameTextBox.Size = new Size(155, 23);
            firstNameTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(56, 177);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.PlaceholderText = "Last Name";
            lastNameTextBox.Size = new Size(155, 23);
            lastNameTextBox.TabIndex = 11;
            // 
            // telephoneTextBox
            // 
            telephoneTextBox.Location = new Point(56, 219);
            telephoneTextBox.Name = "telephoneTextBox";
            telephoneTextBox.PlaceholderText = "Telephone";
            telephoneTextBox.Size = new Size(155, 23);
            telephoneTextBox.TabIndex = 12;
            telephoneTextBox.Validating += txtTelephone_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Bookman Old Style", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(51, 257);
            label4.Name = "label4";
            label4.Size = new Size(72, 27);
            label4.TabIndex = 13;
            label4.Text = "Cart:";
            // 
            // bookIDTextBox
            // 
            bookIDTextBox.Location = new Point(56, 291);
            bookIDTextBox.Name = "bookIDTextBox";
            bookIDTextBox.PlaceholderText = "BookID";
            bookIDTextBox.Size = new Size(67, 23);
            bookIDTextBox.TabIndex = 14;
            // 
            // numberUpDown
            // 
            numberUpDown.Location = new Point(144, 291);
            numberUpDown.Name = "numberUpDown";
            numberUpDown.Size = new Size(67, 23);
            numberUpDown.TabIndex = 15;
            numberUpDown.ValueChanged += numberUpDown_ValueChanged;
            // 
            // orderButton
            // 
            orderButton.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderButton.Location = new Point(56, 376);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(155, 33);
            orderButton.TabIndex = 16;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.BackColor = Color.Transparent;
            totalPriceLabel.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(153, 334);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(0, 20);
            totalPriceLabel.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(56, 334);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 18;
            label5.Text = "Total Price:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(totalPriceLabel);
            Controls.Add(orderButton);
            Controls.Add(numberUpDown);
            Controls.Add(bookIDTextBox);
            Controls.Add(label4);
            Controls.Add(telephoneTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(dataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView;
        private Label label3;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox telephoneTextBox;
        private Label label4;
        private TextBox bookIDTextBox;
        private NumericUpDown numberUpDown;
        private Button orderButton;
        private Label totalPriceLabel;
        private Label label5;
    }
}