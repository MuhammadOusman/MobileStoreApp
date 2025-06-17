using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileStoreApp
{
    /// <summary>
    /// The main form for the Mobile Store application.
    /// Handles displaying customer data, adding new customers, and initiating search/update/delete operations.
    /// </summary>
    public partial class Form1 : Form
    {
        #region Member Variables

        // Database connection string. For production apps, this should be stored in App.config.
        private readonly string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;Encrypt=False";

        // DataSet to hold customer and order information for the DataGridView.
        private readonly DataSet _dataSet = new DataSet();

        #endregion

        #region Constructor and Initialization

        public Form1()
        {
            InitializeComponent();

            // Set the DataGridView to be read-only to prevent direct editing.
            dgvCustomers.ReadOnly = true;

            // Load initial data from the database into UI controls.
            LoadManufacturers();
            LoadAllCustomerData();

            // Wire up event handlers for UI controls.
            // Note: The actual assignment (e.g., this.btnAddCustomer.Click += ...) is in Form1.Designer.cs
            // This is just to confirm the handlers this class is responsible for.
            comboManufacturer.SelectedIndexChanged += ComboManufacturer_SelectedIndexChanged;
            dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
        }

        #endregion

        #region Database Operations

        /// <summary>
        /// Loads all manufacturers from the database and populates the manufacturer combo box.
        /// </summary>
        private void LoadManufacturers()
        {
            const string query = "SELECT ManufacturerID, ManufacturerName FROM Manufacturers ORDER BY ManufacturerName;";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the ComboBox.
                    comboManufacturer.DataSource = dt;
                    comboManufacturer.DisplayMember = "ManufacturerName";
                    comboManufacturer.ValueMember = "ManufacturerID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading manufacturers: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads models for a given manufacturer and populates the model combo box.
        /// </summary>
        /// <param name="manufacturerID">The ID of the manufacturer for which to load models.</param>
        private void LoadModels(int manufacturerID)
        {
            const string query = "SELECT ModelID, ModelName FROM Models WHERE ManufacturerID = @ManufacturerID ORDER BY ModelName;";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@ManufacturerID", manufacturerID);

                    var dt = new DataTable();
                    adapter.Fill(dt);

                    // To prevent triggering SelectedIndexChanged event while updating the data source,
                    // we temporarily unsubscribe from the event.
                    comboModel.SelectedIndexChanged -= ComboModel_SelectedIndexChanged;
                    comboModel.DataSource = dt;
                    comboModel.DisplayMember = "ModelName";
                    comboModel.ValueMember = "ModelID";
                    comboModel.SelectedIndexChanged += ComboModel_SelectedIndexChanged;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fetches all customer and order data from the database and populates the DataGridView.
        /// </summary>
        private void LoadAllCustomerData()
        {
            const string query = @"
                SELECT 
                    c.CustomerID AS MID, 
                    c.CustomerName, 
                    c.PhoneNo, 
                    m.ModelName AS MobileName, 
                    o.Price, 
                    m.ModelID AS ModelNo, 
                    o.BlueTooth, 
                    o.FMRadio, 
                    o.Camera, 
                    o.WiFi
                FROM Customers c
                JOIN Orders o ON c.CustomerID = o.CustomerID
                JOIN Models m ON o.ModelID = m.ModelID
                ORDER BY c.CustomerID DESC;";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    _dataSet.Clear();
                    adapter.Fill(_dataSet, "Customers");
                    dgvCustomers.DataSource = _dataSet.Tables["Customers"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Checks if a customer with the specified ID exists in the database.
        /// </summary>
        /// <param name="id">The ID of the customer to check.</param>
        /// <returns>True if the customer exists, otherwise false.</returns>
        private bool CustomerExists(int id)
        {
            const string query = "SELECT COUNT(1) FROM Customers WHERE CustomerID = @id";
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking customer existence: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles adding a new customer and their order to the database.
        /// </summary>
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            // --- Input Validation ---
            if (!ValidateInputFields(out decimal price))
            {
                return; // Stop if validation fails.
            }

            // --- Database Insertion with Transaction ---
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Start a transaction to ensure both inserts succeed or fail together.
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert into Customers table and get the new CustomerID.
                        const string customerQuery = "INSERT INTO Customers (CustomerName, PhoneNo) VALUES (@CustomerName, @PhoneNo); SELECT SCOPE_IDENTITY();";
                        int customerID;
                        using (var cmd = new SqlCommand(customerQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                            cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                            customerID = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Insert into Orders table using the new CustomerID.
                        const string orderQuery = "INSERT INTO Orders (CustomerID, ModelID, Price, BlueTooth, FMRadio, Camera, WiFi) " +
                                                  "VALUES (@CustomerID, @ModelID, @Price, @BlueTooth, @FMRadio, @Camera, @WiFi)";
                        using (var cmd2 = new SqlCommand(orderQuery, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd2.Parameters.AddWithValue("@ModelID", comboModel.SelectedValue);
                            cmd2.Parameters.AddWithValue("@Price", price);
                            cmd2.Parameters.AddWithValue("@BlueTooth", GetRadioButtonValue(radioBluetoothYes));
                            cmd2.Parameters.AddWithValue("@FMRadio", GetRadioButtonValue(radioFMRadioYes));
                            cmd2.Parameters.AddWithValue("@Camera", GetRadioButtonValue(radioCameraYes));
                            cmd2.Parameters.AddWithValue("@WiFi", GetRadioButtonValue(radioWifiYes));
                            cmd2.ExecuteNonQuery();
                        }

                        // If both commands succeed, commit the transaction.
                        transaction.Commit();

                        LoadAllCustomerData(); // Refresh the grid.
                        MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputFields();
                    }
                    catch (Exception ex)
                    {
                        // If an error occurs, roll back the transaction.
                        transaction.Rollback();
                        MessageBox.Show("Error adding customer: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Searches for customers by name or phone number and updates the DataGridView.
        /// </summary>
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            const string query = @"
                SELECT c.CustomerID AS MID, c.CustomerName, c.PhoneNo, m.ModelName AS MobileName, o.Price, 
                       m.ModelID AS ModelNo, o.BlueTooth, o.FMRadio, o.Camera, o.WiFi
                FROM Customers c 
                JOIN Orders o ON c.CustomerID = o.CustomerID 
                JOIN Models m ON o.ModelID = m.ModelID 
                WHERE c.CustomerName LIKE @Search OR c.PhoneNo LIKE @Search;";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text.Trim() + "%");
                    var searchDataSet = new DataSet();
                    adapter.Fill(searchDataSet, "Customers");
                    dgvCustomers.DataSource = searchDataSet.Tables["Customers"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Opens the UpdateForm for the customer ID specified in the search box.
        /// </summary>
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || !int.TryParse(txtSearch.Text, out int customerID))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID in the search box to update.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!CustomerExists(customerID))
            {
                MessageBox.Show("No customer record exists for the entered ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open the UpdateForm, passing it the customer ID.
            using (var updateForm = new UpdateForm(customerID))
            {
                updateForm.ShowDialog();
            }

            // Refresh the grid after the update form is closed.
            LoadAllCustomerData();
        }

        /// <summary>
        /// Handles the deletion of a customer record when a cell is double-clicked.
        /// </summary>
        private void DgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header double-clicks.

            int customerID = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["MID"].Value);
            string customerName = dgvCustomers.Rows[e.RowIndex].Cells["CustomerName"].Value.ToString();

            var confirmResult = MessageBox.Show($"Are you sure you want to delete {customerName} (ID: {customerID})?\nThis action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Use a transaction to ensure both deletes are successful.
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // First, delete the related order.
                        const string orderQuery = "DELETE FROM Orders WHERE CustomerID = @CustomerID";
                        using (var cmd = new SqlCommand(orderQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd.ExecuteNonQuery();
                        }

                        // Then, delete the customer.
                        const string customerQuery = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        using (var cmd2 = new SqlCommand(customerQuery, connection, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd2.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        LoadAllCustomerData(); // Refresh the grid.
                        MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error deleting customer: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Loads the relevant models when the selected manufacturer changes.
        /// </summary>
        private void ComboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboManufacturer.SelectedValue is int manufacturerID)
            {
                LoadModels(manufacturerID);
            }
        }

        /// <summary>
        /// A placeholder event handler for the model ComboBox.
        /// </summary>
        private void ComboModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This can be used for model-specific logic in the future.
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Retrieves the value "YES" or "NO" from a pair of radio buttons.
        /// </summary>
        /// <param name="yesButton">The "Yes" radio button.</param>
        /// <returns>"YES" if checked, otherwise "NO".</returns>
        private string GetRadioButtonValue(RadioButton yesButton)
        {
            return yesButton.Checked ? "YES" : "NO";
        }

        /// <summary>
        /// Validates all user input fields before adding a customer.
        /// </summary>
        /// <param name="price">The parsed decimal price if validation is successful.</param>
        /// <returns>True if all fields are valid, otherwise false.</returns>
        private bool ValidateInputFields(out decimal price)
        {
            price = 0;

            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                comboManufacturer.SelectedIndex == -1 ||
                comboModel.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all text fields and selections.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!radioBluetoothYes.Checked && !radioBluetoothNo.Checked ||
                !radioFMRadioYes.Checked && !radioFMRadioNo.Checked ||
                !radioCameraYes.Checked && !radioCameraNo.Checked ||
                !radioWifiYes.Checked && !radioWifiNo.Checked)
            {
                MessageBox.Show("Please select an option for all features (Yes/No).", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("Name must contain only letters and spaces.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true; // All validations passed.
        }

        /// <summary>
        /// Clears all input fields on the form.
        /// </summary>
        private void ClearInputFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtPrice.Clear();
            txtSearch.Clear();
            comboModel.DataSource = null;
            comboManufacturer.SelectedIndex = -1;

            // Uncheck all radio buttons.
            radioBluetoothYes.Checked = false;
            radioBluetoothNo.Checked = false;
            radioFMRadioYes.Checked = false;
            radioFMRadioNo.Checked = false;
            radioCameraYes.Checked = false;
            radioCameraNo.Checked = false;
            radioWifiYes.Checked = false;
            radioWifiNo.Checked = false;
        }

        #endregion
    }
}