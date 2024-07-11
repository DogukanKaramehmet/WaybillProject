namespace ProjectIU
{
    partial class Individual
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
            lblName = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            lblSurname = new Label();
            txtPhoneNumber = new TextBox();
            lblPohneNumber = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F);
            lblName.Location = new Point(59, 83);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Adı";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(59, 123);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 43);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 20F);
            txtSurname.Location = new Point(59, 209);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(200, 43);
            txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 20F);
            lblSurname.Location = new Point(59, 169);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(97, 37);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Soyadı";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.Location = new Point(59, 295);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 43);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPohneNumber
            // 
            lblPohneNumber.AutoSize = true;
            lblPohneNumber.Font = new Font("Segoe UI", 20F);
            lblPohneNumber.Location = new Point(59, 255);
            lblPohneNumber.Name = "lblPohneNumber";
            lblPohneNumber.Size = new Size(102, 37);
            lblPohneNumber.TabIndex = 4;
            lblPohneNumber.Text = "Telefon";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 20F);
            txtAddress.Location = new Point(311, 123);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(423, 215);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 20F);
            lblAddress.Location = new Point(311, 83);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(84, 37);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Adres";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 20F);
            btnAdd.Location = new Point(59, 384);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 86);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "KAYDET";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // IndividualCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(lblPohneNumber);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "IndividualCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bireysel Müşteri";
            Load += IndividualCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label lblSurname;
        private TextBox txtPhoneNumber;
        private Label lblPohneNumber;
        private TextBox txtAddress;
        private Label lblAddress;
        private Button btnAdd;
    }
}