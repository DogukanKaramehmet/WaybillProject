﻿namespace ProjectIU
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            irsaliyeYazdırToolStripMenuItem = new ToolStripMenuItem();
            irsaliyeGeçmişiToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            kurumsalMüşteriToolStripMenuItem = new ToolStripMenuItem();
            bireyselMüşteriToolStripMenuItem = new ToolStripMenuItem();
            tümMüşterilerToolStripMenuItem = new ToolStripMenuItem();
            grbBireysel = new GroupBox();
            label1 = new Label();
            cmbBireyselSec = new ComboBox();
            btnBireyselYazdir = new Button();
            txtBireyselFiyat = new TextBox();
            txtBireyselTeknisyen = new TextBox();
            dtimeBireyselTarih = new DateTimePicker();
            txtBireyselAciklama = new TextBox();
            lblAmount = new Label();
            lblTechnician = new Label();
            lblDate = new Label();
            lblDescription = new Label();
            grbKurumsal = new GroupBox();
            label2 = new Label();
            cmbKurum = new ComboBox();
            btnKurumYazdir = new Button();
            txtKurumFiyat = new TextBox();
            txtKurumTeknisyen = new TextBox();
            dtimeKurumtarih = new DateTimePicker();
            txtKurumAciklama = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRefres = new Button();
            btnKurumsal = new Button();
            btnBireysel = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            grbBireysel.SuspendLayout();
            grbKurumsal.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DeepSkyBlue;
            menuStrip1.Items.AddRange(new ToolStripItem[] { irsaliyeYazdırToolStripMenuItem, irsaliyeGeçmişiToolStripMenuItem, müşterilerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // irsaliyeYazdırToolStripMenuItem
            // 
            irsaliyeYazdırToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            irsaliyeYazdırToolStripMenuItem.Name = "irsaliyeYazdırToolStripMenuItem";
            irsaliyeYazdırToolStripMenuItem.Size = new Size(94, 20);
            irsaliyeYazdırToolStripMenuItem.Text = "İrsaliye Yazdır";
            // 
            // irsaliyeGeçmişiToolStripMenuItem
            // 
            irsaliyeGeçmişiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            irsaliyeGeçmişiToolStripMenuItem.Name = "irsaliyeGeçmişiToolStripMenuItem";
            irsaliyeGeçmişiToolStripMenuItem.Size = new Size(105, 20);
            irsaliyeGeçmişiToolStripMenuItem.Text = "İrsaliye Geçmişi";
            irsaliyeGeçmişiToolStripMenuItem.Click += irsaliyeGeçmişiToolStripMenuItem_Click;
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kurumsalMüşteriToolStripMenuItem, bireyselMüşteriToolStripMenuItem, tümMüşterilerToolStripMenuItem });
            müşterilerToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(77, 20);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // kurumsalMüşteriToolStripMenuItem
            // 
            kurumsalMüşteriToolStripMenuItem.Name = "kurumsalMüşteriToolStripMenuItem";
            kurumsalMüşteriToolStripMenuItem.Size = new Size(172, 22);
            kurumsalMüşteriToolStripMenuItem.Text = "Kurumsal Müşteri";
            kurumsalMüşteriToolStripMenuItem.Click += kurumsalMüşteriToolStripMenuItem_Click;
            // 
            // bireyselMüşteriToolStripMenuItem
            // 
            bireyselMüşteriToolStripMenuItem.Name = "bireyselMüşteriToolStripMenuItem";
            bireyselMüşteriToolStripMenuItem.Size = new Size(172, 22);
            bireyselMüşteriToolStripMenuItem.Text = "Bireysel Müşteri";
            bireyselMüşteriToolStripMenuItem.Click += bireyselMüşteriToolStripMenuItem_Click;
            // 
            // tümMüşterilerToolStripMenuItem
            // 
            tümMüşterilerToolStripMenuItem.Name = "tümMüşterilerToolStripMenuItem";
            tümMüşterilerToolStripMenuItem.Size = new Size(172, 22);
            tümMüşterilerToolStripMenuItem.Text = "Tüm Müşteriler";
            tümMüşterilerToolStripMenuItem.Click += tümMüşterilerToolStripMenuItem_Click;
            // 
            // grbBireysel
            // 
            grbBireysel.BackColor = Color.PaleTurquoise;
            grbBireysel.Controls.Add(label1);
            grbBireysel.Controls.Add(cmbBireyselSec);
            grbBireysel.Controls.Add(btnBireyselYazdir);
            grbBireysel.Controls.Add(txtBireyselFiyat);
            grbBireysel.Controls.Add(txtBireyselTeknisyen);
            grbBireysel.Controls.Add(dtimeBireyselTarih);
            grbBireysel.Controls.Add(txtBireyselAciklama);
            grbBireysel.Controls.Add(lblAmount);
            grbBireysel.Controls.Add(lblTechnician);
            grbBireysel.Controls.Add(lblDate);
            grbBireysel.Controls.Add(lblDescription);
            grbBireysel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbBireysel.Location = new Point(195, 75);
            grbBireysel.Name = "grbBireysel";
            grbBireysel.Size = new Size(1069, 624);
            grbBireysel.TabIndex = 1;
            grbBireysel.TabStop = false;
            grbBireysel.Text = "Bireysel İrsaliye";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(148, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 25;
            label1.Text = "Müşteri Seç";
            // 
            // cmbBireyselSec
            // 
            cmbBireyselSec.FormattingEnabled = true;
            cmbBireyselSec.Location = new Point(148, 49);
            cmbBireyselSec.Name = "cmbBireyselSec";
            cmbBireyselSec.Size = new Size(358, 23);
            cmbBireyselSec.TabIndex = 24;
            // 
            // btnBireyselYazdir
            // 
            btnBireyselYazdir.BackColor = Color.LightSteelBlue;
            btnBireyselYazdir.FlatStyle = FlatStyle.Popup;
            btnBireyselYazdir.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnBireyselYazdir.Location = new Point(660, 482);
            btnBireyselYazdir.Name = "btnBireyselYazdir";
            btnBireyselYazdir.Size = new Size(160, 75);
            btnBireyselYazdir.TabIndex = 23;
            btnBireyselYazdir.Text = "Yazdır";
            btnBireyselYazdir.UseVisualStyleBackColor = false;
            btnBireyselYazdir.Click += btnBireyselYazdir_Click;
            // 
            // txtBireyselFiyat
            // 
            txtBireyselFiyat.Location = new Point(635, 430);
            txtBireyselFiyat.Name = "txtBireyselFiyat";
            txtBireyselFiyat.Size = new Size(200, 23);
            txtBireyselFiyat.TabIndex = 22;
            // 
            // txtBireyselTeknisyen
            // 
            txtBireyselTeknisyen.Location = new Point(636, 179);
            txtBireyselTeknisyen.Name = "txtBireyselTeknisyen";
            txtBireyselTeknisyen.Size = new Size(200, 23);
            txtBireyselTeknisyen.TabIndex = 21;
            // 
            // dtimeBireyselTarih
            // 
            dtimeBireyselTarih.Location = new Point(636, 303);
            dtimeBireyselTarih.Name = "dtimeBireyselTarih";
            dtimeBireyselTarih.Size = new Size(200, 23);
            dtimeBireyselTarih.TabIndex = 20;
            // 
            // txtBireyselAciklama
            // 
            txtBireyselAciklama.Location = new Point(148, 140);
            txtBireyselAciklama.Multiline = true;
            txtBireyselAciklama.Name = "txtBireyselAciklama";
            txtBireyselAciklama.Size = new Size(358, 320);
            txtBireyselAciklama.TabIndex = 19;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAmount.Location = new Point(635, 381);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(58, 28);
            lblAmount.TabIndex = 18;
            lblAmount.Text = "Fiyat";
            // 
            // lblTechnician
            // 
            lblTechnician.AutoSize = true;
            lblTechnician.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTechnician.Location = new Point(636, 132);
            lblTechnician.Name = "lblTechnician";
            lblTechnician.Size = new Size(105, 28);
            lblTechnician.TabIndex = 17;
            lblTechnician.Text = "Teknisyen";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDate.Location = new Point(636, 255);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 28);
            lblDate.TabIndex = 16;
            lblDate.Text = "Tarih";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblDescription.Location = new Point(148, 109);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(99, 28);
            lblDescription.TabIndex = 15;
            lblDescription.Text = "Açıklama";
            // 
            // grbKurumsal
            // 
            grbKurumsal.BackColor = Color.PaleTurquoise;
            grbKurumsal.Controls.Add(label2);
            grbKurumsal.Controls.Add(cmbKurum);
            grbKurumsal.Controls.Add(btnKurumYazdir);
            grbKurumsal.Controls.Add(txtKurumFiyat);
            grbKurumsal.Controls.Add(txtKurumTeknisyen);
            grbKurumsal.Controls.Add(dtimeKurumtarih);
            grbKurumsal.Controls.Add(txtKurumAciklama);
            grbKurumsal.Controls.Add(label3);
            grbKurumsal.Controls.Add(label4);
            grbKurumsal.Controls.Add(label5);
            grbKurumsal.Controls.Add(label6);
            grbKurumsal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbKurumsal.Location = new Point(195, 75);
            grbKurumsal.Name = "grbKurumsal";
            grbKurumsal.Size = new Size(1069, 624);
            grbKurumsal.TabIndex = 26;
            grbKurumsal.TabStop = false;
            grbKurumsal.Text = "Kurumsal İrsaliye";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(148, 18);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 25;
            label2.Text = "Kurum Seç";
            // 
            // cmbKurum
            // 
            cmbKurum.FormattingEnabled = true;
            cmbKurum.Location = new Point(148, 49);
            cmbKurum.Name = "cmbKurum";
            cmbKurum.Size = new Size(358, 23);
            cmbKurum.TabIndex = 24;
            // 
            // btnKurumYazdir
            // 
            btnKurumYazdir.BackColor = Color.LightSteelBlue;
            btnKurumYazdir.FlatStyle = FlatStyle.Popup;
            btnKurumYazdir.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnKurumYazdir.Location = new Point(660, 482);
            btnKurumYazdir.Name = "btnKurumYazdir";
            btnKurumYazdir.Size = new Size(160, 75);
            btnKurumYazdir.TabIndex = 23;
            btnKurumYazdir.Text = "Yazdır";
            btnKurumYazdir.UseVisualStyleBackColor = false;
            btnKurumYazdir.Click += btnKurumYazdir_Click;
            // 
            // txtKurumFiyat
            // 
            txtKurumFiyat.Location = new Point(635, 430);
            txtKurumFiyat.Name = "txtKurumFiyat";
            txtKurumFiyat.Size = new Size(200, 23);
            txtKurumFiyat.TabIndex = 22;
            // 
            // txtKurumTeknisyen
            // 
            txtKurumTeknisyen.Location = new Point(636, 179);
            txtKurumTeknisyen.Name = "txtKurumTeknisyen";
            txtKurumTeknisyen.Size = new Size(200, 23);
            txtKurumTeknisyen.TabIndex = 21;
            // 
            // dtimeKurumtarih
            // 
            dtimeKurumtarih.Location = new Point(636, 303);
            dtimeKurumtarih.Name = "dtimeKurumtarih";
            dtimeKurumtarih.Size = new Size(200, 23);
            dtimeKurumtarih.TabIndex = 20;
            // 
            // txtKurumAciklama
            // 
            txtKurumAciklama.Location = new Point(148, 140);
            txtKurumAciklama.Multiline = true;
            txtKurumAciklama.Name = "txtKurumAciklama";
            txtKurumAciklama.Size = new Size(358, 320);
            txtKurumAciklama.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(635, 381);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 18;
            label3.Text = "Fiyat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(636, 132);
            label4.Name = "label4";
            label4.Size = new Size(105, 28);
            label4.TabIndex = 17;
            label4.Text = "Teknisyen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(636, 255);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 16;
            label5.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(148, 109);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 15;
            label6.Text = "Açıklama";
            // 
            // btnRefres
            // 
            btnRefres.BackColor = Color.LightSteelBlue;
            btnRefres.FlatStyle = FlatStyle.Popup;
            btnRefres.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRefres.Location = new Point(12, 213);
            btnRefres.Name = "btnRefres";
            btnRefres.Size = new Size(160, 75);
            btnRefres.TabIndex = 27;
            btnRefres.Text = "Sayfa Yenile";
            btnRefres.UseVisualStyleBackColor = false;
            btnRefres.Click += btnRefres_Click;
            // 
            // btnKurumsal
            // 
            btnKurumsal.BackColor = Color.LightSteelBlue;
            btnKurumsal.FlatStyle = FlatStyle.Popup;
            btnKurumsal.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnKurumsal.Location = new Point(12, 132);
            btnKurumsal.Name = "btnKurumsal";
            btnKurumsal.Size = new Size(160, 75);
            btnKurumsal.TabIndex = 3;
            btnKurumsal.Text = "Kurumsal \r\nİrsaliye";
            btnKurumsal.UseVisualStyleBackColor = false;
            btnKurumsal.Click += btnKurumsal_Click;
            // 
            // btnBireysel
            // 
            btnBireysel.BackColor = Color.LightSteelBlue;
            btnBireysel.FlatStyle = FlatStyle.Popup;
            btnBireysel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnBireysel.Location = new Point(12, 51);
            btnBireysel.Name = "btnBireysel";
            btnBireysel.Size = new Size(160, 75);
            btnBireysel.TabIndex = 2;
            btnBireysel.Text = "Bireysel\r\nİrsaliye\r\n";
            btnBireysel.UseVisualStyleBackColor = false;
            btnBireysel.Click += btnBireysel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(btnBireysel);
            panel1.Controls.Add(btnRefres);
            panel1.Controls.Add(btnKurumsal);
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 658);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DeepSkyBlue;
            panel2.Location = new Point(195, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1069, 51);
            panel2.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(grbKurumsal);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(grbBireysel);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = Color.DarkBlue;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İrsaliye Yazdır";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            grbBireysel.ResumeLayout(false);
            grbBireysel.PerformLayout();
            grbKurumsal.ResumeLayout(false);
            grbKurumsal.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem kurumsalMüşteriToolStripMenuItem;
        private ToolStripMenuItem bireyselMüşteriToolStripMenuItem;
        private ToolStripMenuItem irsaliyeYazdırToolStripMenuItem;
        private ToolStripMenuItem irsaliyeGeçmişiToolStripMenuItem;
        private GroupBox grbBireysel;
        private Label label1;
        private ComboBox cmbBireyselSec;
        private Button btnBireyselYazdir;
        private TextBox txtBireyselFiyat;
        private TextBox txtBireyselTeknisyen;
        private DateTimePicker dtimeBireyselTarih;
        private TextBox txtBireyselAciklama;
        private Label lblAmount;
        private Label lblTechnician;
        private Label lblDate;
        private Label lblDescription;
        private GroupBox grbKurumsal;
        private Label label2;
        private ComboBox cmbKurum;
        private Button btnKurumYazdir;
        private TextBox txtKurumFiyat;
        private TextBox txtKurumTeknisyen;
        private DateTimePicker dtimeKurumtarih;
        private TextBox txtKurumAciklama;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ToolStripMenuItem tümMüşterilerToolStripMenuItem;
        private Button btnRefres;
        private Button btnKurumsal;
        private Button btnBireysel;
        private Panel panel1;
        private Panel panel2;
    }
}
