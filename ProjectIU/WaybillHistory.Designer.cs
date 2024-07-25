namespace ProjectIU
{
    partial class WaybillHistory
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
            dgwWaybillHistory = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnYazdir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwWaybillHistory).BeginInit();
            SuspendLayout();
            // 
            // dgwWaybillHistory
            // 
            dgwWaybillHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwWaybillHistory.Location = new Point(12, 162);
            dgwWaybillHistory.Name = "dgwWaybillHistory";
            dgwWaybillHistory.Size = new Size(1240, 463);
            dgwWaybillHistory.TabIndex = 2;
            dgwWaybillHistory.CellClick += dgwWaybillHistory_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(72, 122);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 34);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSearch.Location = new Point(72, 77);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 28);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Ara";
            // 
            // btnYazdir
            // 
            btnYazdir.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnYazdir.Location = new Point(357, 106);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(150, 50);
            btnYazdir.TabIndex = 5;
            btnYazdir.Text = "YAZDIR";
            btnYazdir.UseVisualStyleBackColor = true;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // WaybillHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(btnYazdir);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgwWaybillHistory);
            Name = "WaybillHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İrsaliye Geçmişi";
            Load += WaybillHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgwWaybillHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgwWaybillHistory;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnYazdir;
    }
}