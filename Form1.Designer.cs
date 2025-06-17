namespace MobileStoreApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form1 controls
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPrice; // new textbox for price
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPrice; // new label for price
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
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
        /// Required method for Designer support; do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.gbBluetooth.SuspendLayout();
            this.gbFMRadio.SuspendLayout();
            this.gbCamera.SuspendLayout();
            this.gbWiFi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(7, 350);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.RowTemplate.Height = 28;
            this.dgvCustomers.Size = new System.Drawing.Size(1232, 373);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentDoubleClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(87, 65);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 26);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(87, 110);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 26);
            this.txtPrice.TabIndex = 3;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(244, 308);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(91, 27);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "addCust";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(220, 273);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(476, 308);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(96, 31);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "upCus";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(3, 65);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(3, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 20);
            this.lblPrice.TabIndex = 11;
            this.lblPrice.Text = "Price :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(3, 311);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(154, 20);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "ID : Auto-Generated";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(87, 276);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 26);
            this.txtSearch.TabIndex = 14;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(5, 276);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(68, 20);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Search :";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(220, 22);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(108, 20);
            this.lblManufacturer.TabIndex = 16;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // comboManufacturer
            // 
            this.comboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboManufacturer.FormattingEnabled = true;
            this.comboManufacturer.Location = new System.Drawing.Point(340, 19);
            this.comboManufacturer.Name = "comboManufacturer";
            this.comboManufacturer.Size = new System.Drawing.Size(121, 28);
            this.comboManufacturer.TabIndex = 17;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(220, 65);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 20);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "Model:";
            // 
            // comboModel
            // 
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(340, 62);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(121, 28);
            this.comboModel.TabIndex = 19;
            // 
            // radioBluetoothYes
            // 
            this.radioBluetoothYes.AutoSize = true;
            this.radioBluetoothYes.Location = new System.Drawing.Point(10, 20);
            this.radioBluetoothYes.Name = "radioBluetoothYes";
            this.radioBluetoothYes.Size = new System.Drawing.Size(67, 24);
            this.radioBluetoothYes.TabIndex = 21;
            this.radioBluetoothYes.TabStop = true;
            this.radioBluetoothYes.Text = "YES";
            this.radioBluetoothYes.UseVisualStyleBackColor = true;
            // 
            // radioBluetoothNo
            // 
            this.radioBluetoothNo.AutoSize = true;
            this.radioBluetoothNo.Location = new System.Drawing.Point(80, 20);
            this.radioBluetoothNo.Name = "radioBluetoothNo";
            this.radioBluetoothNo.Size = new System.Drawing.Size(57, 24);
            this.radioBluetoothNo.TabIndex = 22;
            this.radioBluetoothNo.TabStop = true;
            this.radioBluetoothNo.Text = "NO";
            this.radioBluetoothNo.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioYes
            // 
            this.radioFMRadioYes.AutoSize = true;
            this.radioFMRadioYes.Location = new System.Drawing.Point(10, 20);
            this.radioFMRadioYes.Name = "radioFMRadioYes";
            this.radioFMRadioYes.Size = new System.Drawing.Size(67, 24);
            this.radioFMRadioYes.TabIndex = 24;
            this.radioFMRadioYes.TabStop = true;
            this.radioFMRadioYes.Text = "YES";
            this.radioFMRadioYes.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioNo
            // 
            this.radioFMRadioNo.AutoSize = true;
            this.radioFMRadioNo.Location = new System.Drawing.Point(80, 20);
            this.radioFMRadioNo.Name = "radioFMRadioNo";
            this.radioFMRadioNo.Size = new System.Drawing.Size(57, 24);
            this.radioFMRadioNo.TabIndex = 25;
            this.radioFMRadioNo.TabStop = true;
            this.radioFMRadioNo.Text = "NO";
            this.radioFMRadioNo.UseVisualStyleBackColor = true;
            // 
            // radioCameraYes
            // 
            this.radioCameraYes.AutoSize = true;
            this.radioCameraYes.Location = new System.Drawing.Point(10, 20);
            this.radioCameraYes.Name = "radioCameraYes";
            this.radioCameraYes.Size = new System.Drawing.Size(67, 24);
            this.radioCameraYes.TabIndex = 27;
            this.radioCameraYes.TabStop = true;
            this.radioCameraYes.Text = "YES";
            this.radioCameraYes.UseVisualStyleBackColor = true;
            // 
            // radioCameraNo
            // 
            this.radioCameraNo.AutoSize = true;
            this.radioCameraNo.Location = new System.Drawing.Point(80, 20);
            this.radioCameraNo.Name = "radioCameraNo";
            this.radioCameraNo.Size = new System.Drawing.Size(57, 24);
            this.radioCameraNo.TabIndex = 28;
            this.radioCameraNo.TabStop = true;
            this.radioCameraNo.Text = "NO";
            this.radioCameraNo.UseVisualStyleBackColor = true;
            // 
            // radioWifiYes
            // 
            this.radioWifiYes.AutoSize = true;
            this.radioWifiYes.Location = new System.Drawing.Point(10, 20);
            this.radioWifiYes.Name = "radioWifiYes";
            this.radioWifiYes.Size = new System.Drawing.Size(67, 24);
            this.radioWifiYes.TabIndex = 30;
            this.radioWifiYes.TabStop = true;
            this.radioWifiYes.Text = "YES";
            this.radioWifiYes.UseVisualStyleBackColor = true;
            // 
            // radioWifiNo
            // 
            this.radioWifiNo.AutoSize = true;
            this.radioWifiNo.Location = new System.Drawing.Point(80, 20);
            this.radioWifiNo.Name = "radioWifiNo";
            this.radioWifiNo.Size = new System.Drawing.Size(57, 24);
            this.radioWifiNo.TabIndex = 31;
            this.radioWifiNo.TabStop = true;
            this.radioWifiNo.Text = "NO";
            this.radioWifiNo.UseVisualStyleBackColor = true;
            // 
            // gbBluetooth
            // 
            this.gbBluetooth.Controls.Add(this.radioBluetoothYes);
            this.gbBluetooth.Controls.Add(this.radioBluetoothNo);
            this.gbBluetooth.Location = new System.Drawing.Point(482, 65);
            this.gbBluetooth.Name = "gbBluetooth";
            this.gbBluetooth.Size = new System.Drawing.Size(150, 50);
            this.gbBluetooth.TabIndex = 33;
            this.gbBluetooth.TabStop = false;
            this.gbBluetooth.Text = "Bluetooth";
            // 
            // gbFMRadio
            // 
            this.gbFMRadio.Controls.Add(this.radioFMRadioYes);
            this.gbFMRadio.Controls.Add(this.radioFMRadioNo);
            this.gbFMRadio.Location = new System.Drawing.Point(482, 12);
            this.gbFMRadio.Name = "gbFMRadio";
            this.gbFMRadio.Size = new System.Drawing.Size(150, 50);
            this.gbFMRadio.TabIndex = 34;
            this.gbFMRadio.TabStop = false;
            this.gbFMRadio.Text = "FM Radio";
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.radioCameraYes);
            this.gbCamera.Controls.Add(this.radioCameraNo);
            this.gbCamera.Location = new System.Drawing.Point(482, 121);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(150, 50);
            this.gbCamera.TabIndex = 35;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Camera";
            // 
            // gbWiFi
            // 
            this.gbWiFi.Controls.Add(this.radioWifiYes);
            this.gbWiFi.Controls.Add(this.radioWifiNo);
            this.gbWiFi.Location = new System.Drawing.Point(482, 177);
            this.gbWiFi.Name = "gbWiFi";
            this.gbWiFi.Size = new System.Drawing.Size(150, 50);
            this.gbWiFi.TabIndex = 36;
            this.gbWiFi.TabStop = false;
            this.gbWiFi.Text = "WiFi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 735);
            this.Controls.Add(this.gbBluetooth);
            this.Controls.Add(this.gbFMRadio);
            this.Controls.Add(this.gbCamera);
            this.Controls.Add(this.gbWiFi);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.comboManufacturer);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnUpdateCustomer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "Form1";
            this.Text = "MobileStore";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.gbBluetooth.ResumeLayout(false);
            this.gbBluetooth.PerformLayout();
            this.gbFMRadio.ResumeLayout(false);
            this.gbFMRadio.PerformLayout();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            this.gbWiFi.ResumeLayout(false);
            this.gbWiFi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}