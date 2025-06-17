using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MobileStoreApp
{
    public partial class Form1 : Form
    {
        private readonly SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private Timer manufacturerTimer;
        private readonly object _modelsLock = new object();
        private bool isLoadingModels = false;

        public Form1()
        {
            InitializeComponent();

            // Initialize database connection
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;Encrypt=False;MultipleActiveResultSets=True");

            // Wire up events
            comboManufacturer.SelectedIndexChanged += ComboManufacturer_SelectedIndexChanged;
            dgvCustomers.CellDoubleClick += DgvCustomers_CellDoubleClick;
            dgvCustomers.CellContentDoubleClick += dgvCustomers_CellContentDoubleClick;

            // Initialize timer for manufacturer selection delay
            InitializeManufacturerTimer();

            // Populate combo boxes
            LoadManufacturers();

            // Force an initial models load (if available)
            if (comboManufacturer.SelectedValue != null && !(comboManufacturer.SelectedValue is DataRowView))
            {
                int manufacturerID = Convert.ToInt32(comboManufacturer.SelectedValue);
                LoadModels(manufacturerID);
            }

            ds = new DataSet();
            LoadData();

            dgvCustomers.ReadOnly = true;
        }

        private void InitializeManufacturerTimer()
        {
            manufacturerTimer = new Timer();
            manufacturerTimer.Interval = 1000; // 1 second delay
            manufacturerTimer.Tick += ManufacturerTimer_Tick;
        }

        private void ManufacturerTimer_Tick(object sender, EventArgs e)
        {
            manufacturerTimer.Stop();
            if (comboManufacturer.SelectedValue != null && !(comboManufacturer.SelectedValue is DataRowView))
            {
                int manufacturerID = Convert.ToInt32(comboManufacturer.SelectedValue);
                LoadModels(manufacturerID);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Customize DataGridView appearance
        }

        private void LoadManufacturers()
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    string query = "SELECT ManufacturerID, ManufacturerName FROM Manufacturers";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        connection.Open();
                        da.Fill(dt);
                        comboManufacturer.DataSource = dt;
                        comboManufacturer.DisplayMember = "ManufacturerName";
                        comboManufacturer.ValueMember = "ManufacturerID";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading manufacturers: " + ex.Message);
                }
            }
        }

        private void LoadModels(int manufacturerID, int selectedModelId = -1)
        {
            lock (_modelsLock)
            {
                if (isLoadingModels)
                {
                    Debug.WriteLine("LoadModels skipped for manufacturerID " + manufacturerID + ": already loading.");
                    return;
                }
                isLoadingModels = true;
            }

            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection localConn = new SqlConnection(conn.ConnectionString))
                {
                    localConn.Open();
                    string query = "SELECT ModelID, ModelName FROM Models WHERE ManufacturerID = @manufacturerID";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, localConn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@manufacturerID", manufacturerID);
                        da.Fill(dt);
                    }
                }
                Debug.WriteLine("LoadModels: Loaded " + dt.Rows.Count + " models for manufacturerID " + manufacturerID);

                DataTable dtCopy = dt.Copy();
                if (comboModel.InvokeRequired)
                {
                    comboModel.Invoke(new Action(() =>
                    {
                        comboModel.DataSource = dtCopy;
                        comboModel.DisplayMember = "ModelName";
                        comboModel.ValueMember = "ModelID";
                        if (selectedModelId != -1)
                            comboModel.SelectedValue = selectedModelId;
                    }));
                }
                else
                {
                    comboModel.DataSource = dtCopy;
                    comboModel.DisplayMember = "ModelName";
                    comboModel.ValueMember = "ModelID";
                    if (selectedModelId != -1)
                        comboModel.SelectedValue = selectedModelId;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error loading models for manufacturerID " + manufacturerID + ": " + ex.Message);
                MessageBox.Show("Error loading models: " + ex.Message);
            }
            finally
            {
                lock (_modelsLock)
                {
                    isLoadingModels = false;
                }
            }
        }

        private string GetRadioButtonValue(RadioButton yesButton, RadioButton noButton)
        {
            return yesButton.Checked ? "YES" : "NO";
        }

        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    string query = @"
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
                        JOIN Models m ON o.ModelID = m.ModelID";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        connection.Open();
                        ds.Clear();
                        da.Fill(ds, "Customers");
                        dgvCustomers.DataSource = ds.Tables["Customers"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                comboManufacturer.SelectedIndex == -1 ||
                comboModel.SelectedIndex == -1 ||
                (!radioBluetoothYes.Checked && !radioBluetoothNo.Checked) ||
                (!radioFMRadioYes.Checked && !radioFMRadioNo.Checked) ||
                (!radioCameraYes.Checked && !radioCameraNo.Checked) ||
                (!radioWifiYes.Checked && !radioWifiNo.Checked))
            {
                MessageBox.Show("Please fill in all fields and select all features.");
                return;
            }

            if (!Regex.IsMatch(txtName.Text, "^[A-Za-z ]+$"))
            {
                MessageBox.Show("Name must contain only letters and spaces.");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, "^\\d{11}$"))
            {
                MessageBox.Show("Phone number must be exactly 11 digits.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    string query = "INSERT INTO Customers (CustomerName, PhoneNo) VALUES (@CustomerName, @PhoneNo); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", txtName.Text);
                        cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                        connection.Open();
                        int customerID = Convert.ToInt32(cmd.ExecuteScalar());

                        string query2 = "INSERT INTO Orders (CustomerID, ModelID, Price, BlueTooth, FMRadio, Camera, WiFi) " +
                                        "VALUES (@CustomerID, @ModelID, @Price, @BlueTooth, @FMRadio, @Camera, @WiFi)";
                        using (SqlCommand cmd2 = new SqlCommand(query2, connection))
                        {
                            cmd2.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd2.Parameters.AddWithValue("@ModelID", comboModel.SelectedValue);
                            cmd2.Parameters.AddWithValue("@Price", price);
                            cmd2.Parameters.AddWithValue("@BlueTooth", GetRadioButtonValue(radioBluetoothYes, radioBluetoothNo));
                            cmd2.Parameters.AddWithValue("@FMRadio", GetRadioButtonValue(radioFMRadioYes, radioFMRadioNo));
                            cmd2.Parameters.AddWithValue("@Camera", GetRadioButtonValue(radioCameraYes, radioCameraNo));
                            cmd2.Parameters.AddWithValue("@WiFi", GetRadioButtonValue(radioWifiYes, radioWifiNo));
                            cmd2.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("Customer added successfully!");
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding customer: " + ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    string query = @"
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
                        WHERE c.CustomerName LIKE @Search OR c.PhoneNo LIKE @Search";
                    using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                        DataSet dsSearch = new DataSet();
                        connection.Open();
                        da.Fill(dsSearch, "Customers");
                        dgvCustomers.DataSource = dsSearch.Tables["Customers"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching: " + ex.Message);
                }
            }
        }

        private bool CustomerExists(int id)
        {
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    string query = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        connection.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking customer existence: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // Get the customer ID from the search textbox.
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || !int.TryParse(txtSearch.Text, out int customerID))
            {
                MessageBox.Show("Please enter a valid numeric customer ID in the search box.");
                return;
            }

            // Check if a record exists for the given customer ID
            if (!CustomerExists(customerID))
            {
                MessageBox.Show("No record exists for the entered customer ID.");
                return;
            }

            // Open the UpdateForm, passing the customer ID
            UpdateForm updateForm = new UpdateForm(customerID);
            updateForm.ShowDialog();

            // Refresh the grid after closing UpdateForm
            LoadData();
        }

        private void LoadCustomerData_CommandBehavior(int custId)
        {
            string query = @"
                SELECT 
                    c.CustomerName, 
                    c.PhoneNo, 
                    o.ModelID, 
                    o.BlueTooth, 
                    o.FMRadio, 
                    o.Camera, 
                    o.WiFi, 
                    m.ManufacturerID
                FROM Customers c 
                JOIN Orders o ON c.CustomerID = o.CustomerID
                JOIN Models m ON o.ModelID = m.ModelID
                WHERE c.CustomerID = @customerId";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerId", custId);
                try
                {
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (dr.Read())
                        {
                            txtName.Text = dr["CustomerName"].ToString();
                            txtPhone.Text = dr["PhoneNo"].ToString();
                            int manufacturerID = Convert.ToInt32(dr["ManufacturerID"]);
                            int modelID = Convert.ToInt32(dr["ModelID"]);
                            comboManufacturer.SelectedValue = manufacturerID;
                            LoadModels(manufacturerID, modelID);

                            string bluetooth = dr["BlueTooth"].ToString().Trim().ToUpper();
                            radioBluetoothYes.Checked = (bluetooth == "YES");
                            radioBluetoothNo.Checked = (bluetooth != "YES");
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified customer.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                }
            }
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || !int.TryParse(txtSearch.Text, out int custId))
            {
                MessageBox.Show("Invalid customer ID.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
            {
                try
                {
                    connection.Open();
                    string queryCust = "UPDATE Customers SET CustomerName = @CustomerName, PhoneNo = @PhoneNo WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmdCust = new SqlCommand(queryCust, connection))
                    {
                        cmdCust.Parameters.AddWithValue("@CustomerName", txtName.Text);
                        cmdCust.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                        cmdCust.Parameters.AddWithValue("@CustomerID", custId);
                        cmdCust.ExecuteNonQuery();
                    }
                    string queryOrder = "UPDATE Orders SET ModelID = @ModelID, BlueTooth = @BlueTooth, FMRadio = @FMRadio, Camera = @Camera, WiFi = @WiFi WHERE CustomerID = @CustomerID";
                    using (SqlCommand cmdOrder = new SqlCommand(queryOrder, connection))
                    {
                        cmdOrder.Parameters.AddWithValue("@ModelID", comboModel.SelectedValue);
                        cmdOrder.Parameters.AddWithValue("@BlueTooth", GetRadioButtonValue(radioBluetoothYes, radioBluetoothNo));
                        cmdOrder.Parameters.AddWithValue("@FMRadio", GetRadioButtonValue(radioFMRadioYes, radioFMRadioNo));
                        cmdOrder.Parameters.AddWithValue("@Camera", GetRadioButtonValue(radioCameraYes, radioCameraNo));
                        cmdOrder.Parameters.AddWithValue("@WiFi", GetRadioButtonValue(radioWifiYes, radioWifiNo));
                        cmdOrder.Parameters.AddWithValue("@CustomerID", custId);
                        cmdOrder.ExecuteNonQuery();
                    }
                    MessageBox.Show("Customer data updated successfully!");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving customer data: " + ex.Message);
                }
            }
        }

        private void DgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                int customerID = Convert.ToInt32(dgvCustomers.Rows[e.RowIndex].Cells["MID"].Value);
                if (MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                    {
                        string query = "DELETE FROM Orders WHERE CustomerID = @CustomerID";
                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            connection.Open();
                            cmd.ExecuteNonQuery();
                        }
                        string query2 = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        using (SqlCommand cmd = new SqlCommand(query2, connection))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadData();
                    MessageBox.Show("Customer deleted successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting customer: " + ex.Message);
            }
        }

        private void dgvCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DgvCustomers_CellDoubleClick(sender, e);
        }

        private void ComboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboManufacturer.SelectedValue == null || comboManufacturer.SelectedValue is DataRowView)
                return;
            comboManufacturer.SelectedIndexChanged -= ComboManufacturer_SelectedIndexChanged;
            int manufacturerID = Convert.ToInt32(comboManufacturer.SelectedValue);
            LoadModels(manufacturerID);
            comboManufacturer.SelectedIndexChanged += ComboManufacturer_SelectedIndexChanged;
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtPrice.Clear();
            comboModel.SelectedIndex = -1;
            comboManufacturer.SelectedIndex = -1;
            radioBluetoothYes.Checked = false;
            radioBluetoothNo.Checked = false;
            radioFMRadioYes.Checked = false;
            radioFMRadioNo.Checked = false;
            radioCameraYes.Checked = false;
            radioCameraNo.Checked = false;
            radioWifiYes.Checked = false;
            radioWifiNo.Checked = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}