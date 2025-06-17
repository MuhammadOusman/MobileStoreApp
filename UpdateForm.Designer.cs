namespace MobileStoreApp
{
    partial class UpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // UpdateForm controls
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMain;
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbWiFi = new System.Windows.Forms.GroupBox();
            this.radioWiFiYes = new System.Windows.Forms.RadioButton();
            this.radioWiFiNo = new System.Windows.Forms.RadioButton();
            this.gbCamera = new System.Windows.Forms.GroupBox();
            this.radioCameraYes = new System.Windows.Forms.RadioButton();
            this.radioCameraNo = new System.Windows.Forms.RadioButton();
            this.gbFMRadio = new System.Windows.Forms.GroupBox();
            this.radioFMRadioYes = new System.Windows.Forms.RadioButton();
            this.radioFMRadioNo = new System.Windows.Forms.RadioButton();
            this.gbBluetooth = new System.Windows.Forms.GroupBox();
            this.radioBluetoothYes = new System.Windows.Forms.RadioButton();
            this.radioBluetoothNo = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboModel = new System.Windows.Forms.ComboBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.comboManufacturer = new System.Windows.Forms.ComboBox();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.gbWiFi.SuspendLayout();
            this.gbCamera.SuspendLayout();
            this.gbFMRadio.SuspendLayout();
            this.gbBluetooth.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(25, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(228, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Update Customer Info";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panelMain.Controls.Add(this.gbWiFi);
            this.panelMain.Controls.Add(this.gbCamera);
            this.panelMain.Controls.Add(this.gbFMRadio);
            this.panelMain.Controls.Add(this.gbBluetooth);
            this.panelMain.Controls.Add(this.btnUpdate);
            this.panelMain.Controls.Add(this.comboModel);
            this.panelMain.Controls.Add(this.lblModel);
            this.panelMain.Controls.Add(this.comboManufacturer);
            this.panelMain.Controls.Add(this.lblManufacturer);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.lblPhone);
            this.panelMain.Controls.Add(this.txtName);
            this.panelMain.Controls.Add(this.lblName);
            this.panelMain.Controls.Add(this.txtCustomerID);
            this.panelMain.Controls.Add(this.lblCustomerID);
            this.panelMain.Location = new System.Drawing.Point(30, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(340, 460);
            this.panelMain.TabIndex = 1;
            // 
            // gbWiFi
            // 
            this.gbWiFi.Controls.Add(this.radioWiFiYes);
            this.gbWiFi.Controls.Add(this.radioWiFiNo);
            this.gbWiFi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbWiFi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbWiFi.Location = new System.Drawing.Point(180, 320);
            this.gbWiFi.Name = "gbWiFi";
            this.gbWiFi.Size = new System.Drawing.Size(130, 60);
            this.gbWiFi.TabIndex = 13;
            this.gbWiFi.TabStop = false;
            this.gbWiFi.Text = "WiFi";
            // 
            // radioWiFiYes
            // 
            this.radioWiFiYes.AutoSize = true;
            this.radioWiFiYes.Location = new System.Drawing.Point(15, 25);
            this.radioWiFiYes.Name = "radioWiFiYes";
            this.radioWiFiYes.Size = new System.Drawing.Size(46, 21);
            this.radioWiFiYes.TabIndex = 0;
            this.radioWiFiYes.TabStop = true;
            this.radioWiFiYes.Text = "Yes";
            this.radioWiFiYes.UseVisualStyleBackColor = true;
            // 
            // radioWiFiNo
            // 
            this.radioWiFiNo.AutoSize = true;
            this.radioWiFiNo.Location = new System.Drawing.Point(75, 25);
            this.radioWiFiNo.Name = "radioWiFiNo";
            this.radioWiFiNo.Size = new System.Drawing.Size(42, 21);
            this.radioWiFiNo.TabIndex = 1;
            this.radioWiFiNo.TabStop = true;
            this.radioWiFiNo.Text = "No";
            this.radioWiFiNo.UseVisualStyleBackColor = true;
            // 
            // gbCamera
            // 
            this.gbCamera.Controls.Add(this.radioCameraYes);
            this.gbCamera.Controls.Add(this.radioCameraNo);
            this.gbCamera.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCamera.Location = new System.Drawing.Point(30, 320);
            this.gbCamera.Name = "gbCamera";
            this.gbCamera.Size = new System.Drawing.Size(130, 60);
            this.gbCamera.TabIndex = 12;
            this.gbCamera.TabStop = false;
            this.gbCamera.Text = "Camera";
            // 
            // radioCameraYes
            // 
            this.radioCameraYes.AutoSize = true;
            this.radioCameraYes.Location = new System.Drawing.Point(15, 25);
            this.radioCameraYes.Name = "radioCameraYes";
            this.radioCameraYes.Size = new System.Drawing.Size(46, 21);
            this.radioCameraYes.TabIndex = 0;
            this.radioCameraYes.TabStop = true;
            this.radioCameraYes.Text = "Yes";
            this.radioCameraYes.UseVisualStyleBackColor = true;
            // 
            // radioCameraNo
            // 
            this.radioCameraNo.AutoSize = true;
            this.radioCameraNo.Location = new System.Drawing.Point(75, 25);
            this.radioCameraNo.Name = "radioCameraNo";
            this.radioCameraNo.Size = new System.Drawing.Size(42, 21);
            this.radioCameraNo.TabIndex = 1;
            this.radioCameraNo.TabStop = true;
            this.radioCameraNo.Text = "No";
            this.radioCameraNo.UseVisualStyleBackColor = true;
            // 
            // gbFMRadio
            // 
            this.gbFMRadio.Controls.Add(this.radioFMRadioYes);
            this.gbFMRadio.Controls.Add(this.radioFMRadioNo);
            this.gbFMRadio.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbFMRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbFMRadio.Location = new System.Drawing.Point(180, 250);
            this.gbFMRadio.Name = "gbFMRadio";
            this.gbFMRadio.Size = new System.Drawing.Size(130, 60);
            this.gbFMRadio.TabIndex = 11;
            this.gbFMRadio.TabStop = false;
            this.gbFMRadio.Text = "FM Radio";
            // 
            // radioFMRadioYes
            // 
            this.radioFMRadioYes.AutoSize = true;
            this.radioFMRadioYes.Location = new System.Drawing.Point(15, 25);
            this.radioFMRadioYes.Name = "radioFMRadioYes";
            this.radioFMRadioYes.Size = new System.Drawing.Size(46, 21);
            this.radioFMRadioYes.TabIndex = 0;
            this.radioFMRadioYes.TabStop = true;
            this.radioFMRadioYes.Text = "Yes";
            this.radioFMRadioYes.UseVisualStyleBackColor = true;
            // 
            // radioFMRadioNo
            // 
            this.radioFMRadioNo.AutoSize = true;
            this.radioFMRadioNo.Location = new System.Drawing.Point(75, 25);
            this.radioFMRadioNo.Name = "radioFMRadioNo";
            this.radioFMRadioNo.Size = new System.Drawing.Size(42, 21);
            this.radioFMRadioNo.TabIndex = 1;
            this.radioFMRadioNo.TabStop = true;
            this.radioFMRadioNo.Text = "No";
            this.radioFMRadioNo.UseVisualStyleBackColor = true;
            // 
            // gbBluetooth
            // 
            this.gbBluetooth.Controls.Add(this.radioBluetoothYes);
            this.gbBluetooth.Controls.Add(this.radioBluetoothNo);
            this.gbBluetooth.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbBluetooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbBluetooth.Location = new System.Drawing.Point(30, 250);
            this.gbBluetooth.Name = "gbBluetooth";
            this.gbBluetooth.Size = new System.Drawing.Size(130, 60);
            this.gbBluetooth.TabIndex = 10;
            this.gbBluetooth.TabStop = false;
            this.gbBluetooth.Text = "Bluetooth";
            // 
            // radioBluetoothYes
            // 
            this.radioBluetoothYes.AutoSize = true;
            this.radioBluetoothYes.Location = new System.Drawing.Point(15, 25);
            this.radioBluetoothYes.Name = "radioBluetoothYes";
            this.radioBluetoothYes.Size = new System.Drawing.Size(46, 21);
            this.radioBluetoothYes.TabIndex = 0;
            this.radioBluetoothYes.TabStop = true;
            this.radioBluetoothYes.Text = "Yes";
            this.radioBluetoothYes.UseVisualStyleBackColor = true;
            // 
            // radioBluetoothNo
            // 
            this.radioBluetoothNo.AutoSize = true;
            this.radioBluetoothNo.Location = new System.Drawing.Point(75, 25);
            this.radioBluetoothNo.Name = "radioBluetoothNo";
            this.radioBluetoothNo.Size = new System.Drawing.Size(42, 21);
            this.radioBluetoothNo.TabIndex = 1;
            this.radioBluetoothNo.TabStop = true;
            this.radioBluetoothNo.Text = "No";
            this.radioBluetoothNo.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(110, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 35);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // comboModel
            // 
            this.comboModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.comboModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboModel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboModel.ForeColor = System.Drawing.Color.White;
            this.comboModel.FormattingEnabled = true;
            this.comboModel.Location = new System.Drawing.Point(30, 205);
            this.comboModel.Name = "comboModel";
            this.comboModel.Size = new System.Drawing.Size(280, 23);
            this.comboModel.TabIndex = 9;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblModel.Location = new System.Drawing.Point(27, 185);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(49, 17);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model:";
            // 
            // comboManufacturer
            // 
            this.comboManufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.comboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboManufacturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboManufacturer.ForeColor = System.Drawing.Color.White;
            this.comboManufacturer.FormattingEnabled = true;
            this.comboManufacturer.Location = new System.Drawing.Point(30, 155);
            this.comboManufacturer.Name = "comboManufacturer";
            this.comboManufacturer.Size = new System.Drawing.Size(280, 23);
            this.comboManufacturer.TabIndex = 7;
            this.comboManufacturer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxManufacturer_SelectedIndexChanged);
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblManufacturer.Location = new System.Drawing.Point(27, 135);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(92, 17);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(130, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 25);
            this.txtPhone.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPhone.Location = new System.Drawing.Point(27, 98);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 17);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(130, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 25);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblName.Location = new System.Drawing.Point(27, 63);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCustomerID.Location = new System.Drawing.Point(130, 25);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(180, 25);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblCustomerID.Location = new System.Drawing.Point(27, 28);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(89, 17);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Form";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.gbWiFi.ResumeLayout(false);
            this.gbWiFi.PerformLayout();
            this.gbCamera.ResumeLayout(false);
            this.gbCamera.PerformLayout();
            this.gbFMRadio.ResumeLayout(false);
            this.gbFMRadio.PerformLayout();
            this.gbBluetooth.ResumeLayout(false);
            this.gbBluetooth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}