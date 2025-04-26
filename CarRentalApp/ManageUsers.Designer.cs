namespace CarRentalApp
{
    partial class ManageUsers
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
            this.buttonDeactivateUser = new System.Windows.Forms.Button();
            this.buttonResetPW = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.manageVehicleListingLabel = new System.Windows.Forms.Label();
            this.gvUserList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeactivateUser
            // 
            this.buttonDeactivateUser.Location = new System.Drawing.Point(558, 382);
            this.buttonDeactivateUser.Name = "buttonDeactivateUser";
            this.buttonDeactivateUser.Size = new System.Drawing.Size(205, 57);
            this.buttonDeactivateUser.TabIndex = 21;
            this.buttonDeactivateUser.Text = "Deactivate/Activate User";
            this.buttonDeactivateUser.UseVisualStyleBackColor = true;
            this.buttonDeactivateUser.Click += new System.EventHandler(this.buttonDeactivateUser_Click);
            // 
            // buttonResetPW
            // 
            this.buttonResetPW.Location = new System.Drawing.Point(278, 378);
            this.buttonResetPW.Name = "buttonResetPW";
            this.buttonResetPW.Size = new System.Drawing.Size(159, 59);
            this.buttonResetPW.TabIndex = 20;
            this.buttonResetPW.Text = "Reset Password";
            this.buttonResetPW.UseVisualStyleBackColor = true;
            this.buttonResetPW.Click += new System.EventHandler(this.buttonResetPW_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(12, 381);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(159, 56);
            this.buttonNewUser.TabIndex = 19;
            this.buttonNewUser.Text = "Add New User";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // manageVehicleListingLabel
            // 
            this.manageVehicleListingLabel.AutoSize = true;
            this.manageVehicleListingLabel.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVehicleListingLabel.Location = new System.Drawing.Point(236, 9);
            this.manageVehicleListingLabel.Name = "manageVehicleListingLabel";
            this.manageVehicleListingLabel.Size = new System.Drawing.Size(387, 65);
            this.manageVehicleListingLabel.TabIndex = 18;
            this.manageVehicleListingLabel.Text = "Manage Users";
            // 
            // gvUserList
            // 
            this.gvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUserList.Location = new System.Drawing.Point(12, 139);
            this.gvUserList.Name = "gvUserList";
            this.gvUserList.Size = new System.Drawing.Size(776, 213);
            this.gvUserList.TabIndex = 17;
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 568);
            this.Controls.Add(this.buttonDeactivateUser);
            this.Controls.Add(this.buttonResetPW);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.manageVehicleListingLabel);
            this.Controls.Add(this.gvUserList);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDeactivateUser;
        private System.Windows.Forms.Button buttonResetPW;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Label manageVehicleListingLabel;
        private System.Windows.Forms.DataGridView gvUserList;
    }
}