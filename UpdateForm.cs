// UpdateForm.cs
using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MobileStoreApp
{
    public partial class UpdateForm : Form
    {
        private int customerId;
        private SqlConnection conn;

        public UpdateForm(int id)
        {
            InitializeComponent();
            customerId = id;
            conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=MobileStore;Integrated Security=True;Encrypt=False");

            // Load manufacturers first so that comboManufacturer is populated.
            LoadManufacturers();

            // Wire the manufacturer change event.
            comboManufacturer.SelectedIndexChanged += comboManufacturer_SelectedIndexChanged;

            // Now load customer data to pre-select the dropdowns and display customer details.
            LoadCustomerData();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // Optional: Place any code to run when the form loads here.
        }

        private void LoadManufacturers()
        {
            try
            {
                // Use a local connection instance.
                using (SqlConnection localConn = new SqlConnection(conn.ConnectionString))
                {
                    string query = "SELECT ManufacturerID, ManufacturerName FROM Manufacturers";
                    SqlDataAdapter da = new SqlDataAdapter(query, localConn);
                    DataTable dt = new DataTable();
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

        private void LoadModels(int manufacturerID, int selectedModelId = -1)
        {
            try
            {
                using (SqlConnection localConn = new SqlConnection(conn.ConnectionString))
                {
                    string query = "SELECT ModelID, ModelName FROM Models WHERE ManufacturerID = @manufacturerID";
                    SqlDataAdapter da = new SqlDataAdapter(query, localConn);
                    da.SelectCommand.Parameters.AddWithValue("@manufacturerID", manufacturerID);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
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
                MessageBox.Show("Error loading models: " + ex.Message);
            }
        }

        // Updated: Now fetch customer details including name, phone, and features.
        private void LoadCustomerData()
        {
            try
            {
                string query = @"
                    SELECT 
                        c.CustomerName, 
                        c.PhoneNo, 
                        o.ModelID, 
                        m.ManufacturerID,
                        o.BlueTooth,
                        o.FMRadio,
                        o.Camera,
                        o.WiFi
                    FROM Customers c 
                    JOIN Orders o ON c.CustomerID = o.CustomerID
                    JOIN Models m ON o.ModelID = m.ModelID
                    WHERE c.CustomerID = @customerId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // Update your form controls with the retrieved data.
                            txtCustomerID.Text = customerId.ToString();
                            txtName.Text = dr["CustomerName"].ToString();
                            txtPhone.Text = dr["PhoneNo"].ToString();

                            int manufacturerID = Convert.ToInt32(dr["ManufacturerID"]);
                            int modelID = Convert.ToInt32(dr["ModelID"]);

                            comboManufacturer.SelectedValue = manufacturerID;
                            LoadModels(manufacturerID, modelID);

                            // Set feature radio buttons based on database values.
                            radioBluetoothYes.Checked = dr["BlueTooth"].ToString().Trim().ToUpper() == "YES";
                            radioBluetoothNo.Checked = !radioBluetoothYes.Checked;

                            radioFMRadioYes.Checked = dr["FMRadio"].ToString().Trim().ToUpper() == "YES";
                            radioFMRadioNo.Checked = !radioFMRadioYes.Checked;

                            radioCameraYes.Checked = dr["Camera"].ToString().Trim().ToUpper() == "YES";
                            radioCameraNo.Checked = !radioCameraYes.Checked;

                            radioWiFiYes.Checked = dr["WiFi"].ToString().Trim().ToUpper() == "YES";
                            radioWiFiNo.Checked = !radioWiFiYes.Checked;
                        }
                        else
                        {
                            MessageBox.Show("No record found for the specified customer ID.");
                        }
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void comboManufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboManufacturer.SelectedValue != null && int.TryParse(comboManufacturer.SelectedValue.ToString(), out int manufacturerID))
            {
                // When manufacturer changes, load its models without forcing a pre-selection.
                LoadModels(manufacturerID);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn.ConnectionString))
                {
                    connection.Open();

                    // Update Customers table
                    string queryCustomer = "UPDATE Customers SET CustomerName=@CustomerName, PhoneNo=@PhoneNo WHERE CustomerID=@customerId";
                    using (SqlCommand cmdCustomer = new SqlCommand(queryCustomer, connection))
                    {
                        cmdCustomer.Parameters.AddWithValue("@CustomerName", txtName.Text);
                        cmdCustomer.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                        cmdCustomer.Parameters.AddWithValue("@customerId", customerId);
                        cmdCustomer.ExecuteNonQuery();
                    }

                    // Update Orders table
                    string queryOrder = "UPDATE Orders SET ModelID=@ModelID, BlueTooth=@BlueTooth, FMRadio=@FMRadio, Camera=@Camera, WiFi=@WiFi WHERE CustomerID=@customerId";
                    using (SqlCommand cmdOrder = new SqlCommand(queryOrder, connection))
                    {
                        cmdOrder.Parameters.AddWithValue("@ModelID", comboModel.SelectedValue);
                        cmdOrder.Parameters.AddWithValue("@BlueTooth", radioBluetoothYes.Checked ? "YES" : "NO");
                        cmdOrder.Parameters.AddWithValue("@FMRadio", radioFMRadioYes.Checked ? "YES" : "NO");
                        cmdOrder.Parameters.AddWithValue("@Camera", radioCameraYes.Checked ? "YES" : "NO");
                        cmdOrder.Parameters.AddWithValue("@WiFi", radioWiFiYes.Checked ? "YES" : "NO");
                        cmdOrder.Parameters.AddWithValue("@customerId", customerId);
                        cmdOrder.ExecuteNonQuery();
                    }

                    MessageBox.Show("Customer settings updated successfully.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating settings: " + ex.Message);
            }
        }
    }
}