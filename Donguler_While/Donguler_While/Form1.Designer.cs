namespace Donguler_While
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
            this.components = new System.ComponentModel.Container();
            this.btnRastgeleSayiBul = new System.Windows.Forms.Button();
            this.lblRastgeleSayi = new System.Windows.Forms.Label();
            this.tmrWhile = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRastgeleSayiBul
            // 
            this.btnRastgeleSayiBul.Location = new System.Drawing.Point(12, 12);
            this.btnRastgeleSayiBul.Name = "btnRastgeleSayiBul";
            this.btnRastgeleSayiBul.Size = new System.Drawing.Size(130, 52);
            this.btnRastgeleSayiBul.TabIndex = 0;
            this.btnRastgeleSayiBul.Text = "Rastgele Sayı Bul";
            this.btnRastgeleSayiBul.UseVisualStyleBackColor = true;
            this.btnRastgeleSayiBul.Click += new System.EventHandler(this.btnRastgeleSayiBul_Click);
            // 
            // lblRastgeleSayi
            // 
            this.lblRastgeleSayi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRastgeleSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRastgeleSayi.Location = new System.Drawing.Point(160, 12);
            this.lblRastgeleSayi.Name = "lblRastgeleSayi";
            this.lblRastgeleSayi.Size = new System.Drawing.Size(124, 52);
            this.lblRastgeleSayi.TabIndex = 1;
            // 
            // tmrWhile
            // 
            this.tmrWhile.Enabled = true;
            this.tmrWhile.Interval = 1000;
            this.tmrWhile.Tick += new System.EventHandler(this.tmrWhile_Tick);
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMessage.Location = new System.Drawing.Point(12, 67);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(272, 165);
            this.lblMessage.TabIndex = 2;
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(12, 246);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(75, 48);
            this.btnDoWhile.TabIndex = 3;
            this.btnDoWhile.Text = "Do While";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnFor
            // 
            this.btnFor.Location = new System.Drawing.Point(12, 300);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(75, 44);
            this.btnFor.TabIndex = 4;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(12, 350);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(75, 44);
            this.btnWhile.TabIndex = 4;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // lbListe
            // 
            this.lbListe.FormattingEnabled = true;
            this.lbListe.Location = new System.Drawing.Point(93, 249);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(186, 147);
            this.lbListe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 403);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblRastgeleSayi);
            this.Controls.Add(this.btnRastgeleSayiBul);
            this.Name = "Form1";
            this.Text = "While Donguleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRastgeleSayiBul;
        private System.Windows.Forms.Label lblRastgeleSayi;
        private System.Windows.Forms.Timer tmrWhile;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox lbListe;
    }
}

