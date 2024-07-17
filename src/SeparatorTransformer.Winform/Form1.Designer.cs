namespace SeparatorTransformer.Winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DosyaSec = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.KonumSec = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Donustur = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DosyaSec
            // 
            this.DosyaSec.Location = new System.Drawing.Point(570, 46);
            this.DosyaSec.Name = "DosyaSec";
            this.DosyaSec.Size = new System.Drawing.Size(75, 23);
            this.DosyaSec.TabIndex = 5;
            this.DosyaSec.Text = "Dosya Seç";
            this.DosyaSec.UseVisualStyleBackColor = true;
            this.DosyaSec.Click += new System.EventHandler(this.DosyaSec_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(448, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // KonumSec
            // 
            this.KonumSec.Location = new System.Drawing.Point(570, 85);
            this.KonumSec.Name = "KonumSec";
            this.KonumSec.Size = new System.Drawing.Size(75, 20);
            this.KonumSec.TabIndex = 7;
            this.KonumSec.Text = "Seç";
            this.KonumSec.UseVisualStyleBackColor = true;
            this.KonumSec.Click += new System.EventHandler(this.KonumSec_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 13);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "Dosya:";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(98, 13);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "Hedef Konum:";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Donustur
            // 
            this.Donustur.Location = new System.Drawing.Point(570, 209);
            this.Donustur.Name = "Donustur";
            this.Donustur.Size = new System.Drawing.Size(75, 23);
            this.Donustur.TabIndex = 10;
            this.Donustur.Text = "Dönüştür";
            this.Donustur.UseVisualStyleBackColor = true;
            this.Donustur.Click += new System.EventHandler(this.Donustur_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(464, 128);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(464, 167);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 13;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(324, 131);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(134, 13);
            this.textBox7.TabIndex = 14;
            this.textBox7.Text = "Değiştirilecek Karakter: ";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(360, 170);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(98, 13);
            this.textBox8.TabIndex = 15;
            this.textBox8.Text = "Yeni Karakter:";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 209);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 244);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Donustur);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.KonumSec);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DosyaSec);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halkbank Karakter Dönüştürücü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DosyaSec;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button KonumSec;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Donustur;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

