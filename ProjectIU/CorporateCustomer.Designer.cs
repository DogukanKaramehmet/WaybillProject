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
            menuStrip1 = new MenuStrip();
            irsaliyeYazdırToolStripMenuItem = new ToolStripMenuItem();
            irsaliyeGeçmişiToolStripMenuItem = new ToolStripMenuItem();
            müşterilerToolStripMenuItem = new ToolStripMenuItem();
            kurumsalMüşteriToolStripMenuItem = new ToolStripMenuItem();
            bireyselMüşteriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { irsaliyeYazdırToolStripMenuItem, irsaliyeGeçmişiToolStripMenuItem, müşterilerToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1264, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // irsaliyeYazdırToolStripMenuItem
            // 
            irsaliyeYazdırToolStripMenuItem.Name = "irsaliyeYazdırToolStripMenuItem";
            irsaliyeYazdırToolStripMenuItem.Size = new Size(89, 20);
            irsaliyeYazdırToolStripMenuItem.Text = "İrsaliye Yazdır";
            // 
            // irsaliyeGeçmişiToolStripMenuItem
            // 
            irsaliyeGeçmişiToolStripMenuItem.Name = "irsaliyeGeçmişiToolStripMenuItem";
            irsaliyeGeçmişiToolStripMenuItem.Size = new Size(100, 20);
            irsaliyeGeçmişiToolStripMenuItem.Text = "İrsaliye Geçmişi";
            // 
            // müşterilerToolStripMenuItem
            // 
            müşterilerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kurumsalMüşteriToolStripMenuItem, bireyselMüşteriToolStripMenuItem });
            müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            müşterilerToolStripMenuItem.Size = new Size(72, 20);
            müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // kurumsalMüşteriToolStripMenuItem
            // 
            kurumsalMüşteriToolStripMenuItem.Name = "kurumsalMüşteriToolStripMenuItem";
            kurumsalMüşteriToolStripMenuItem.Size = new Size(167, 22);
            kurumsalMüşteriToolStripMenuItem.Text = "Kurumsal Müşteri";
            // 
            // bireyselMüşteriToolStripMenuItem
            // 
            bireyselMüşteriToolStripMenuItem.Name = "bireyselMüşteriToolStripMenuItem";
            bireyselMüşteriToolStripMenuItem.Size = new Size(167, 22);
            bireyselMüşteriToolStripMenuItem.Text = "Bireysel Müşteri";
            // 
            // CorporateCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(menuStrip1);
            Name = "CorporateCustomer";
            Text = "CorporateCustomer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem irsaliyeYazdırToolStripMenuItem;
        private ToolStripMenuItem irsaliyeGeçmişiToolStripMenuItem;
        private ToolStripMenuItem müşterilerToolStripMenuItem;
        private ToolStripMenuItem kurumsalMüşteriToolStripMenuItem;
        private ToolStripMenuItem bireyselMüşteriToolStripMenuItem;
    }
}