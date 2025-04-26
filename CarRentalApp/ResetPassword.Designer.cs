namespace CarRentalApp
{
    partial class ResetPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPW = new System.Windows.Forms.TextBox();
            this.tbConfirmPW = new System.Windows.Forms.TextBox();
            this.buttonPWReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Confirm Password";
            // 
            // tbPW
            // 
            this.tbPW.Location = new System.Drawing.Point(45, 66);
            this.tbPW.Name = "tbPW";
            this.tbPW.PasswordChar = '+';
            this.tbPW.Size = new System.Drawing.Size(179, 20);
            this.tbPW.TabIndex = 2;
            // 
            // tbConfirmPW
            // 
            this.tbConfirmPW.Location = new System.Drawing.Point(45, 184);
            this.tbConfirmPW.Name = "tbConfirmPW";
            this.tbConfirmPW.PasswordChar = '+';
            this.tbConfirmPW.Size = new System.Drawing.Size(179, 20);
            this.tbConfirmPW.TabIndex = 3;
            // 
            // buttonPWReset
            // 
            this.buttonPWReset.Location = new System.Drawing.Point(92, 210);
            this.buttonPWReset.Name = "buttonPWReset";
            this.buttonPWReset.Size = new System.Drawing.Size(75, 23);
            this.buttonPWReset.TabIndex = 4;
            this.buttonPWReset.Text = "Reset Password";
            this.buttonPWReset.UseVisualStyleBackColor = true;
            this.buttonPWReset.Click += new System.EventHandler(this.buttonPWReset_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 367);
            this.Controls.Add(this.buttonPWReset);
            this.Controls.Add(this.tbConfirmPW);
            this.Controls.Add(this.tbPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ResetPassword";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPW;
        private System.Windows.Forms.TextBox tbConfirmPW;
        private System.Windows.Forms.Button buttonPWReset;
    }
}