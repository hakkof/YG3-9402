namespace Arrayler_ComboBoxDoldurma
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
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.txtDeger2 = new System.Windows.Forms.TextBox();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnDoldur2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(12, 12);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(149, 32);
            this.txtDeger.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(167, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(123, 32);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cbListe
            // 
            this.cbListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(12, 50);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(149, 33);
            this.cbListe.TabIndex = 2;
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(167, 51);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(123, 32);
            this.btnDoldur.TabIndex = 3;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(167, 197);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(123, 32);
            this.btnEkle2.TabIndex = 5;
            this.btnEkle2.Text = "Ekle";
            this.btnEkle2.UseVisualStyleBackColor = true;
            // 
            // txtDeger2
            // 
            this.txtDeger2.Location = new System.Drawing.Point(12, 197);
            this.txtDeger2.Name = "txtDeger2";
            this.txtDeger2.Size = new System.Drawing.Size(149, 32);
            this.txtDeger2.TabIndex = 4;
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 25;
            this.lbListe.Location = new System.Drawing.Point(12, 235);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(407, 154);
            this.lbListe.TabIndex = 6;
            // 
            // btnDoldur2
            // 
            this.btnDoldur2.Location = new System.Drawing.Point(296, 197);
            this.btnDoldur2.Name = "btnDoldur2";
            this.btnDoldur2.Size = new System.Drawing.Size(123, 32);
            this.btnDoldur2.TabIndex = 7;
            this.btnDoldur2.Text = "Doldur";
            this.btnDoldur2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 502);
            this.Controls.Add(this.btnDoldur2);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnEkle2);
            this.Controls.Add(this.txtDeger2);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.cbListe);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtDeger);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDeger;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.TextBox txtDeger2;
        private System.Windows.Forms.ListBox lbListe;
        private System.Windows.Forms.Button btnDoldur2;
    }
}

