namespace ProjectIU
{
    partial class Corporate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Corporate));
            btnAdd = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            lblPohneNumber = new Label();
            txtName = new TextBox();
            lblName = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.LightSteelBlue;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btnAdd.Location = new Point(67, 359);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 86);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "KAYDET";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 20F);
            txtAddress.Location = new Point(319, 96);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(423, 215);
            txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAddress.Location = new Point(319, 56);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(91, 37);
            lblAddress.TabIndex = 15;
            lblAddress.Text = "Adres";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 20F);
            txtPhoneNumber.Location = new Point(67, 199);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 43);
            txtPhoneNumber.TabIndex = 14;
            // 
            // lblPohneNumber
            // 
            lblPohneNumber.AutoSize = true;
            lblPohneNumber.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPohneNumber.Location = new Point(67, 159);
            lblPohneNumber.Name = "lblPohneNumber";
            lblPohneNumber.Size = new Size(112, 37);
            lblPohneNumber.TabIndex = 13;
            lblPohneNumber.Text = "Telefon";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 20F);
            txtName.Location = new Point(67, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 43);
            txtName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblName.Location = new Point(67, 65);
            lblName.Name = "lblName";
            lblName.Size = new Size(164, 37);
            lblName.TabIndex = 9;
            lblName.Text = "Kurum İsmi";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(lblAddress);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblPohneNumber);
            panel1.Controls.Add(txtPhoneNumber);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 600);
            panel1.TabIndex = 18;
            // 
            // Corporate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Corporate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kurumsal Müşteri";
            Load += Corporate_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhoneNumber;
        private Label lblPohneNumber;
        private TextBox txtName;
        private Label lblName;
        private Panel panel1;
    }
}