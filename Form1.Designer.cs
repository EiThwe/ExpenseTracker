namespace ExpenseTracker
{
    partial class expenseTrackerForm
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
            panel1 = new Panel();
            yearLabel = new Label();
            monthLabel = new Label();
            yearFilterSelectBox = new ComboBox();
            monthFilterSelectBox = new ComboBox();
            checkButton = new Button();
            incomeInput = new TextBox();
            checkBalanceLabel = new Label();
            pageLabel = new Label();
            totalExpense = new Label();
            expenseTotalCount = new Label();
            clearButton = new Button();
            appTitle = new Label();
            closeButtonPictureBox = new PictureBox();
            lastPageButton = new Button();
            nextButton = new Button();
            previousButton = new Button();
            firstPageButton = new Button();
            removeButton = new Button();
            editButton = new Button();
            addButton = new Button();
            searchButton = new Button();
            catergorySelectBox = new ComboBox();
            descriptionTextBox = new RichTextBox();
            dateTimePicker = new DateTimePicker();
            dateLabel = new Label();
            amountTextBox = new TextBox();
            descriptionLabel = new Label();
            amountLabel = new Label();
            categoryLabel = new Label();
            idNumericUpDown = new NumericUpDown();
            id = new Label();
            expenseDataGridView = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeButtonPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)expenseDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Controls.Add(yearLabel);
            panel1.Controls.Add(monthLabel);
            panel1.Controls.Add(yearFilterSelectBox);
            panel1.Controls.Add(monthFilterSelectBox);
            panel1.Controls.Add(checkButton);
            panel1.Controls.Add(incomeInput);
            panel1.Controls.Add(checkBalanceLabel);
            panel1.Controls.Add(pageLabel);
            panel1.Controls.Add(totalExpense);
            panel1.Controls.Add(expenseTotalCount);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(appTitle);
            panel1.Controls.Add(closeButtonPictureBox);
            panel1.Controls.Add(lastPageButton);
            panel1.Controls.Add(nextButton);
            panel1.Controls.Add(previousButton);
            panel1.Controls.Add(firstPageButton);
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(catergorySelectBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(dateLabel);
            panel1.Controls.Add(amountTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(amountLabel);
            panel1.Controls.Add(categoryLabel);
            panel1.Controls.Add(idNumericUpDown);
            panel1.Controls.Add(id);
            panel1.Controls.Add(expenseDataGridView);
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(2056, 1266);
            panel1.TabIndex = 0;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            yearLabel.ForeColor = Color.FromArgb(64, 64, 64);
            yearLabel.Location = new Point(1682, 83);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new Size(84, 31);
            yearLabel.TabIndex = 34;
            yearLabel.Text = "Year:";
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthLabel.ForeColor = Color.FromArgb(64, 64, 64);
            monthLabel.Location = new Point(1302, 83);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(103, 31);
            monthLabel.TabIndex = 33;
            monthLabel.Text = "Month:";
            // 
            // yearFilterSelectBox
            // 
            yearFilterSelectBox.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            yearFilterSelectBox.FormattingEnabled = true;
            yearFilterSelectBox.Items.AddRange(new object[] { "2025  ", "2026  ", "2027  ", "2028  ", "2029  ", "2030  ", "2031  ", "2032  ", "2033  ", "2034  ", "2035  ", "2036  ", "2037  ", "2038  ", "2039  ", "2040  ", "2041  ", "2042  ", "2043  ", "2044  ", "2045  ", "2046  ", "2047  ", "2048  ", "2049  ", "2050" });
            yearFilterSelectBox.Location = new Point(1772, 77);
            yearFilterSelectBox.Name = "yearFilterSelectBox";
            yearFilterSelectBox.Size = new Size(242, 39);
            yearFilterSelectBox.TabIndex = 32;
            yearFilterSelectBox.SelectedIndexChanged += yearFilterSelectBox_SelectedIndexChanged;
            // 
            // monthFilterSelectBox
            // 
            monthFilterSelectBox.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            monthFilterSelectBox.FormattingEnabled = true;
            monthFilterSelectBox.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            monthFilterSelectBox.Location = new Point(1411, 77);
            monthFilterSelectBox.Name = "monthFilterSelectBox";
            monthFilterSelectBox.Size = new Size(242, 39);
            monthFilterSelectBox.TabIndex = 31;
            monthFilterSelectBox.SelectedIndexChanged += monthFilterSelectBox_SelectedIndexChanged;
            // 
            // checkButton
            // 
            checkButton.BackColor = Color.DarkTurquoise;
            checkButton.FlatAppearance.BorderSize = 0;
            checkButton.FlatStyle = FlatStyle.Flat;
            checkButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkButton.ForeColor = SystemColors.ButtonHighlight;
            checkButton.Location = new Point(672, 1125);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(164, 50);
            checkButton.TabIndex = 30;
            checkButton.Text = "Check";
            checkButton.UseVisualStyleBackColor = false;
            checkButton.Click += checkButton_Click;
            // 
            // incomeInput
            // 
            incomeInput.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            incomeInput.Location = new Point(70, 1125);
            incomeInput.Multiline = true;
            incomeInput.Name = "incomeInput";
            incomeInput.Size = new Size(583, 50);
            incomeInput.TabIndex = 28;
            // 
            // checkBalanceLabel
            // 
            checkBalanceLabel.AutoSize = true;
            checkBalanceLabel.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBalanceLabel.ForeColor = Color.FromArgb(64, 64, 64);
            checkBalanceLabel.Location = new Point(58, 1019);
            checkBalanceLabel.Name = "checkBalanceLabel";
            checkBalanceLabel.Size = new Size(346, 42);
            checkBalanceLabel.TabIndex = 27;
            checkBalanceLabel.Text = "Check the balance";
            // 
            // pageLabel
            // 
            pageLabel.AutoSize = true;
            pageLabel.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pageLabel.ForeColor = Color.FromArgb(64, 64, 64);
            pageLabel.Location = new Point(888, 955);
            pageLabel.Name = "pageLabel";
            pageLabel.Size = new Size(162, 31);
            pageLabel.TabIndex = 26;
            pageLabel.Text = "Page 0 of 0\r\n";
            // 
            // totalExpense
            // 
            totalExpense.AutoSize = true;
            totalExpense.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalExpense.ForeColor = Color.FromArgb(64, 64, 64);
            totalExpense.Location = new Point(1637, 955);
            totalExpense.Name = "totalExpense";
            totalExpense.Size = new Size(395, 31);
            totalExpense.TabIndex = 25;
            totalExpense.Text = "Total Expense : 10000000 Ks";
            // 
            // expenseTotalCount
            // 
            expenseTotalCount.AutoSize = true;
            expenseTotalCount.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            expenseTotalCount.ForeColor = Color.FromArgb(64, 64, 64);
            expenseTotalCount.Location = new Point(1443, 955);
            expenseTotalCount.Name = "expenseTotalCount";
            expenseTotalCount.Size = new Size(197, 31);
            expenseTotalCount.TabIndex = 24;
            expenseTotalCount.Text = "100 Expenses";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.DimGray;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearButton.ForeColor = SystemColors.ButtonHighlight;
            clearButton.Location = new Point(681, 846);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(164, 54);
            clearButton.TabIndex = 23;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // appTitle
            // 
            appTitle.AutoSize = true;
            appTitle.BackColor = Color.LightCyan;
            appTitle.Font = new Font("Perpetua Titling MT", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appTitle.ForeColor = Color.FromArgb(64, 64, 64);
            appTitle.Location = new Point(36, 27);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(677, 64);
            appTitle.TabIndex = 22;
            appTitle.Text = "My Expense Tracker";
            // 
            // closeButtonPictureBox
            // 
            closeButtonPictureBox.Image = Properties.Resources.cross_btn;
            closeButtonPictureBox.Location = new Point(1997, 13);
            closeButtonPictureBox.Name = "closeButtonPictureBox";
            closeButtonPictureBox.Size = new Size(45, 46);
            closeButtonPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            closeButtonPictureBox.TabIndex = 21;
            closeButtonPictureBox.TabStop = false;
            closeButtonPictureBox.Click += closeButtonPictureBox_Click;
            // 
            // lastPageButton
            // 
            lastPageButton.BackColor = Color.DarkTurquoise;
            lastPageButton.FlatAppearance.BorderSize = 0;
            lastPageButton.FlatStyle = FlatStyle.Flat;
            lastPageButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lastPageButton.ForeColor = SystemColors.ButtonHighlight;
            lastPageButton.Location = new Point(1637, 1039);
            lastPageButton.Name = "lastPageButton";
            lastPageButton.Size = new Size(164, 54);
            lastPageButton.TabIndex = 20;
            lastPageButton.Text = ">>";
            lastPageButton.UseVisualStyleBackColor = false;
            lastPageButton.Click += lastPageButton_Click_1;
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.DarkTurquoise;
            nextButton.FlatAppearance.BorderSize = 0;
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextButton.ForeColor = SystemColors.ButtonHighlight;
            nextButton.Location = new Point(1467, 1039);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(164, 54);
            nextButton.TabIndex = 19;
            nextButton.Text = ">";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // previousButton
            // 
            previousButton.BackColor = Color.DarkTurquoise;
            previousButton.FlatAppearance.BorderSize = 0;
            previousButton.FlatStyle = FlatStyle.Flat;
            previousButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            previousButton.ForeColor = SystemColors.ButtonHighlight;
            previousButton.Location = new Point(1297, 1039);
            previousButton.Name = "previousButton";
            previousButton.Size = new Size(164, 54);
            previousButton.TabIndex = 18;
            previousButton.Text = "<";
            previousButton.UseVisualStyleBackColor = false;
            previousButton.Click += previousButton_Click;
            // 
            // firstPageButton
            // 
            firstPageButton.BackColor = Color.DarkTurquoise;
            firstPageButton.FlatAppearance.BorderSize = 0;
            firstPageButton.FlatStyle = FlatStyle.Flat;
            firstPageButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstPageButton.ForeColor = SystemColors.ButtonHighlight;
            firstPageButton.Location = new Point(1129, 1039);
            firstPageButton.Name = "firstPageButton";
            firstPageButton.Size = new Size(162, 54);
            firstPageButton.TabIndex = 17;
            firstPageButton.Text = "<<";
            firstPageButton.UseVisualStyleBackColor = false;
            firstPageButton.Click += firstPageButton_Click_1;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Red;
            removeButton.FlatAppearance.BorderSize = 0;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeButton.ForeColor = SystemColors.ButtonHighlight;
            removeButton.Location = new Point(503, 846);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(164, 54);
            removeButton.TabIndex = 16;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // editButton
            // 
            editButton.BackColor = Color.LimeGreen;
            editButton.FlatAppearance.BorderSize = 0;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.ForeColor = SystemColors.ButtonHighlight;
            editButton.Location = new Point(325, 846);
            editButton.Name = "editButton";
            editButton.Size = new Size(164, 54);
            editButton.TabIndex = 15;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += editButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DarkTurquoise;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addButton.ForeColor = SystemColors.ButtonHighlight;
            addButton.Location = new Point(149, 846);
            addButton.Name = "addButton";
            addButton.Size = new Size(162, 54);
            addButton.TabIndex = 14;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.DarkTurquoise;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchButton.ForeColor = SystemColors.ButtonHighlight;
            searchButton.Location = new Point(686, 135);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(159, 49);
            searchButton.TabIndex = 13;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // catergorySelectBox
            // 
            catergorySelectBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            catergorySelectBox.FormattingEnabled = true;
            catergorySelectBox.Items.AddRange(new object[] { "🏠 Housing", "🚗 Transportation", "🍔 Food", "👨‍👩‍👧 Family", "🎉 Lifestyle", "💳Debt & Bills", "💰 Savings\t", "🛍️ Miscellaneous" });
            catergorySelectBox.Location = new Point(262, 221);
            catergorySelectBox.Name = "catergorySelectBox";
            catergorySelectBox.Size = new Size(583, 45);
            catergorySelectBox.TabIndex = 12;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTextBox.Location = new Point(262, 510);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(583, 288);
            descriptionTextBox.TabIndex = 11;
            descriptionTextBox.Text = "";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker.Location = new Point(262, 413);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(583, 44);
            dateTimePicker.TabIndex = 10;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = Color.FromArgb(64, 64, 64);
            dateLabel.Location = new Point(136, 419);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(98, 37);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date:";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountTextBox.Location = new Point(262, 325);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(583, 44);
            amountTextBox.TabIndex = 7;
            amountTextBox.KeyUp += amountTextBox_KeyUp;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            descriptionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            descriptionLabel.Location = new Point(36, 513);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(198, 37);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amountLabel.ForeColor = Color.FromArgb(64, 64, 64);
            amountLabel.Location = new Point(89, 325);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(145, 37);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryLabel.ForeColor = Color.FromArgb(64, 64, 64);
            categoryLabel.Location = new Point(70, 231);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(164, 37);
            categoryLabel.TabIndex = 3;
            categoryLabel.Text = "Category:";
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.BackColor = Color.White;
            idNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            idNumericUpDown.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idNumericUpDown.ForeColor = SystemColors.ControlText;
            idNumericUpDown.Location = new Point(262, 135);
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(391, 44);
            idNumericUpDown.TabIndex = 2;
            // 
            // id
            // 
            id.AutoSize = true;
            id.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            id.ForeColor = Color.FromArgb(64, 64, 64);
            id.Location = new Point(174, 137);
            id.Name = "id";
            id.Size = new Size(60, 37);
            id.TabIndex = 1;
            id.Text = "ID:";
            // 
            // expenseDataGridView
            // 
            expenseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            expenseDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            expenseDataGridView.Location = new Point(888, 135);
            expenseDataGridView.Name = "expenseDataGridView";
            expenseDataGridView.RowHeadersWidth = 82;
            expenseDataGridView.Size = new Size(1126, 806);
            expenseDataGridView.TabIndex = 0;
            expenseDataGridView.Click += expenseDataGridView_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(70, 1078);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(673, 31);
            label1.TabIndex = 29;
            label1.Text = "Please enter your monthly income to see your balance.";
            // 
            // expenseTrackerForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(2080, 1290);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "expenseTrackerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expense_Tracker_Form";
            Load += expenseTrackerForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)closeButtonPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)expenseDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label id;
        private DataGridView expenseDataGridView;
        private NumericUpDown idNumericUpDown;
        private Label descriptionLabel;
        private Label amountLabel;
        private Label categoryLabel;
        private TextBox amountTextBox;
        private Label dateLabel;
        private RichTextBox descriptionTextBox;
        private DateTimePicker dateTimePicker;
        private ComboBox catergorySelectBox;
        private Button searchButton;
        private Button addButton;
        private Button removeButton;
        private Button editButton;
        private Button lastPageButton;
        private Button nextButton;
        private Button previousButton;
        private Button firstPageButton;
        private PictureBox closeButtonPictureBox;
        private Label appTitle;
        private Button clearButton;
        private Label expenseTotalCount;
        private Label totalExpense;
        private Label pageLabel;
        private Label checkBalanceLabel;
        private Label label1;
        private TextBox incomeInput;
        private Button checkButton;
        private Label monthLabel;
        private ComboBox yearFilterSelectBox;
        private ComboBox monthFilterSelectBox;
        private Label yearLabel;
    }
}
