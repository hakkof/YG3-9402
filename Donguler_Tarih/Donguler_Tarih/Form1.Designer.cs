namespace Donguler_Tarih
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
            this.cbGun = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbYil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbGun
            // 
            this.cbGun.FormattingEnabled = true;
            this.cbGun.Location = new System.Drawing.Point(29, 37);
            this.cbGun.Name = "cbGun";
            this.cbGun.Size = new System.Drawing.Size(121, 33);
            this.cbGun.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ay";
            // 
            // cbAy
            // 
            this.cbAy.FormattingEnabled = true;
            this.cbAy.Location = new System.Drawing.Point(156, 37);
            this.cbAy.Name = "cbAy";
            this.cbAy.Size = new System.Drawing.Size(121, 33);
            this.cbAy.TabIndex = 2;
            this.cbAy.SelectedIndexChanged += new System.EventHandler(this.cbAy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yıl";
            // 
            // cbYil
            // 
            this.cbYil.FormattingEnabled = true;
            this.cbYil.Location = new System.Drawing.Point(283, 37);
            this.cbYil.Name = "cbYil";
            this.cbYil.Size = new System.Drawing.Size(121, 33);
            this.cbYil.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbYil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGun);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbAy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbYil;
    }
}

