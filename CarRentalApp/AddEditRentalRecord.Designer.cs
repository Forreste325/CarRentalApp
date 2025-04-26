namespace CarRentalApp
{
    partial class AddEditRentalRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rentalPickupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.returnDateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPickupLabel = new System.Windows.Forms.Label();
            this.rentalReturnLabel = new System.Windows.Forms.Label();
            this.vehicleTypeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.carSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelRecordId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(282, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Car Rental System";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(38, 105);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(233, 20);
            this.customerNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // rentalPickupDatePicker
            // 
            this.rentalPickupDatePicker.Location = new System.Drawing.Point(41, 177);
            this.rentalPickupDatePicker.Name = "rentalPickupDatePicker";
            this.rentalPickupDatePicker.Size = new System.Drawing.Size(224, 20);
            this.rentalPickupDatePicker.TabIndex = 3;
            // 
            // returnDateDatePicker
            // 
            this.returnDateDatePicker.Location = new System.Drawing.Point(482, 177);
            this.returnDateDatePicker.Name = "returnDateDatePicker";
            this.returnDateDatePicker.Size = new System.Drawing.Size(224, 20);
            this.returnDateDatePicker.TabIndex = 4;
            // 
            // rentalPickupLabel
            // 
            this.rentalPickupLabel.AutoSize = true;
            this.rentalPickupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalPickupLabel.Location = new System.Drawing.Point(38, 150);
            this.rentalPickupLabel.Name = "rentalPickupLabel";
            this.rentalPickupLabel.Size = new System.Drawing.Size(125, 24);
            this.rentalPickupLabel.TabIndex = 5;
            this.rentalPickupLabel.Text = "Rental Pickup";
            // 
            // rentalReturnLabel
            // 
            this.rentalReturnLabel.AutoSize = true;
            this.rentalReturnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturnLabel.Location = new System.Drawing.Point(479, 150);
            this.rentalReturnLabel.Name = "rentalReturnLabel";
            this.rentalReturnLabel.Size = new System.Drawing.Size(124, 24);
            this.rentalReturnLabel.TabIndex = 6;
            this.rentalReturnLabel.Text = "Rental Return";
            // 
            // vehicleTypeLabel
            // 
            this.vehicleTypeLabel.AutoSize = true;
            this.vehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleTypeLabel.Location = new System.Drawing.Point(38, 283);
            this.vehicleTypeLabel.Name = "vehicleTypeLabel";
            this.vehicleTypeLabel.Size = new System.Drawing.Size(107, 24);
            this.vehicleTypeLabel.TabIndex = 8;
            this.vehicleTypeLabel.Text = "Type of Car";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(519, 283);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(151, 74);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // carSelectionComboBox
            // 
            this.carSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carSelectionComboBox.FormattingEnabled = true;
            this.carSelectionComboBox.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Lada",
            "Buggy"});
            this.carSelectionComboBox.Location = new System.Drawing.Point(42, 311);
            this.carSelectionComboBox.Name = "carSelectionComboBox";
            this.carSelectionComboBox.Size = new System.Drawing.Size(229, 21);
            this.carSelectionComboBox.TabIndex = 10;
            this.carSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.carSelectionComboBox_SelectedIndexChanged);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(482, 105);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(224, 20);
            this.costTextBox.TabIndex = 11;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(479, 78);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(47, 24);
            this.costLabel.TabIndex = 12;
            this.costLabel.Text = "Cost";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Launch main Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelRecordId
            // 
            this.labelRecordId.AutoSize = true;
            this.labelRecordId.Location = new System.Drawing.Point(334, 403);
            this.labelRecordId.Name = "labelRecordId";
            this.labelRecordId.Size = new System.Drawing.Size(0, 13);
            this.labelRecordId.TabIndex = 14;
            this.labelRecordId.Visible = false;
            // 
            // AddEditRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRecordId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.carSelectionComboBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.vehicleTypeLabel);
            this.Controls.Add(this.rentalReturnLabel);
            this.Controls.Add(this.rentalPickupLabel);
            this.Controls.Add(this.returnDateDatePicker);
            this.Controls.Add(this.rentalPickupDatePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.lblTitle);
            this.Name = "AddEditRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker rentalPickupDatePicker;
        private System.Windows.Forms.DateTimePicker returnDateDatePicker;
        private System.Windows.Forms.Label rentalPickupLabel;
        private System.Windows.Forms.Label rentalReturnLabel;
        private System.Windows.Forms.Label vehicleTypeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox carSelectionComboBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelRecordId;
    }
}

