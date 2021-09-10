
namespace EntitiyOrnek
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnJoin = new System.Windows.Forms.Button();
            this.btnDersListesi = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.btnProsedur = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.BtnLinqEntity = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(941, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(12, 215);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(191, 34);
            this.btnOgrenciListele.TabIndex = 1;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 255);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(191, 34);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(12, 295);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(191, 34);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(12, 335);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(191, 34);
            this.btnGüncelle.TabIndex = 4;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(12, 375);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(191, 34);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOgrenciID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 221);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(153, 110);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(182, 26);
            this.txtFoto.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fotoğraf:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(153, 78);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(182, 26);
            this.txtSoyad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(153, 46);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(182, 26);
            this.txtAd.TabIndex = 17;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ad:";
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(153, 13);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(182, 26);
            this.txtOgrenciID.TabIndex = 15;
            this.txtOgrenciID.TextChanged += new System.EventHandler(this.txtOgrenciID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDersAd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(609, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 91);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(153, 46);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(182, 26);
            this.txtDersAd.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ad:";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(153, 13);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(182, 26);
            this.txtDersID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(122, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "ID:";
            // 
            // BtnJoin
            // 
            this.BtnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnJoin.Location = new System.Drawing.Point(229, 495);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(199, 28);
            this.BtnJoin.TabIndex = 25;
            this.BtnJoin.Text = "Join İle Getir";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // btnDersListesi
            // 
            this.btnDersListesi.Location = new System.Drawing.Point(12, 415);
            this.btnDersListesi.Name = "btnDersListesi";
            this.btnDersListesi.Size = new System.Drawing.Size(191, 34);
            this.btnDersListesi.TabIndex = 9;
            this.btnDersListesi.Text = "Ders Listesi";
            this.btnDersListesi.UseVisualStyleBackColor = true;
            this.btnDersListesi.Click += new System.EventHandler(this.btnDersListesi_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(12, 455);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(191, 34);
            this.BtnNotListesi.TabIndex = 10;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // btnProsedur
            // 
            this.btnProsedur.Location = new System.Drawing.Point(12, 495);
            this.btnProsedur.Name = "btnProsedur";
            this.btnProsedur.Size = new System.Drawing.Size(191, 34);
            this.btnProsedur.TabIndex = 11;
            this.btnProsedur.Text = "Prosedür";
            this.btnProsedur.UseVisualStyleBackColor = true;
            this.btnProsedur.Click += new System.EventHandler(this.btnProsedur_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(962, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(180, 24);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sırala (A-Z)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // BtnLinqEntity
            // 
            this.BtnLinqEntity.Location = new System.Drawing.Point(962, 438);
            this.BtnLinqEntity.Name = "BtnLinqEntity";
            this.BtnLinqEntity.Size = new System.Drawing.Size(183, 28);
            this.BtnLinqEntity.TabIndex = 13;
            this.BtnLinqEntity.Text = "Linq Entity";
            this.BtnLinqEntity.UseVisualStyleBackColor = true;
            this.BtnLinqEntity.Click += new System.EventHandler(this.BtnLinqEntity_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(962, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 24);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ada Göre Sırala (Z-A)";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(962, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(94, 24);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "İlk 3 Kayıt\r\n";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(962, 99);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(174, 24);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ID\'ye Göre Veri Getir";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(962, 128);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(172, 24);
            this.radioButton5.TabIndex = 17;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Adı A İle Başlayanlar\r\n";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(962, 157);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(144, 24);
            this.radioButton6.TabIndex = 18;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Adı A İle Bitenler\r\n";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(962, 186);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(120, 24);
            this.radioButton7.TabIndex = 19;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Değer Var Mı";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(962, 215);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(183, 24);
            this.radioButton8.TabIndex = 20;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Toplam Öğrenci Sayısı\r\n";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(962, 244);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(176, 24);
            this.radioButton9.TabIndex = 21;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "Sınav 1 Toplam Puan\r\n";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(962, 273);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(189, 24);
            this.radioButton10.TabIndex = 22;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "Sınav 1 Ortalama Puan\r\n";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton11.Location = new System.Drawing.Point(962, 303);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(184, 44);
            this.radioButton11.TabIndex = 23;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "Sınav 1 Ortalamasının \r\nÜstündeki Öğrenciler\r\n";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(963, 353);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(164, 44);
            this.radioButton12.TabIndex = 24;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "Sınav 1 En Yüksek \r\nAlan Öğrenci\r\n";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton12_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 553);
            this.Controls.Add(this.BtnJoin);
            this.Controls.Add(this.radioButton12);
            this.Controls.Add(this.radioButton11);
            this.Controls.Add(this.radioButton10);
            this.Controls.Add(this.radioButton9);
            this.Controls.Add(this.radioButton8);
            this.Controls.Add(this.radioButton7);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.BtnLinqEntity);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnProsedur);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.btnDersListesi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ID";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDersListesi;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnJoin;
        private System.Windows.Forms.Button btnProsedur;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button BtnLinqEntity;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
    }
}

