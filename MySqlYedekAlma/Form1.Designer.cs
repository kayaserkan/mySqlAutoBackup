﻿namespace MySqlYedekAlma
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbSunucu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDbAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBirSeferlikKayit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownSaat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDakika = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "BİLGİLERİ KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tbSunucu
            // 
            this.tbSunucu.Location = new System.Drawing.Point(184, 15);
            this.tbSunucu.Name = "tbSunucu";
            this.tbSunucu.Size = new System.Drawing.Size(243, 22);
            this.tbSunucu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sunucu Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "DataBase Adı";
            // 
            // tbDbAdi
            // 
            this.tbDbAdi.Location = new System.Drawing.Point(184, 49);
            this.tbDbAdi.Name = "tbDbAdi";
            this.tbDbAdi.Size = new System.Drawing.Size(243, 22);
            this.tbDbAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // tbSifre
            // 
            this.tbSifre.Location = new System.Drawing.Point(184, 117);
            this.tbSifre.Name = "tbSifre";
            this.tbSifre.Size = new System.Drawing.Size(243, 22);
            this.tbSifre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kullanıcı Adi";
            // 
            // tbKullaniciAdi
            // 
            this.tbKullaniciAdi.Location = new System.Drawing.Point(184, 83);
            this.tbKullaniciAdi.Name = "tbKullaniciAdi";
            this.tbKullaniciAdi.Size = new System.Drawing.Size(243, 22);
            this.tbKullaniciAdi.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yedekleme Saati";
            // 
            // btnBirSeferlikKayit
            // 
            this.btnBirSeferlikKayit.Location = new System.Drawing.Point(472, 88);
            this.btnBirSeferlikKayit.Name = "btnBirSeferlikKayit";
            this.btnBirSeferlikKayit.Size = new System.Drawing.Size(175, 51);
            this.btnBirSeferlikKayit.TabIndex = 12;
            this.btnBirSeferlikKayit.Text = "BİR SEFERLİK BACKUP";
            this.btnBirSeferlikKayit.UseVisualStyleBackColor = true;
            this.btnBirSeferlikKayit.Click += new System.EventHandler(this.BtnBirSeferlikKayit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(384, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 34);
            this.button3.TabIndex = 13;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kayıt Klasörü Seçimi";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(329, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 21);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Düzenli Kayıt";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSaat
            // 
            this.numericUpDownSaat.Location = new System.Drawing.Point(184, 198);
            this.numericUpDownSaat.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownSaat.Name = "numericUpDownSaat";
            this.numericUpDownSaat.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownSaat.TabIndex = 16;
            // 
            // numericUpDownDakika
            // 
            this.numericUpDownDakika.Location = new System.Drawing.Point(242, 198);
            this.numericUpDownDakika.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownDakika.Name = "numericUpDownDakika";
            this.numericUpDownDakika.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownDakika.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 231);
            this.Controls.Add(this.numericUpDownDakika);
            this.Controls.Add(this.numericUpDownSaat);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBirSeferlikKayit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDbAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSunucu);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "MySql Oto Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDakika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbSunucu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDbAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSifre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKullaniciAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBirSeferlikKayit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownSaat;
        private System.Windows.Forms.NumericUpDown numericUpDownDakika;
        private System.Windows.Forms.Timer timer1;
    }
}

