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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaybillHistory));
            dgwWaybillHistory = new DataGridView();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnYazdir = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgwWaybillHistory).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgwWaybillHistory
            // 
            dgwWaybillHistory.BackgroundColor = Color.PaleTurquoise;
            dgwWaybillHistory.BorderStyle = BorderStyle.None;
            dgwWaybillHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwWaybillHistory.Location = new Point(0, 162);
            dgwWaybillHistory.Name = "dgwWaybillHistory";
            dgwWaybillHistory.Size = new Size(1264, 519);
            dgwWaybillHistory.TabIndex = 2;
            dgwWaybillHistory.CellClick += dgwWaybillHistory_CellClick;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(91, 109);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(227, 34);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSearch.Location = new Point(91, 64);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 28);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Ara";
            // 
            // btnYazdir
            // 
            btnYazdir.BackColor = Color.LightSteelBlue;
            btnYazdir.FlatStyle = FlatStyle.Popup;
            btnYazdir.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnYazdir.Location = new Point(376, 93);
            btnYazdir.Name = "btnYazdir";
            btnYazdir.Size = new Size(150, 50);
            btnYazdir.TabIndex = 5;
            btnYazdir.Text = "YAZDIR";
            btnYazdir.UseVisualStyleBackColor = false;
            btnYazdir.Click += btnYazdir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(btnYazdir);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 163);
            panel1.TabIndex = 6;
            // 
            // WaybillHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Controls.Add(dgwWaybillHistory);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "WaybillHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İrsaliye Geçmişi";
            Load += WaybillHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dgwWaybillHistory).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgwWaybillHistory;
        private TextBox txtSearch;
        private Label lblSearch;
        private Button btnYazdir;
        private Panel panel1;
    }
}