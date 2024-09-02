namespace ProjectIU
{
    partial class AllCorporate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCorporate));
            dgwCorporate = new DataGridView();
            txtSearch = new TextBox();
            lblSerach = new Label();
            btnDelete = new Button();
            btnIndividual = new Button();
            btnCorporate = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgwCorporate).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwCorporate
            // 
            dgwCorporate.BackgroundColor = Color.PaleTurquoise;
            dgwCorporate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCorporate.Location = new Point(-1, 102);
            dgwCorporate.Name = "dgwCorporate";
            dgwCorporate.Size = new Size(785, 460);
            dgwCorporate.TabIndex = 0;
            dgwCorporate.CellClick += dgwCorporate_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(83, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 43);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSerach
            // 
            lblSerach.AutoSize = true;
            lblSerach.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSerach.Location = new Point(13, 28);
            lblSerach.Name = "lblSerach";
            lblSerach.Size = new Size(69, 37);
            lblSerach.TabIndex = 2;
            lblSerach.Text = "Ara ";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightSteelBlue;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDelete.Location = new Point(653, 21);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnIndividual
            // 
            btnIndividual.BackColor = Color.LightSteelBlue;
            btnIndividual.FlatStyle = FlatStyle.Popup;
            btnIndividual.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnIndividual.Location = new Point(326, 21);
            btnIndividual.Name = "btnIndividual";
            btnIndividual.Size = new Size(120, 50);
            btnIndividual.TabIndex = 4;
            btnIndividual.Text = "Bireysel";
            btnIndividual.UseVisualStyleBackColor = false;
            btnIndividual.Click += btnIndividual_Click;
            // 
            // btnCorporate
            // 
            btnCorporate.BackColor = Color.LightSteelBlue;
            btnCorporate.FlatStyle = FlatStyle.Popup;
            btnCorporate.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCorporate.Location = new Point(452, 21);
            btnCorporate.Name = "btnCorporate";
            btnCorporate.Size = new Size(120, 50);
            btnCorporate.TabIndex = 5;
            btnCorporate.Text = "Kurumsal";
            btnCorporate.UseVisualStyleBackColor = false;
            btnCorporate.Click += btnCorporate_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(btnIndividual);
            panel1.Controls.Add(btnCorporate);
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lblSerach);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 103);
            panel1.TabIndex = 6;
            // 
            // AllCorporate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(dgwCorporate);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AllCorporate";
            Text = "Tüm Müşteriler";
            Load += AllCorporate_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCorporate).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwCorporate;
        private TextBox txtSearch;
        private Label lblSerach;
        private Button btnDelete;
        private Button btnIndividual;
        private Button btnCorporate;
        private Panel panel1;
    }
}