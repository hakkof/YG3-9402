namespace Donguler01
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
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnTekSayilar = new System.Windows.Forms.Button();
            this.btnKompleks = new System.Windows.Forms.Button();
            this.lbListe2 = new System.Windows.Forms.ListBox();
            this.btnKompleks2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(152, 12);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(150, 264);
            this.lbListe.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(12, 12);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(134, 41);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "FOR : 1-100";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnTekSayilar
            // 
            this.btnTekSayilar.Location = new System.Drawing.Point(12, 59);
            this.btnTekSayilar.Name = "btnTekSayilar";
            this.btnTekSayilar.Size = new System.Drawing.Size(134, 41);
            this.btnTekSayilar.TabIndex = 1;
            this.btnTekSayilar.Text = "FOR : 1-100 Tek Sayılar";
            this.btnTekSayilar.UseVisualStyleBackColor = true;
            this.btnTekSayilar.Click += new System.EventHandler(this.btnTekSayilar_Click);
            // 
            // btnKompleks
            // 
            this.btnKompleks.Location = new System.Drawing.Point(12, 106);
            this.btnKompleks.Name = "btnKompleks";
            this.btnKompleks.Size = new System.Drawing.Size(134, 41);
            this.btnKompleks.TabIndex = 2;
            this.btnKompleks.Text = "FOR : Kompleks";
            this.btnKompleks.UseVisualStyleBackColor = true;
            this.btnKompleks.Click += new System.EventHandler(this.btnKompleks_Click);
            // 
            // lbListe2
            // 
            this.lbListe2.FormattingEnabled = true;
            this.lbListe2.Location = new System.Drawing.Point(308, 12);
            this.lbListe2.Name = "lbListe2";
            this.lbListe2.Size = new System.Drawing.Size(150, 264);
            this.lbListe2.TabIndex = 3;
            // 
            // btnKompleks2
            // 
            this.btnKompleks2.Location = new System.Drawing.Point(12, 153);
            this.btnKompleks2.Name = "btnKompleks2";
            this.btnKompleks2.Size = new System.Drawing.Size(134, 41);
            this.btnKompleks2.TabIndex = 2;
            this.btnKompleks2.Text = "FOR : Kompleks 2";
            this.btnKompleks2.UseVisualStyleBackColor = true;
            this.btnKompleks2.Click += new System.EventHandler(this.btnKompleks2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 283);
            this.Controls.Add(this.lbListe2);
            this.Controls.Add(this.btnKompleks2);
            this.Controls.Add(this.btnKompleks);
            this.Controls.Add(this.btnTekSayilar);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.lbListe);
            this.Name = "Form1";
            this.Text = "Donguler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnTekSayilar;
        private System.Windows.Forms.Button btnKompleks;
        private System.Windows.Forms.ListBox lbListe2;
        private System.Windows.Forms.Button btnKompleks2;
    }
}

