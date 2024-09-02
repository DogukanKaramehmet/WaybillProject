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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Individual));
            lblName = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            lblSurname = new Label();
            txtPhoneNumber = new TextBox();
            lblPohneNumber = new Label();
            txtAddress = new TextBox();
            lblAddress = new Label();
            btnAdd = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblName.Location = new Point(73, 59);
            lblName.Name = "lblName";
            lblName.Size = new Size(61, 37);
            lblName.TabIndex = 0;
            lblName.Text = "Adı";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(73, 99);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 43);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Font = new Font("Segoe UI", 20F);
            txtSurname.Location = new Point(73, 185);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(200, 43);
            txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSurname.Location = new Point(73, 145);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(104, 37);
            lblSurname.TabIndex = 2;
            lblSurname.Text = "Soyadı";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.Location = new Point(73, 271);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 43);
            txtPhoneNumber.TabIndex = 5;
            // 
            // lblPohneNumber
            // 
            lblPohneNumber.AutoSize = true;
            lblPohneNumber.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPohneNumber.Location = new Point(73, 231);
            lblPohneNumber.Name = "lblPohneNumber";
            lblPohneNumber.Size = new Size(112, 37);
            lblPohneNumber.TabIndex = 4;
            lblPohneNumber.Text = "Telefon";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 20F);
            txtAddress.Location = new Point(325, 99);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(423, 215);
            txtAddress.TabIndex = 7;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAddress.Location = new Point(325, 59);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(91, 37);
            lblAddress.TabIndex = 6;
            lblAddress.Text = "Adres";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAdd.Location = new Point(73, 360);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 86);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "KAYDET";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblSurname);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Controls.Add(txtSurname);
            panel1.Controls.Add(lblPohneNumber);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 600);
            panel1.TabIndex = 9;
            // 
            // Individual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Individual";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bireysel Müşteri";
            Load += IndividualCustomer_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
    }
}