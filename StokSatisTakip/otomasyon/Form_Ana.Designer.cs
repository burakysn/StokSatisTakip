namespace otomasyon
{
    partial class Form_Ana
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müsteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICIKAYITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriBİlgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriListeisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müsteriToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.ürünToolStripMenuItem,
            this.kategoriToolStripMenuItem,
            this.satışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müsteriToolStripMenuItem
            // 
            this.müsteriToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.müsteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kULLANICIKAYITToolStripMenuItem,
            this.kullanıcıBilgileriToolStripMenuItem});
            this.müsteriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müsteriToolStripMenuItem.Name = "müsteriToolStripMenuItem";
            this.müsteriToolStripMenuItem.Size = new System.Drawing.Size(89, 25);
            this.müsteriToolStripMenuItem.Text = "Kullanıcı";
            // 
            // kULLANICIKAYITToolStripMenuItem
            // 
            this.kULLANICIKAYITToolStripMenuItem.Name = "kULLANICIKAYITToolStripMenuItem";
            this.kULLANICIKAYITToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.kULLANICIKAYITToolStripMenuItem.Text = "Kullanıcı Kayıt";
            this.kULLANICIKAYITToolStripMenuItem.Click += new System.EventHandler(this.kULLANICIKAYITToolStripMenuItem_Click);
            // 
            // kullanıcıBilgileriToolStripMenuItem
            // 
            this.kullanıcıBilgileriToolStripMenuItem.Name = "kullanıcıBilgileriToolStripMenuItem";
            this.kullanıcıBilgileriToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.kullanıcıBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            this.kullanıcıBilgileriToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıBilgileriToolStripMenuItem_Click);
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriBİlgileriToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem});
            this.müşteriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // müşteriBİlgileriToolStripMenuItem
            // 
            this.müşteriBİlgileriToolStripMenuItem.Name = "müşteriBİlgileriToolStripMenuItem";
            this.müşteriBİlgileriToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.müşteriBİlgileriToolStripMenuItem.Text = "Müşteri Kaydı";
            this.müşteriBİlgileriToolStripMenuItem.Click += new System.EventHandler(this.müşteriBİlgileriToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // ürünToolStripMenuItem
            // 
            this.ürünToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünListesiToolStripMenuItem,
            this.ürünListesiToolStripMenuItem1});
            this.ürünToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünToolStripMenuItem.Name = "ürünToolStripMenuItem";
            this.ürünToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.ürünToolStripMenuItem.Text = "Ürün";
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Kaydı";
            this.ürünListesiToolStripMenuItem.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem1
            // 
            this.ürünListesiToolStripMenuItem1.Name = "ürünListesiToolStripMenuItem1";
            this.ürünListesiToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.ürünListesiToolStripMenuItem1.Text = "Ürün Listesi";
            this.ürünListesiToolStripMenuItem1.Click += new System.EventHandler(this.ürünListesiToolStripMenuItem1_Click);
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriEkleToolStripMenuItem,
            this.kategoriListeisToolStripMenuItem});
            this.kategoriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(87, 25);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            // 
            // kategoriEkleToolStripMenuItem
            // 
            this.kategoriEkleToolStripMenuItem.Name = "kategoriEkleToolStripMenuItem";
            this.kategoriEkleToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.kategoriEkleToolStripMenuItem.Text = "Kategori Ekle";
            this.kategoriEkleToolStripMenuItem.Click += new System.EventHandler(this.kategoriEkleToolStripMenuItem_Click);
            // 
            // kategoriListeisToolStripMenuItem
            // 
            this.kategoriListeisToolStripMenuItem.Name = "kategoriListeisToolStripMenuItem";
            this.kategoriListeisToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.kategoriListeisToolStripMenuItem.Text = "Kategori Listesi";
            this.kategoriListeisToolStripMenuItem.Click += new System.EventHandler(this.kategoriListeisToolStripMenuItem_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.satışToolStripMenuItem.Text = "Satış";
            this.satışToolStripMenuItem.Click += new System.EventHandler(this.satışToolStripMenuItem_Click);
            // 
            // Form_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Ana";
            this.Text = "MÜŞTERİ TAKİP OTOMASYONU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müsteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriBİlgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kULLANICIKAYITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategoriListeisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
    }
}

