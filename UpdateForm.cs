using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileStoreApp
{
    /// <summary>
    /// A form for updating the details of an existing customer and their order.
    /// </summary>
    public partial class UpdateForm : Form
    {
        #region Member Variables

        // The connection string is made readonly and centralized for easy management.
        private readonly string _connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;Encrypt=False";

        // The ID of the customer being updated is set at creation and should not change.
        private readonly int _customerId;

        #endregion

        #region Constructor

        public UpdateForm(int id)
        {
            InitializeComponent();
            _customerId = id;

            // Wire up the event handler for the manufacturer dropdown.
            comboManufacturer.SelectedIndexChanged += ComboBoxManufacturer_SelectedIndexChanged;

            // Load initial data. It's crucial to load manufacturers first
            // so the control is populated before we try to set its value.
            LoadManufacturers();
            LoadCustomerData();
        }

        #endregion

        #region Database Operations

        /// <summary>
        /// Loads all manufacturers from the database to populate the ComboBox.
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
        /// Loads models for a specific manufacturer into the model ComboBox.
        /// </summary>
        /// <param name="manufacturerID">The ID of the manufacturer.</param>
        /// <param name="selectedModelId">Optional. The ID of the model to pre-select.</param>
        private void LoadModels(int manufacturerID, int selectedModelId = -1)
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
                    comboModel.DataSource = dt;
                    comboModel.DisplayMember = "ModelName";
                    comboModel.ValueMember = "ModelID";

                    if (selectedModelId != -1)
                    {
                        comboModel.SelectedValue = selectedModelId;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading models: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Loads all data for the current customer into the form's controls.
        /// </summary>
        private void LoadCustomerData()
        {
            const string query = @"
                SELECT 
                    c.CustomerName, c.PhoneNo, o.ModelID, m.ManufacturerID,
                    o.BlueTooth, o.FMRadio, o.Camera, o.WiFi
                FROM Customers c 
                JOIN Orders o ON c.CustomerID = o.CustomerID
                JOIN Models m ON o.ModelID = m.ModelID
                WHERE c.CustomerID = @CustomerID;";

            try
            {
                using (var connection = new SqlConnection(_connectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", _customerId);
                    connection.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtCustomerID.Text = _customerId.ToString();
                            txtName.Text = dr["CustomerName"].ToString();
                            txtPhone.Text = dr["PhoneNo"].ToString();

                            int manufacturerID = Convert.ToInt32(dr["ManufacturerID"]);
                            int modelID = Convert.ToInt32(dr["ModelID"]);

                            // Set the manufacturer, which triggers loading the models, then set the model.
                            comboManufacturer.SelectedValue = manufacturerID;
                            LoadModels(manufacturerID, modelID);

                            // Set feature radio buttons.
                            SetRadioButton(radioBluetoothYes, radioBluetoothNo, dr["BlueTooth"]);
                            SetRadioButton(radioFMRadioYes, radioFMRadioNo, dr["FMRadio"]);
                            SetRadioButton(radioCameraYes, radioCameraNo, dr["Camera"]);
                            SetRadioButton(radioWiFiYes, radioWiFiNo, dr["WiFi"]);
                        }
                        else
                        {
                            MessageBox.Show("No record found for the specified customer ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            this.Close(); // Close the form if no data is found.
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the update button click, validating input and saving changes to the database.
        /// </summary>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputFields())
            {
                return; // Stop if validation fails.
            }

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                // Use a transaction to ensure data integrity across both tables.
                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // 1. Update Customers table.
                        const string customerQuery = "UPDATE Customers SET CustomerName=@CustomerName, PhoneNo=@PhoneNo WHERE CustomerID=@CustomerID;";
                        using (var cmd = new SqlCommand(customerQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                            cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                            cmd.Parameters.AddWithValue("@CustomerID", _customerId);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update Orders table.
                        const string orderQuery = "UPDATE Orders SET ModelID=@ModelID, BlueTooth=@BlueTooth, FMRadio=@FMRadio, Camera=@Camera, WiFi=@WiFi WHERE CustomerID=@CustomerID;";
                        using (var cmd = new SqlCommand(orderQuery, connection, transaction))
                        {
                            cmd.Parameters.AddWithValue("@ModelID", comboModel.SelectedValue);
                            cmd.Parameters.AddWithValue("@BlueTooth", GetRadioButtonValue(radioBluetoothYes));
                            cmd.Parameters.AddWithValue("@FMRadio", GetRadioButtonValue(radioFMRadioYes));
                            cmd.Parameters.AddWithValue("@Camera", GetRadioButtonValue(radioCameraYes));
                            cmd.Parameters.AddWithValue("@WiFi", GetRadioButtonValue(radioWiFiYes));
                            cmd.Parameters.AddWithValue("@CustomerID", _customerId);
                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Customer settings updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error updating settings: " + ex.Message, "Transaction Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// When the manufacturer changes, loads the corresponding models.
        /// </summary>
        private void ComboBoxManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboManufacturer.SelectedValue is int manufacturerID)
            {
                // When user changes manufacturer, load new models without a pre-selection.
                LoadModels(manufacturerID);
            }
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Validates user input fields before an update.
        /// </summary>
        /// <returns>True if input is valid, otherwise false.</returns>
        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || comboManufacturer.SelectedValue == null || comboModel.SelectedValue == null)
            {
                MessageBox.Show("Name, Manufacturer, and Model cannot be empty.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the string value ("YES" or "NO") from a RadioButton.
        /// </summary>
        private string GetRadioButtonValue(RadioButton yesButton)
        {
            return yesButton.Checked ? "YES" : "NO";
        }

        /// <summary>
        /// Sets a pair of radio buttons based on a database string value.
        /// </summary>
        private void SetRadioButton(RadioButton yesButton, RadioButton noButton, object dbValue)
        {
            yesButton.Checked = dbValue.ToString().Trim().Equals("YES", StringComparison.OrdinalIgnoreCase);
            noButton.Checked = !yesButton.Checked;
        }

        #endregion
    }
}