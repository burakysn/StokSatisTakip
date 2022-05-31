namespace otomasyon
{
    partial class frm_urun_kayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_urunadi = new System.Windows.Forms.TextBox();
            this.txt_marka = new System.Windows.Forms.TextBox();
            this.txt_utarih = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_ttarih = new System.Windows.Forms.TextBox();
            this.BTN_KYT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üretim Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(41, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tüketim Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(41, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fiyat";
            // 
            // txt_urunadi
            // 
            this.txt_urunadi.Location = new System.Drawing.Point(186, 27);
            this.txt_urunadi.Name = "txt_urunadi";
            this.txt_urunadi.Size = new System.Drawing.Size(164, 20);
            this.txt_urunadi.TabIndex = 1;
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(186, 74);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Size = new System.Drawing.Size(164, 20);
            this.txt_marka.TabIndex = 1;
            // 
            // txt_utarih
            // 
            this.txt_utarih.Location = new System.Drawing.Point(186, 125);
            this.txt_utarih.Name = "txt_utarih";
            this.txt_utarih.Size = new System.Drawing.Size(164, 20);
            this.txt_utarih.TabIndex = 1;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(186, 244);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(164, 20);
            this.txt_fiyat.TabIndex = 1;
            // 
            // txt_ttarih
            // 
            this.txt_ttarih.Location = new System.Drawing.Point(186, 186);
            this.txt_ttarih.Name = "txt_ttarih";
            this.txt_ttarih.Size = new System.Drawing.Size(164, 20);
            this.txt_ttarih.TabIndex = 1;
            // 
            // BTN_KYT
            // 
            this.BTN_KYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_KYT.Location = new System.Drawing.Point(186, 304);
            this.BTN_KYT.Name = "BTN_KYT";
            this.BTN_KYT.Size = new System.Drawing.Size(164, 41);
            this.BTN_KYT.TabIndex = 2;
            this.BTN_KYT.Text = "KAYIT";
            this.BTN_KYT.UseVisualStyleBackColor = true;
            this.BTN_KYT.Click += new System.EventHandler(this.BTN_KYT_Click);
            // 
            // frm_urun_kayit
            // 
            this.AcceptButton = this.BTN_KYT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_KYT);
            this.Controls.Add(this.txt_ttarih);
            this.Controls.Add(this.txt_fiyat);
            this.Controls.Add(this.txt_utarih);
            this.Controls.Add(this.txt_marka);
            this.Controls.Add(this.txt_urunadi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_urun_kayit";
            this.Text = "ÜRÜN KAYIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_urunadi;
        private System.Windows.Forms.TextBox txt_marka;
        private System.Windows.Forms.TextBox txt_utarih;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_ttarih;
        private System.Windows.Forms.Button BTN_KYT;
    }
}