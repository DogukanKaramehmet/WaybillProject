namespace ProjectIU
{
    partial class CorporateCustomer
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
            btnAdd = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            lblPohneNumber = new Label();
            txtName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.Location = new Point(40, 354);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 86);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "KAYDET";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 20F);
            txtAddress.Location = new Point(292, 93);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(423, 215);
            txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 20F);
            lblAddress.Location = new Point(292, 53);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(84, 37);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Adres";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.Location = new Point(40, 187);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 43);
            txtPhoneNumber.TabIndex = 14;
            // 
            // lblPohneNumber
            // 
            lblPohneNumber.AutoSize = true;
            lblPohneNumber.Font = new Font("Segoe UI", 20F);
            lblPohneNumber.Location = new Point(40, 147);
            lblPohneNumber.Name = "lblPohneNumber";
            lblPohneNumber.Size = new Size(102, 37);
            lblPohneNumber.TabIndex = 13;
            lblPohneNumber.Text = "Telefon";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(40, 93);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 43);
            txtName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F);
            lblName.Location = new Point(40, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 37);
            lblName.TabIndex = 9;
            lblName.Text = "Kurum İsmi";
            // 
            // CorporateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPohneNumber);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "CorporateCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kurumsal Müşteri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhoneNumber;
        private Label lblPohneNumber;
        private TextBox txtName;
        private Label lblName;
    }
}