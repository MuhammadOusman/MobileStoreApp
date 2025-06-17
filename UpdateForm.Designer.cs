namespace MobileStoreApp
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Existing UpdateForm controls
        private System.Windows.Forms.GroupBox gbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.ComboBox comboManufacturer;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.ComboBox comboModel;
        private System.Windows.Forms.Button btnUpdate;

        // New controls for features
        private System.Windows.Forms.GroupBox gbBluetooth;
        private System.Windows.Forms.RadioButton radioBluetoothYes;
        private System.Windows.Forms.RadioButton radioBluetoothNo;

        private System.Windows.Forms.GroupBox gbFMRadio;
        private System.Windows.Forms.RadioButton radioFMRadioYes;
        private System.Windows.Forms.RadioButton radioFMRadioNo;

        private System.Windows.Forms.GroupBox gbCamera;
        private System.Windows.Forms.RadioButton radioCameraYes;
        private System.Windows.Forms.RadioButton radioCameraNo;

        private System.Windows.Forms.GroupBox gbWiFi;
        private System.Windows.Forms.RadioButton radioWiFiYes;
        private System.Windows.Forms.RadioButton radioWiFiNo;

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
            // Initialize new controls for CustomerID
            this.gbCustomerID = new System.Windows.Forms.GroupBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();

            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.comboManufacturer = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();

            // GroupBox for Bluetooth
            this.gbBluetooth = new System.Windows.Forms.GroupBox();
            this.radioBluetoothYes = new System.Windows.Forms.RadioButton();
            this.radioBluetoothNo = new System.Windows.Forms.RadioButton();
            // GroupBox for FMRadio
            this.gbFMRadio = new System.Windows.Forms.GroupBox();
            this.radioFMRadioYes = new System.Windows.Forms.RadioButton();
            this.radioFMRadioNo = new System.Windows.Forms.RadioButton();
            // GroupBox for Camera
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.radioCameraYes = new System.Windows.Forms.RadioButton();
            this.radioCameraNo = new System.Windows.Forms.RadioButton();
            // GroupBox for WiFi
            this.gbWiFi = new System.Windows.Forms.GroupBox();
            this.radioWiFiYes = new System.Windows.Forms.RadioButton();
            this.radioWiFiNo = new System.Windows.Forms.RadioButton();

            this.SuspendLayout();
            // 
            // gbCustomerID
            // 
            this.gbCustomerID.Controls.Add(this.lblCustomerID);
            this.gbCustomerID.Controls.Add(this.txtCustomerID);
            this.gbCustomerID.Location = new System.Drawing.Point(12, 0);
            this.gbCustomerID.Name = "gbCustomerID";
            this.gbCustomerID.Size = new System.Drawing.Size(260, 50);
            this.gbCustomerID.TabIndex = 0;
            this.gbCustomerID.TabStop = false;
            this.gbCustomerID.Text = "Customer ID";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(10, 22);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(34, 20);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "ID :";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(50, 19);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(200, 26);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 65);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 26);
            this.txtName.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 105);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 20);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone :";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(122, 102);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(12, 145);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(88, 20);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Manufacturer";
            // 
            // comboManufacturer
            // 
            this.comboManufacturer.FormattingEnabled = true;
            this.comboManufacturer.Location = new System.Drawing.Point(122, 142);
            this.comboManufacturer.Name = "comboManufacturer";
            this.comboManufacturer.Size = new System.Drawing.Size(150, 28);
            this.comboManufacturer.TabIndex = 7;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 190);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model";
            // 
            // comboModel
            // 
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(122, 187);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(150, 28);
            this.comboModel.TabIndex = 9;
            // 
            // gbBluetooth
            // 
            this.gbBluetooth.Controls.Add(this.radioBluetoothYes);
            this.gbBluetooth.Controls.Add(this.radioBluetoothNo);
            this.gbBluetooth.Location = new System.Drawing.Point(15, 230);
            this.gbBluetooth.Name = "gbBluetooth";
            this.gbBluetooth.Size = new System.Drawing.Size(120, 60);
            this.gbBluetooth.TabIndex = 10;
            this.gbBluetooth.TabStop = false;
            this.gbBluetooth.Text = "Bluetooth";
            // 
            // radioBluetoothYes
            // 
            this.radioBluetoothYes.AutoSize = true;
            this.radioBluetoothYes.Location = new System.Drawing.Point(10, 25);
            this.radioBluetoothYes.Name = "radioBluetoothYes";
            this.radioBluetoothYes.Size = new System.Drawing.Size(55, 24);
            this.radioBluetoothYes.TabIndex = 0;
            this.radioBluetoothYes.TabStop = true;
            this.radioBluetoothYes.Text = "YES";
            this.radioBluetoothYes.UseVisualStyleBackColor = true;
            // 
            // radioBluetoothNo
            // 
            this.radioBluetoothNo.AutoSize = true;
            this.radioBluetoothNo.Location = new System.Drawing.Point(70, 25);
            this.radioBluetoothNo.Name = "radioBluetoothNo";
            this.radioBluetoothNo.Size = new System.Drawing.Size(54, 24);
            this.radioBluetoothNo.TabIndex = 1;
            this.radioBluetoothNo.TabStop = true;
            this.radioBluetoothNo.Text = "NO";
            this.radioBluetoothNo.UseVisualStyleBackColor = true;
            // 
            // gbFMRadio
            // 
            this.gbFMRadio.Controls.Add(this.radioFMRadioYes);
            this.gbFMRadio.Controls.Add(this.radioFMRadioNo);
            this.gbFMRadio.Location = new System.Drawing.Point(150, 230);
            this.gbFMRadio.Name = "gbFMRadio";
            this.gbFMRadio.Size = new System.Drawing.Size(120, 60);
            this.gbFMRadio.TabIndex = 11;
            this.gbFMRadio.TabStop = false;
            this.gbFMRadio.Text = "FM Radio";
            // 
            // radioFMRadioYes
            // 
            this.radioFMRadioYes.AutoSize = true;
            this.radioFMRadioYes.Location = new System.Drawing.Point(10, 25);
            this.radioFMRadioYes.Name = "radioFMRadioYes";
            this.radioFMRadioYes.Size = new System.Drawing.Size(55, 24);
            this.radioFMRadioYes.TabIndex = 0;
            this.radioFMRadioYes.TabStop = true;
            this.radioFMRadioYes.Text = "YES";
            this.radioFMRadioYes.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioNo
            // 
            this.radioFMRadioNo.AutoSize = true;
            this.radioFMRadioNo.Location = new System.Drawing.Point(70, 25);
            this.radioFMRadioNo.Name = "radioFMRadioNo";
            this.radioFMRadioNo.Size = new System.Drawing.Size(54, 24);
            this.radioFMRadioNo.TabIndex = 1;
            this.radioFMRadioNo.TabStop = true;
            this.radioFMRadioNo.Text = "NO";
            this.radioFMRadioNo.UseVisualStyleBackColor = true;
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.radioCameraYes);
            this.gbCamera.Controls.Add(this.radioCameraNo);
            this.gbCamera.Location = new System.Drawing.Point(15, 300);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(120, 60);
            this.gbCamera.TabIndex = 12;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Camera";
            // 
            // radioCameraYes
            // 
            this.radioCameraYes.AutoSize = true;
            this.radioCameraYes.Location = new System.Drawing.Point(10, 25);
            this.radioCameraYes.Name = "radioCameraYes";
            this.radioCameraYes.Size = new System.Drawing.Size(55, 24);
            this.radioCameraYes.TabIndex = 0;
            this.radioCameraYes.TabStop = true;
            this.radioCameraYes.Text = "YES";
            this.radioCameraYes.UseVisualStyleBackColor = true;
            // 
            // radioCameraNo
            // 
            this.radioCameraNo.AutoSize = true;
            this.radioCameraNo.Location = new System.Drawing.Point(70, 25);
            this.radioCameraNo.Name = "radioCameraNo";
            this.radioCameraNo.Size = new System.Drawing.Size(54, 24);
            this.radioCameraNo.TabIndex = 1;
            this.radioCameraNo.TabStop = true;
            this.radioCameraNo.Text = "NO";
            this.radioCameraNo.UseVisualStyleBackColor = true;
            // 
            // gbWiFi
            // 
            this.gbWiFi.Controls.Add(this.radioWiFiYes);
            this.gbWiFi.Controls.Add(this.radioWiFiNo);
            this.gbWiFi.Location = new System.Drawing.Point(150, 300);
            this.gbWiFi.Name = "gbWiFi";
            this.gbWiFi.Size = new System.Drawing.Size(120, 60);
            this.gbWiFi.TabIndex = 13;
            this.gbWiFi.TabStop = false;
            this.gbWiFi.Text = "WiFi";
            // 
            // radioWiFiYes
            // 
            this.radioWiFiYes.AutoSize = true;
            this.radioWiFiYes.Location = new System.Drawing.Point(10, 25);
            this.radioWiFiYes.Name = "radioWiFiYes";
            this.radioWiFiYes.Size = new System.Drawing.Size(55, 24);
            this.radioWiFiYes.TabIndex = 0;
            this.radioWiFiYes.TabStop = true;
            this.radioWiFiYes.Text = "YES";
            this.radioWiFiYes.UseVisualStyleBackColor = true;
            // 
            // radioWiFiNo
            // 
            this.radioWiFiNo.AutoSize = true;
            this.radioWiFiNo.Location = new System.Drawing.Point(70, 25);
            this.radioWiFiNo.Name = "radioWiFiNo";
            this.radioWiFiNo.Size = new System.Drawing.Size(54, 24);
            this.radioWiFiNo.TabIndex = 1;
            this.radioWiFiNo.TabStop = true;
            this.radioWiFiNo.Text = "NO";
            this.radioWiFiNo.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(122, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 32);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // UpdateForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 420);
            this.Controls.Add(this.gbWiFi);
            this.Controls.Add(this.gbCamera);
            this.Controls.Add(this.gbFMRadio);
            this.Controls.Add(this.gbBluetooth);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.comboModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.comboManufacturer);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gbCustomerID);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}