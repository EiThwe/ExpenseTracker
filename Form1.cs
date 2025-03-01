using MySql.Data.MySqlClient;
using System.Data;


namespace ExpenseTracker
{
    public partial class expenseTrackerForm : Form
    {
        public expenseTrackerForm()
        {
            InitializeComponent();
        }

        MySqlConnection connection = new MySqlConnection("datasource = localhost;port = 3307;initial catalog = csharp_expense_lists;username = root; password =");
        DataTable table = new DataTable();

        private int currentPage = 1;
        private int recordsPerPage = 20;
        private int totalRecords;
        private int selectedMonth = DateTime.Now.Month;
        private int selectedYear = DateTime.Now.Year;

        // form load
        private void expenseTrackerForm_Load(object sender, EventArgs e)
        {
            // change DGV height
            expenseDataGridView.RowTemplate.Height = 40;

            //customize DGV header
            expenseDataGridView.EnableHeadersVisualStyles = false;
            expenseDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkTurquoise;
            expenseDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            expenseDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            expenseDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft San Serif", 12, FontStyle.Bold);

            expenseDataGridView.GridColor = Color.SlateBlue;
            expenseDataGridView.AllowUserToAddRows = false;



            // display expenses in DGV
            showExpenses(selectedMonth, selectedYear);
            //select first item in combo box
            catergorySelectBox.SelectedIndex = 0;

            //select this month and this year in filters

            monthFilterSelectBox.Text = DateTime.Now.ToString("MMMM");
            yearFilterSelectBox.Text = DateTime.Now.ToString("yyyy");


        }

        //display the expenses
        public void showExpenses(int? selectedMonth = null, int? selectedYear = null)
        {
            // Default to the current month and year if not provided
            int month = selectedMonth ?? DateTime.Now.Month;
            int year = selectedYear ?? DateTime.Now.Year;

            // Clear the table first
            table.Clear();

            // Get total record count based on filter
            totalRecords = GetTotalExpenseCount(month, year);

            // Calculate the OFFSET
            int offset = (currentPage - 1) * recordsPerPage;

            // Query with filtering
            string query = "SELECT * FROM `expenses` WHERE MONTH(date) = @month AND YEAR(date) = @year LIMIT @limit OFFSET @offset";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@month", month);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@limit", recordsPerPage);
                command.Parameters.AddWithValue("@offset", offset);

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching expenses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            // Bind data to DataGridView
            expenseDataGridView.DataSource = table;

            // Update total count label
            expenseTotalCount.Text = $"{totalRecords} Expenses";

            // Get total expenses amount based on filter
            decimal totalAmount = GetTotalExpensesAmount(month, year);
            totalExpense.Text = $" | Total: {totalAmount} Ks";

            // Update pagination buttons
            UpdatePaginationButtons();
        }

        //find the total expense
        private decimal GetTotalExpensesAmount(int? selectedMonth = null, int? selectedYear = null)
        {
            string query = "SELECT SUM(amount) FROM expenses";
            List<string> conditions = new List<string>();

            if (selectedMonth.HasValue)
                conditions.Add("MONTH(date) = @month");

            if (selectedYear.HasValue)
                conditions.Add("YEAR(date) = @year");

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if (selectedMonth.HasValue)
                    command.Parameters.Add("@month", MySqlDbType.Int32).Value = selectedMonth.Value;

                if (selectedYear.HasValue)
                    command.Parameters.Add("@year", MySqlDbType.Int32).Value = selectedYear.Value;

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating total expenses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        //total expense count
        private int GetTotalExpenseCount(int? selectedMonth = null, int? selectedYear = null)
        {
            string query = "SELECT COUNT(*) FROM expenses";
            List<string> conditions = new List<string>();

            if (selectedMonth.HasValue)
                conditions.Add("MONTH(date) = @month");

            if (selectedYear.HasValue)
                conditions.Add("YEAR(date) = @year");

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                if (selectedMonth.HasValue)
                    command.Parameters.Add("@month", MySqlDbType.Int32).Value = selectedMonth.Value;

                if (selectedYear.HasValue)
                    command.Parameters.Add("@year", MySqlDbType.Int32).Value = selectedYear.Value;

                try
                {
                    if (connection.State != System.Data.ConnectionState.Open)
                        connection.Open();

                    object result = command.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToInt32(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching total expenses count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //update the buttons after pagination
        private void UpdatePaginationButtons()
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);

            totalPages = totalPages == 0 ? 1 : totalPages;

            // Update page label
            pageLabel.Text = $"Page {currentPage} of {totalPages}";

            // Apply custom styles to buttons
            UpdateButtonStyle(previousButton, currentPage > 1);
            UpdateButtonStyle(nextButton, currentPage < totalPages);
            UpdateButtonStyle(firstPageButton, currentPage > 1);
            UpdateButtonStyle(lastPageButton, currentPage < totalPages);
        }

        //customize button style by state
        private void UpdateButtonStyle(Button button, bool isEnabled)
        {
            button.Enabled = isEnabled;

            if (isEnabled)
            {
                // Active button style
                button.BackColor = Color.DarkTurquoise; // Change to your preferred color
                button.ForeColor = Color.White;
                button.FlatAppearance.BorderColor = Color.DarkTurquoise;
            }
            else
            {
                // Disabled button style
                button.BackColor = Color.LightGray;
                button.ForeColor = Color.DarkGray;
                button.FlatAppearance.BorderColor = Color.Gray;
            }
        }


        // Show the first page 
        private void firstPageButton_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage = 1;
                showExpenses(selectedMonth, selectedYear); // Pass the selected month and year
            }
        }

        // Show the previous page 
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                showExpenses(selectedMonth, selectedYear);
            }
        }

        // Show the next page 
        private void nextButton_Click(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
            if (currentPage < totalPages)
            {
                currentPage++;
                showExpenses(selectedMonth, selectedYear);
            }
        }

        // Show the last page 
        private void lastPageButton_Click_1(object sender, EventArgs e)
        {
            int totalPages = (int)Math.Ceiling((double)totalRecords / recordsPerPage);
            if (currentPage < totalPages)
            {
                currentPage = totalPages;
                showExpenses(selectedMonth, selectedYear); 
            }
        }
        
        //customize close button
        private void closeButtonPictureBox_Click(object sender, EventArgs e)
        {
            //close the app
            System.Environment.Exit(System.Environment.ExitCode);

        }

       //display the selected expense info
        private void expenseDataGridView_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = expenseDataGridView.CurrentRow;

            //select the DGV row
            if (selectedRow != null)
            {
                selectedRow.Selected = true;
            }
            else
            {
                MessageBox.Show("No matching row found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            // Customize selected row colors
            expenseDataGridView.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            expenseDataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;


            if (selectedRow != null && selectedRow.Cells.Count > 0)
            {
                idNumericUpDown.Value = int.TryParse(selectedRow.Cells[0].Value.ToString(), out int result) ? result : 0;
                catergorySelectBox.Text = selectedRow.Cells[1].Value.ToString();
                amountTextBox.Text = selectedRow.Cells[2].Value.ToString();
                dateTimePicker.Value = DateTime.TryParse(selectedRow?.Cells[3]?.Value?.ToString(), out DateTime parsedDate) ? parsedDate : DateTime.Now;
                descriptionTextBox.Text = selectedRow?.Cells[4]?.Value?.ToString() ?? string.Empty;
            }
        }

        //add expense
        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                //INSERT INTO `expenses`( `category`, `amount`, `date`, `description`) VALUES ('@ctg','@amt','@dt','@des')
                string category = catergorySelectBox.Text;
                decimal amount = decimal.Parse(amountTextBox.Text);
                string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
                string description = descriptionTextBox.Text;


                MySqlCommand command = new MySqlCommand("INSERT INTO `expenses`( `category`, `amount`, `date`, `description`) VALUES (@ctg,@amt,@dt,@des)", connection);

                command.Parameters.Add("@ctg", MySqlDbType.VarChar).Value = category;
                command.Parameters.Add("@amt", MySqlDbType.Decimal).Value = amount;
                command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
                command.Parameters.Add("@des", MySqlDbType.Text).Value = description;

                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                if (command.ExecuteNonQuery() == 1)
                {
                    showExpenses();
                    MessageBox.Show("The expense has been added successfully.", "Expense Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show("The expense hasn't been added.", "Expense Not Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the expense info.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        //edit the selected product
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idNumericUpDown.Value;
                string category = catergorySelectBox.Text;
                decimal amount = decimal.Parse(amountTextBox.Text);
                string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
                string description = descriptionTextBox.Text;


                MySqlCommand command = new MySqlCommand("UPDATE `expenses` SET `category`= @ctg,`amount`=@amt,`date`=@dt,`description`=@des WHERE `id` = @id", connection);

                command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;
                command.Parameters.Add("@ctg", MySqlDbType.VarChar).Value = category;
                command.Parameters.Add("@amt", MySqlDbType.Decimal).Value = amount;
                command.Parameters.Add("@dt", MySqlDbType.Date).Value = date;
                command.Parameters.Add("@des", MySqlDbType.Text).Value = description;


                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                if (command.ExecuteNonQuery() == 1)
                {
                    showExpenses(selectedMonth, selectedYear);
                    MessageBox.Show("The expense info has been edited successfully.", "Expense Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show("The expense info hasn't been edited.", "Expense Not Edited", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the expense info.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //search product by id
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)idNumericUpDown.Value;
                DataRow[] row = table.Select("id = " + id);
                if (row.Length > 0)
                {
                    catergorySelectBox.Text = row[0][1].ToString();
                    amountTextBox.Text = row[0][2].ToString();
                    dateTimePicker.Value = DateTime.Parse(row[0][3].ToString());
                    descriptionTextBox.Text = row[0][4].ToString();
                }
                else
                {
                    MessageBox.Show("No expense found with thid id. Enter a new one.", "Expense not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    catergorySelectBox.SelectedIndex = 0;
                    amountTextBox.Text = "";
                    dateTimePicker.Value = DateTime.Now;
                    descriptionTextBox.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Expense not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //remove product by id
        private void removeButton_Click(object sender, EventArgs e)
        {
            //DELETE FROM `expenses` WHERE `id` = @id
            int id = (int)idNumericUpDown.Value;

            MySqlCommand command = new MySqlCommand("DELETE FROM `expenses` WHERE `id` = @id", connection);

            command.Parameters.Add("@id", MySqlDbType.Int16).Value = id;

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            if (MessageBox.Show("Are you sure you want to remove this expense?", "Remove Expense", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    idNumericUpDown.Value = 0;
                    catergorySelectBox.SelectedIndex = 0;
                    amountTextBox.Text = "";
                    dateTimePicker.Value = DateTime.Now;
                    descriptionTextBox.Text = "";
                    showExpenses(selectedMonth, selectedYear);
                    MessageBox.Show("The expense has been removed successfully.", "Expense Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else MessageBox.Show("The expense hasn't been removed.", "Expense Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //clear form data
        private void clearButton_Click(object sender, EventArgs e)
        {
            idNumericUpDown.Value = 0;
            catergorySelectBox.SelectedIndex = 0;
            amountTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            descriptionTextBox.Text = "";
        }

        //amount validation while key up
        private void amountTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // validate the amount
            try
            {
                decimal amount = decimal.Parse(amountTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid amount (" + ex.Message + ")", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                amountTextBox.Text = "";
            }
        }

        //check balance
        private void checkButton_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(incomeInput.Text);
            incomeInput.Text = "";
            decimal totalExpenses = GetTotalMonthlyExpenses();
            decimal remainingBalance = income - totalExpenses;

            if (remainingBalance < 10000)
            {
                // Show a warning if the remaining balance is less than 10,000 Ks
                MessageBox.Show("Warning: Remaining Balance for this Month is less than 10,000 Ks. Remaining Balance: " + remainingBalance + " Ks ",
                                "Low Balance Warning ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                // Show the balance as normal
                MessageBox.Show(" Remaining Balance for this Month: " + remainingBalance + " Ks ",
                                "Balance ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        //get this month expenses
        private decimal GetTotalMonthlyExpenses()
        {
            string query = "SELECT SUM(amount) FROM expenses WHERE MONTH(date) = @month AND YEAR(date) = @year";

            MySqlCommand command = new MySqlCommand(query, connection);

            // Get current month and year
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            command.Parameters.Add("@month", MySqlDbType.Int32).Value = currentMonth;
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = currentYear;

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }

                object result = command.ExecuteScalar(); // Get the single value (SUM)

                // If the result is NULL (no expenses for this month), return 0
                return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total expenses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                connection.Close(); // Ensure the connection is closed
            }
        }


        // Helper method to convert month name to month number
        private int GetMonthFromName(string monthName)
        {
            var months = new Dictionary<string, int>
      {
        { "January", 1 },
        { "February", 2 },
        { "March", 3 },
        { "April", 4 },
        { "May", 5 },
        { "June", 6 },
        { "July", 7 },
        { "August", 8 },
        { "September", 9 },
        { "October", 10 },
        { "November", 11 },
        { "December", 12 }
    };

            return months.ContainsKey(monthName) ? months[monthName] : DateTime.Now.Month;
        }

        //month filter changes
        private void monthFilterSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        //year filter changes
        private void yearFilterSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        //filter process
        private void ApplyFilters()
        {
            // Update selectedMonth based on the selected item in monthFilterSelectBox
            selectedMonth = monthFilterSelectBox.SelectedItem != null
          ? GetMonthFromName(monthFilterSelectBox.SelectedItem?.ToString() ?? "")
          : DateTime.Now.Month;


            // Update selectedYear based on the selected item in yearFilterSelectBox
            selectedYear = yearFilterSelectBox.SelectedIndex > 0
                ? Convert.ToInt32(yearFilterSelectBox.SelectedItem)
                : DateTime.Now.Year;

            // Reset the current page to the first page
            currentPage = 1;

            // Reset the form data
            idNumericUpDown.Value = 0;
            catergorySelectBox.SelectedIndex = 0;
            amountTextBox.Text = "";
            dateTimePicker.Value = DateTime.Now;
            descriptionTextBox.Text = "";

            // call showExpenses with the new filters
            showExpenses(selectedMonth, selectedYear);
           

        }
       

    }
}
