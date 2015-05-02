namespace Donguler02
{
    partial class Form1
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
            this.btnTumListe = new System.Windows.Forms.Button();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.btnCiftSayilar = new System.Windows.Forms.Button();
            this.btnKompleks = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnTumListe
            // 
            this.btnTumListe.Location = new System.Drawing.Point(12, 12);
            this.btnTumListe.Name = "btnTumListe";
            this.btnTumListe.Size = new System.Drawing.Size(128, 45);
            this.btnTumListe.TabIndex = 0;
            this.btnTumListe.Text = "Tüm Listeyi Göster";
            this.btnTumListe.UseVisualStyleBackColor = true;
            this.btnTumListe.Click += new System.EventHandler(this.btnTumListe_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(12, 63);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(128, 45);
            this.btnTekSayilar.TabIndex = 0;
            this.btnTekSayilar.Text = "Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.btnTekSayilar_Click);
            // 
            // btnCiftSayilar
            // 
            this.btnCiftSayilar.Location = new System.Drawing.Point(12, 63);
            this.btnCiftSayilar.Name = "btnCiftSayilar";
            this.btnCiftSayilar.Size = new System.Drawing.Size(128, 45);
            this.btnCiftSayilar.TabIndex = 0;
            this.btnCiftSayilar.Text = "Çift Sayılar";
            this.btnCiftSayilar.UseVisualStyleBackColor = true;
            this.btnCiftSayilar.Click += new System.EventHandler(this.btnCiftSayilar_Click);
            // 
            // btnKompleks
            // 
            this.btnKompleks.Location = new System.Drawing.Point(12, 165);
            this.btnKompleks.Name = "btnKompleks";
            this.btnKompleks.Size = new System.Drawing.Size(128, 61);
            this.btnKompleks.TabIndex = 0;
            this.btnKompleks.Text = "2 ye Bölünüp 3 e bölünmeyler";
            this.btnKompleks.UseVisualStyleBackColor = true;
            this.btnKompleks.Click += new System.EventHandler(this.btnKompleks_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(146, 12);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(120, 212);
            this.lbListe.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 231);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnKompleks);
            this.Controls.Add(this.btnCiftSayilar);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.btnTumListe);
            this.Name = "Form1";
            this.Text = "1 den 100 e Kadar Olan Sayılar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTumListe;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.Button btnCiftSayilar;
        private System.Windows.Forms.Button btnKompleks;
        private System.Windows.Forms.ListBox lbListe;
    }
}

