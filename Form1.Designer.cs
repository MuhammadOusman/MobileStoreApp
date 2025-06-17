namespace MobileStoreApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // All original control names are preserved for 100% compatibility.
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox comboManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.RadioButton radioBluetoothYes;
        private System.Windows.Forms.RadioButton radioBluetoothNo;
        private System.Windows.Forms.RadioButton radioFMRadioYes;
        private System.Windows.Forms.RadioButton radioFMRadioNo;
        private System.Windows.Forms.RadioButton radioCameraYes;
        private System.Windows.Forms.RadioButton radioCameraNo;
        private System.Windows.Forms.RadioButton radioWifiYes;
        private System.Windows.Forms.RadioButton radioWifiNo;
        private System.Windows.Forms.GroupBox gbBluetooth;
        private System.Windows.Forms.GroupBox gbFMRadio;
        private System.Windows.Forms.GroupBox gbCamera;
        private System.Windows.Forms.GroupBox gbWiFi;
        private System.Windows.Forms.Panel panelDetails;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDetailsTitle;
        private System.Windows.Forms.Label lblActionsTitle;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.comboManufacturer = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.radioBluetoothYes = new System.Windows.Forms.RadioButton();
            this.radioBluetoothNo = new System.Windows.Forms.RadioButton();
            this.radioFMRadioYes = new System.Windows.Forms.RadioButton();
            this.radioFMRadioNo = new System.Windows.Forms.RadioButton();
            this.radioCameraYes = new System.Windows.Forms.RadioButton();
            this.radioCameraNo = new System.Windows.Forms.RadioButton();
            this.radioWifiYes = new System.Windows.Forms.RadioButton();
            this.radioWifiNo = new System.Windows.Forms.RadioButton();
            this.gbBluetooth = new System.Windows.Forms.GroupBox();
            this.gbFMRadio = new System.Windows.Forms.GroupBox();
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.gbWiFi = new System.Windows.Forms.GroupBox();
            this.panelDetails = new System.Windows.Forms.Panel();
            this.lblDetailsTitle = new System.Windows.Forms.Label();
            this.panelActions = new System.Windows.Forms.Panel();
            this.lblActionsTitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbBluetooth.SuspendLayout();
            this.gbFMRadio.SuspendLayout();
            this.gbCamera.SuspendLayout();
            this.gbWiFi.SuspendLayout();
            this.panelDetails.SuspendLayout();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeight = 35;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.dgvCustomers.Location = new System.Drawing.Point(40, 420);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCustomers.RowTemplate.Height = 30;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(948, 252);
            this.dgvCustomers.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(140, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 25);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(450, 60);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 25);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.White;
            this.txtPrice.Location = new System.Drawing.Point(450, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(180, 25);
            this.txtPrice.TabIndex = 5;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(513, 238);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(117, 35);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "ADD";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(30, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdateCustomer.FlatAppearance.BorderSize = 0;
            this.btnUpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(30, 142);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(220, 35);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "UPDATE";
            this.btnUpdateCustomer.UseVisualStyleBackColor = false;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.Location = new System.Drawing.Point(30, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPhone.Location = new System.Drawing.Point(340, 64);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrice.Location = new System.Drawing.Point(340, 104);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price:";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(30, 60);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 25);
            this.txtSearch.TabIndex = 11;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblManufacturer.Location = new System.Drawing.Point(30, 104);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(92, 17);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // comboManufacturer
            // 
            this.comboManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.comboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboManufacturer.ForeColor = System.Drawing.Color.White;
            this.comboManufacturer.FormattingEnabled = true;
            this.comboManufacturer.Location = new System.Drawing.Point(140, 100);
            this.comboManufacturer.Name = "comboManufacturer";
            this.comboManufacturer.Size = new System.Drawing.Size(180, 23);
            this.comboManufacturer.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblModel.Location = new System.Drawing.Point(30, 144);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 17);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "Model:";
            // 
            // comboModel
            // 
            this.comboModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboModel.ForeColor = System.Drawing.Color.White;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(140, 140);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(180, 23);
            this.comboModel.TabIndex = 4;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.ComboModel_SelectedIndexChanged);
            // 
            // radioBluetoothYes
            // 
            this.radioBluetoothYes.AutoSize = true;
            this.radioBluetoothYes.Location = new System.Drawing.Point(10, 20);
            this.radioBluetoothYes.Name = "radioBluetoothYes";
            this.radioBluetoothYes.Size = new System.Drawing.Size(46, 21);
            this.radioBluetoothYes.TabIndex = 6;
            this.radioBluetoothYes.TabStop = true;
            this.radioBluetoothYes.Text = "Yes";
            this.radioBluetoothYes.UseVisualStyleBackColor = true;
            // 
            // radioBluetoothNo
            // 
            this.radioBluetoothNo.AutoSize = true;
            this.radioBluetoothNo.Location = new System.Drawing.Point(80, 20);
            this.radioBluetoothNo.Name = "radioBluetoothNo";
            this.radioBluetoothNo.Size = new System.Drawing.Size(42, 21);
            this.radioBluetoothNo.TabIndex = 7;
            this.radioBluetoothNo.TabStop = true;
            this.radioBluetoothNo.Text = "No";
            this.radioBluetoothNo.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioYes
            // 
            this.radioFMRadioYes.AutoSize = true;
            this.radioFMRadioYes.Location = new System.Drawing.Point(10, 20);
            this.radioFMRadioYes.Name = "radioFMRadioYes";
            this.radioFMRadioYes.Size = new System.Drawing.Size(46, 21);
            this.radioFMRadioYes.TabIndex = 8;
            this.radioFMRadioYes.TabStop = true;
            this.radioFMRadioYes.Text = "Yes";
            this.radioFMRadioYes.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioNo
            // 
            this.radioFMRadioNo.AutoSize = true;
            this.radioFMRadioNo.Location = new System.Drawing.Point(80, 20);
            this.radioFMRadioNo.Name = "radioFMRadioNo";
            this.radioFMRadioNo.Size = new System.Drawing.Size(42, 21);
            this.radioFMRadioNo.TabIndex = 9;
            this.radioFMRadioNo.TabStop = true;
            this.radioFMRadioNo.Text = "No";
            this.radioFMRadioNo.UseVisualStyleBackColor = true;
            // 
            // radioCameraYes
            // 
            this.radioCameraYes.AutoSize = true;
            this.radioCameraYes.Location = new System.Drawing.Point(10, 20);
            this.radioCameraYes.Name = "radioCameraYes";
            this.radioCameraYes.Size = new System.Drawing.Size(46, 21);
            this.radioCameraYes.TabIndex = 27;
            this.radioCameraYes.TabStop = true;
            this.radioCameraYes.Text = "Yes";
            this.radioCameraYes.UseVisualStyleBackColor = true;
            // 
            // radioCameraNo
            // 
            this.radioCameraNo.AutoSize = true;
            this.radioCameraNo.Location = new System.Drawing.Point(80, 20);
            this.radioCameraNo.Name = "radioCameraNo";
            this.radioCameraNo.Size = new System.Drawing.Size(42, 21);
            this.radioCameraNo.TabIndex = 28;
            this.radioCameraNo.TabStop = true;
            this.radioCameraNo.Text = "No";
            this.radioCameraNo.UseVisualStyleBackColor = true;
            // 
            // radioWifiYes
            // 
            this.radioWifiYes.AutoSize = true;
            this.radioWifiYes.Location = new System.Drawing.Point(10, 20);
            this.radioWifiYes.Name = "radioWifiYes";
            this.radioWifiYes.Size = new System.Drawing.Size(46, 21);
            this.radioWifiYes.TabIndex = 30;
            this.radioWifiYes.TabStop = true;
            this.radioWifiYes.Text = "Yes";
            this.radioWifiYes.UseVisualStyleBackColor = true;
            // 
            // radioWifiNo
            // 
            this.radioWifiNo.AutoSize = true;
            this.radioWifiNo.Location = new System.Drawing.Point(80, 20);
            this.radioWifiNo.Name = "radioWifiNo";
            this.radioWifiNo.Size = new System.Drawing.Size(42, 21);
            this.radioWifiNo.TabIndex = 31;
            this.radioWifiNo.TabStop = true;
            this.radioWifiNo.Text = "No";
            this.radioWifiNo.UseVisualStyleBackColor = true;
            // 
            // gbBluetooth
            // 
            this.gbBluetooth.Controls.Add(this.radioBluetoothYes);
            this.gbBluetooth.Controls.Add(this.radioBluetoothNo);
            this.gbBluetooth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbBluetooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBluetooth.Location = new System.Drawing.Point(33, 184);
            this.gbBluetooth.Name = "gbBluetooth";
            this.gbBluetooth.Size = new System.Drawing.Size(130, 48);
            this.gbBluetooth.TabIndex = 33;
            this.gbBluetooth.TabStop = false;
            this.gbBluetooth.Text = "Bluetooth";
            // 
            // gbFMRadio
            // 
            this.gbFMRadio.Controls.Add(this.radioFMRadioYes);
            this.gbFMRadio.Controls.Add(this.radioFMRadioNo);
            this.gbFMRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbFMRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbFMRadio.Location = new System.Drawing.Point(180, 184);
            this.gbFMRadio.Name = "gbFMRadio";
            this.gbFMRadio.Size = new System.Drawing.Size(130, 48);
            this.gbFMRadio.TabIndex = 34;
            this.gbFMRadio.TabStop = false;
            this.gbFMRadio.Text = "FM Radio";
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.radioCameraYes);
            this.gbCamera.Controls.Add(this.radioCameraNo);
            this.gbCamera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCamera.Location = new System.Drawing.Point(327, 184);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(130, 48);
            this.gbCamera.TabIndex = 35;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Camera";
            // 
            // gbWiFi
            // 
            this.gbWiFi.Controls.Add(this.radioWifiYes);
            this.gbWiFi.Controls.Add(this.radioWifiNo);
            this.gbWiFi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbWiFi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbWiFi.Location = new System.Drawing.Point(474, 184);
            this.gbWiFi.Name = "gbWiFi";
            this.gbWiFi.Size = new System.Drawing.Size(130, 48);
            this.gbWiFi.TabIndex = 36;
            this.gbWiFi.TabStop = false;
            this.gbWiFi.Text = "WiFi";
            // 
            // panelDetails
            // 
            this.panelDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelDetails.Controls.Add(this.gbWiFi);
            this.panelDetails.Controls.Add(this.lblDetailsTitle);
            this.panelDetails.Controls.Add(this.gbCamera);
            this.panelDetails.Controls.Add(this.lblName);
            this.panelDetails.Controls.Add(this.gbFMRadio);
            this.panelDetails.Controls.Add(this.btnAddCustomer);
            this.panelDetails.Controls.Add(this.gbBluetooth);
            this.panelDetails.Controls.Add(this.txtName);
            this.panelDetails.Controls.Add(this.txtPhone);
            this.panelDetails.Controls.Add(this.txtPrice);
            this.panelDetails.Controls.Add(this.comboModel);
            this.panelDetails.Controls.Add(this.lblPhone);
            this.panelDetails.Controls.Add(this.lblModel);
            this.panelDetails.Controls.Add(this.lblPrice);
            this.panelDetails.Controls.Add(this.lblManufacturer);
            this.panelDetails.Controls.Add(this.comboManufacturer);
            this.panelDetails.Location = new System.Drawing.Point(40, 90);
            this.panelDetails.Name = "panelDetails";
            this.panelDetails.Size = new System.Drawing.Size(650, 290);
            this.panelDetails.TabIndex = 40;
            // 
            // lblDetailsTitle
            // 
            this.lblDetailsTitle.AutoSize = true;
            this.lblDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailsTitle.ForeColor = System.Drawing.Color.White;
            this.lblDetailsTitle.Location = new System.Drawing.Point(25, 16);
            this.lblDetailsTitle.Name = "lblDetailsTitle";
            this.lblDetailsTitle.Size = new System.Drawing.Size(161, 25);
            this.lblDetailsTitle.TabIndex = 37;
            this.lblDetailsTitle.Text = "Customer Details";
            // 
            // panelActions
            // 
            this.panelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelActions.Controls.Add(this.lblActionsTitle);
            this.panelActions.Controls.Add(this.txtSearch);
            this.panelActions.Controls.Add(this.btnSearch);
            this.panelActions.Controls.Add(this.btnUpdateCustomer);
            this.panelActions.Location = new System.Drawing.Point(710, 90);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(280, 200);
            this.panelActions.TabIndex = 41;
            // 
            // lblActionsTitle
            // 
            this.lblActionsTitle.AutoSize = true;
            this.lblActionsTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblActionsTitle.ForeColor = System.Drawing.Color.White;
            this.lblActionsTitle.Location = new System.Drawing.Point(25, 16);
            this.lblActionsTitle.Name = "lblActionsTitle";
            this.lblActionsTitle.Size = new System.Drawing.Size(76, 25);
            this.lblActionsTitle.TabIndex = 38;
            this.lblActionsTitle.Text = "Actions";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(33, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(384, 38);
            this.lblTitle.TabIndex = 42;
            this.lblTitle.Text = "Mobile Store Management";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1028, 704);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.panelDetails);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mobile Store";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbBluetooth.ResumeLayout(false);
            this.gbBluetooth.PerformLayout();
            this.gbFMRadio.ResumeLayout(false);
            this.gbFMRadio.PerformLayout();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            this.gbWiFi.ResumeLayout(false);
            this.gbWiFi.PerformLayout();
            this.panelDetails.ResumeLayout(false);
            this.panelDetails.PerformLayout();
            this.panelActions.ResumeLayout(false);
            this.panelActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}