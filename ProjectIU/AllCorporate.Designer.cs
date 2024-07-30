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
            dgwCorporate = new DataGridView();
            txtSearch = new TextBox();
            lblSerach = new Label();
            btnDelete = new Button();
            btnIndividual = new Button();
            btnCorporate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCorporate).BeginInit();
            SuspendLayout();
            // 
            // dgwCorporate
            // 
            dgwCorporate.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCorporate.Location = new Point(12, 102);
            dgwCorporate.Name = "dgwCorporate";
            dgwCorporate.Size = new Size(760, 447);
            dgwCorporate.TabIndex = 0;
            dgwCorporate.CellClick += dgwCorporate_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 20F);
            txtSearch.Location = new Point(82, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(220, 43);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSerach
            // 
            lblSerach.AutoSize = true;
            lblSerach.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblSerach.Location = new Point(12, 33);
            lblSerach.Name = "lblSerach";
            lblSerach.Size = new Size(69, 37);
            lblSerach.TabIndex = 2;
            lblSerach.Text = "Ara ";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDelete.Location = new Point(652, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnIndividual
            // 
            btnIndividual.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnIndividual.Location = new Point(325, 26);
            btnIndividual.Name = "btnIndividual";
            btnIndividual.Size = new Size(120, 50);
            btnIndividual.TabIndex = 4;
            btnIndividual.Text = "Bireysel";
            btnIndividual.UseVisualStyleBackColor = true;
            btnIndividual.Click += btnIndividual_Click;
            // 
            // btnCorporate
            // 
            btnCorporate.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnCorporate.Location = new Point(451, 26);
            btnCorporate.Name = "btnCorporate";
            btnCorporate.Size = new Size(120, 50);
            btnCorporate.TabIndex = 5;
            btnCorporate.Text = "Kurumsal";
            btnCorporate.UseVisualStyleBackColor = true;
            btnCorporate.Click += btnCorporate_Click;
            // 
            // AllCorporate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnCorporate);
            Controls.Add(btnIndividual);
            Controls.Add(btnDelete);
            Controls.Add(lblSerach);
            Controls.Add(txtSearch);
            Controls.Add(dgwCorporate);
            Name = "AllCorporate";
            Text = "AllCorporate";
            Load += AllCorporate_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCorporate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwCorporate;
        private TextBox txtSearch;
        private Label lblSerach;
        private Button btnDelete;
        private Button btnIndividual;
        private Button btnCorporate;
    }
}