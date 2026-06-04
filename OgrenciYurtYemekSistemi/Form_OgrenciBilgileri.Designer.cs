using System;

namespace OgrenciYurtYemekSistemi
{
    partial class Form_OgrenciBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_listele = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_ogrenci = new System.Windows.Forms.ComboBox();
            this.combo_oda = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radio_tum = new System.Windows.Forms.RadioButton();
            this.radio_aktif = new System.Windows.Forms.RadioButton();
            this.radio_pasif = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_listele
            // 
            this.btn_listele.BackColor = System.Drawing.Color.Black;
            this.btn_listele.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_listele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_listele.Location = new System.Drawing.Point(436, 352);
            this.btn_listele.Name = "btn_listele";
            this.btn_listele.Size = new System.Drawing.Size(129, 60);
            this.btn_listele.TabIndex = 1;
            this.btn_listele.Text = "Listele";
            this.btn_listele.UseVisualStyleBackColor = false;
            this.btn_listele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Black;
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ekle.Location = new System.Drawing.Point(92, 104);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(153, 44);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Black;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_sil.Location = new System.Drawing.Point(609, 352);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(128, 60);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Öğrenci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Oda No";
            // 
            // combo_ogrenci
            // 
            this.combo_ogrenci.FormattingEnabled = true;
            this.combo_ogrenci.Location = new System.Drawing.Point(106, 29);
            this.combo_ogrenci.Name = "combo_ogrenci";
            this.combo_ogrenci.Size = new System.Drawing.Size(121, 27);
            this.combo_ogrenci.TabIndex = 6;
            this.combo_ogrenci.SelectedIndexChanged += new System.EventHandler(this.combo_ogrenci_SelectedIndexChanged);
            // 
            // combo_oda
            // 
            this.combo_oda.FormattingEnabled = true;
            this.combo_oda.Location = new System.Drawing.Point(106, 71);
            this.combo_oda.Name = "combo_oda";
            this.combo_oda.Size = new System.Drawing.Size(121, 27);
            this.combo_oda.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combo_oda);
            this.groupBox1.Controls.Add(this.combo_ogrenci);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(33, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci İşlemleri";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(858, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 95);
            this.button1.TabIndex = 9;
            this.button1.Text = "Sisteme Geri Dön";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radio_tum
            // 
            this.radio_tum.AutoSize = true;
            this.radio_tum.Location = new System.Drawing.Point(40, 74);
            this.radio_tum.Name = "radio_tum";
            this.radio_tum.Size = new System.Drawing.Size(134, 23);
            this.radio_tum.TabIndex = 10;
            this.radio_tum.TabStop = true;
            this.radio_tum.Text = "Tüm Öğrenciler";
            this.radio_tum.UseVisualStyleBackColor = true;
            this.radio_tum.CheckedChanged += new System.EventHandler(this.radio_tum_CheckedChanged);
            // 
            // radio_aktif
            // 
            this.radio_aktif.AutoSize = true;
            this.radio_aktif.Location = new System.Drawing.Point(40, 48);
            this.radio_aktif.Name = "radio_aktif";
            this.radio_aktif.Size = new System.Drawing.Size(137, 23);
            this.radio_aktif.TabIndex = 11;
            this.radio_aktif.TabStop = true;
            this.radio_aktif.Text = "Aktif Öğrenciler";
            this.radio_aktif.UseVisualStyleBackColor = true;
            this.radio_aktif.CheckedChanged += new System.EventHandler(this.radio_aktif_CheckedChanged);
            // 
            // radio_pasif
            // 
            this.radio_pasif.AutoSize = true;
            this.radio_pasif.Location = new System.Drawing.Point(40, 103);
            this.radio_pasif.Name = "radio_pasif";
            this.radio_pasif.Size = new System.Drawing.Size(141, 23);
            this.radio_pasif.TabIndex = 12;
            this.radio_pasif.TabStop = true;
            this.radio_pasif.Text = "Pasif  Öğrenciler";
            this.radio_pasif.UseVisualStyleBackColor = true;
            this.radio_pasif.CheckedChanged += new System.EventHandler(this.radio_pasif_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1437, 92);
            this.panel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1058, 82);
            this.label3.TabIndex = 0;
            this.label3.Text = "MAVİ ÖZEL YURDU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci Dostu Yurt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radio_pasif);
            this.groupBox2.Controls.Add(this.radio_tum);
            this.groupBox2.Controls.Add(this.radio_aktif);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1092, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 154);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Sorgulama İşlemleri";
            // 
            // Form_OgrenciBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1437, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_listele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_OgrenciBilgileri";
            this.Text = "Form_OgrenciBilgileri";
            this.Load += new System.EventHandler(this.Form_OgrenciBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void combo_ogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_listele;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_ogrenci;
        private System.Windows.Forms.ComboBox combo_oda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radio_tum;
        private System.Windows.Forms.RadioButton radio_aktif;
        private System.Windows.Forms.RadioButton radio_pasif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}