
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.ileriBtn = new System.Windows.Forms.Button();
            this.btnFikstur = new System.Windows.Forms.Button();
            this.oyuncuIsimleriBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.ev1 = new System.Windows.Forms.Label();
            this.dep1 = new System.Windows.Forms.Label();
            this.ev2 = new System.Windows.Forms.Label();
            this.dep2 = new System.Windows.Forms.Label();
            this.ev3 = new System.Windows.Forms.Label();
            this.dep3 = new System.Windows.Forms.Label();
            this.ev4 = new System.Windows.Forms.Label();
            this.dep4 = new System.Windows.Forms.Label();
            this.ev5 = new System.Windows.Forms.Label();
            this.dep5 = new System.Windows.Forms.Label();
            this.ev6 = new System.Windows.Forms.Label();
            this.dep6 = new System.Windows.Forms.Label();
            this.mtb1 = new System.Windows.Forms.MaskedTextBox();
            this.mtb2 = new System.Windows.Forms.MaskedTextBox();
            this.mtb3 = new System.Windows.Forms.MaskedTextBox();
            this.mtb4 = new System.Windows.Forms.MaskedTextBox();
            this.mtb5 = new System.Windows.Forms.MaskedTextBox();
            this.mtb6 = new System.Windows.Forms.MaskedTextBox();
            this.mtb7 = new System.Windows.Forms.MaskedTextBox();
            this.mtb8 = new System.Windows.Forms.MaskedTextBox();
            this.mtb9 = new System.Windows.Forms.MaskedTextBox();
            this.mtb10 = new System.Windows.Forms.MaskedTextBox();
            this.mtb11 = new System.Windows.Forms.MaskedTextBox();
            this.mtb12 = new System.Windows.Forms.MaskedTextBox();
            this.guncelle1Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.puandurumuGBox = new System.Windows.Forms.GroupBox();
            this.zaferTBox = new System.Windows.Forms.TextBox();
            this.AVERAJ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fiksturGBox = new System.Windows.Forms.GroupBox();
            this.guncelle6Btn = new System.Windows.Forms.Button();
            this.guncelle5Btn = new System.Windows.Forms.Button();
            this.guncelle4Btn = new System.Windows.Forms.Button();
            this.guncelle3Btn = new System.Windows.Forms.Button();
            this.guncelle2Btn = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.ileri2Btn = new System.Windows.Forms.Button();
            this.sonGBox = new System.Windows.Forms.GroupBox();
            this.oyuncuGBox = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.MaskedTextBox();
            this.textBox3 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.MaskedTextBox();
            this.takimSecimiGBox = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.puandurumuGBox.SuspendLayout();
            this.fiksturGBox.SuspendLayout();
            this.sonGBox.SuspendLayout();
            this.oyuncuGBox.SuspendLayout();
            this.takimSecimiGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Takımlarımı Seçtim";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ileriBtn
            // 
            this.ileriBtn.Location = new System.Drawing.Point(82, 213);
            this.ileriBtn.Name = "ileriBtn";
            this.ileriBtn.Size = new System.Drawing.Size(75, 25);
            this.ileriBtn.TabIndex = 1;
            this.ileriBtn.Text = "Ileri";
            this.ileriBtn.UseVisualStyleBackColor = true;
            this.ileriBtn.Click += new System.EventHandler(this.ileriBtn_Click);
            // 
            // btnFikstur
            // 
            this.btnFikstur.Enabled = false;
            this.btnFikstur.Location = new System.Drawing.Point(73, 213);
            this.btnFikstur.Name = "btnFikstur";
            this.btnFikstur.Size = new System.Drawing.Size(100, 25);
            this.btnFikstur.TabIndex = 2;
            this.btnFikstur.Text = "Fikstürü Çek";
            this.btnFikstur.UseVisualStyleBackColor = true;
            this.btnFikstur.Visible = false;
            this.btnFikstur.Click += new System.EventHandler(this.btnFikstur_Click);
            // 
            // oyuncuIsimleriBtn
            // 
            this.oyuncuIsimleriBtn.Enabled = false;
            this.oyuncuIsimleriBtn.Location = new System.Drawing.Point(27, 147);
            this.oyuncuIsimleriBtn.Name = "oyuncuIsimleriBtn";
            this.oyuncuIsimleriBtn.Size = new System.Drawing.Size(200, 53);
            this.oyuncuIsimleriBtn.TabIndex = 3;
            this.oyuncuIsimleriBtn.Text = "Oyuncu İsimlerini Girdim";
            this.oyuncuIsimleriBtn.UseVisualStyleBackColor = true;
            this.oyuncuIsimleriBtn.Click += new System.EventHandler(this.oyuncuIsimleriBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 39);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Real Madrid";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 66);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 20);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Bayern";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(14, 93);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(52, 20);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "City";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(14, 119);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(88, 20);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Liverpool";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(135, 39);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(100, 20);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Manchester";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(135, 66);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 20);
            this.checkBox6.TabIndex = 13;
            this.checkBox6.Text = "Arsenal";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(135, 93);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(74, 20);
            this.checkBox7.TabIndex = 14;
            this.checkBox7.Text = "Chelsea";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(135, 119);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(89, 20);
            this.checkBox8.TabIndex = 15;
            this.checkBox8.Text = "Barcelona";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // ev1
            // 
            this.ev1.AutoSize = true;
            this.ev1.Location = new System.Drawing.Point(39, 37);
            this.ev1.Name = "ev1";
            this.ev1.Size = new System.Drawing.Size(30, 16);
            this.ev1.TabIndex = 16;
            this.ev1.Text = "ev1";
            // 
            // dep1
            // 
            this.dep1.AutoSize = true;
            this.dep1.Location = new System.Drawing.Point(237, 37);
            this.dep1.Name = "dep1";
            this.dep1.Size = new System.Drawing.Size(38, 16);
            this.dep1.TabIndex = 17;
            this.dep1.Text = "dep1";
            // 
            // ev2
            // 
            this.ev2.AutoSize = true;
            this.ev2.Location = new System.Drawing.Point(39, 72);
            this.ev2.Name = "ev2";
            this.ev2.Size = new System.Drawing.Size(31, 16);
            this.ev2.TabIndex = 18;
            this.ev2.Text = "ev2";
            // 
            // dep2
            // 
            this.dep2.AutoSize = true;
            this.dep2.Location = new System.Drawing.Point(236, 72);
            this.dep2.Name = "dep2";
            this.dep2.Size = new System.Drawing.Size(39, 16);
            this.dep2.TabIndex = 19;
            this.dep2.Text = "dep2";
            // 
            // ev3
            // 
            this.ev3.AutoSize = true;
            this.ev3.Location = new System.Drawing.Point(39, 110);
            this.ev3.Name = "ev3";
            this.ev3.Size = new System.Drawing.Size(31, 16);
            this.ev3.TabIndex = 20;
            this.ev3.Text = "ev3";
            // 
            // dep3
            // 
            this.dep3.AutoSize = true;
            this.dep3.Location = new System.Drawing.Point(237, 110);
            this.dep3.Name = "dep3";
            this.dep3.Size = new System.Drawing.Size(39, 16);
            this.dep3.TabIndex = 21;
            this.dep3.Text = "dep3";
            // 
            // ev4
            // 
            this.ev4.AutoSize = true;
            this.ev4.Location = new System.Drawing.Point(39, 148);
            this.ev4.Name = "ev4";
            this.ev4.Size = new System.Drawing.Size(31, 16);
            this.ev4.TabIndex = 22;
            this.ev4.Text = "ev4";
            // 
            // dep4
            // 
            this.dep4.AutoSize = true;
            this.dep4.Location = new System.Drawing.Point(236, 149);
            this.dep4.Name = "dep4";
            this.dep4.Size = new System.Drawing.Size(39, 16);
            this.dep4.TabIndex = 23;
            this.dep4.Text = "dep4";
            // 
            // ev5
            // 
            this.ev5.AutoSize = true;
            this.ev5.Location = new System.Drawing.Point(39, 187);
            this.ev5.Name = "ev5";
            this.ev5.Size = new System.Drawing.Size(31, 16);
            this.ev5.TabIndex = 24;
            this.ev5.Text = "ev5";
            // 
            // dep5
            // 
            this.dep5.AutoSize = true;
            this.dep5.Location = new System.Drawing.Point(237, 187);
            this.dep5.Name = "dep5";
            this.dep5.Size = new System.Drawing.Size(39, 16);
            this.dep5.TabIndex = 25;
            this.dep5.Text = "dep5";
            // 
            // ev6
            // 
            this.ev6.AutoSize = true;
            this.ev6.Location = new System.Drawing.Point(39, 226);
            this.ev6.Name = "ev6";
            this.ev6.Size = new System.Drawing.Size(31, 16);
            this.ev6.TabIndex = 26;
            this.ev6.Text = "ev6";
            // 
            // dep6
            // 
            this.dep6.AutoSize = true;
            this.dep6.Location = new System.Drawing.Point(236, 225);
            this.dep6.Name = "dep6";
            this.dep6.Size = new System.Drawing.Size(39, 16);
            this.dep6.TabIndex = 27;
            this.dep6.Text = "dep6";
            // 
            // mtb1
            // 
            this.mtb1.Enabled = false;
            this.mtb1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb1.Location = new System.Drawing.Point(112, 29);
            this.mtb1.Mask = "0";
            this.mtb1.Name = "mtb1";
            this.mtb1.Size = new System.Drawing.Size(22, 30);
            this.mtb1.TabIndex = 32;
            this.mtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb2
            // 
            this.mtb2.Enabled = false;
            this.mtb2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb2.Location = new System.Drawing.Point(181, 29);
            this.mtb2.Mask = "0";
            this.mtb2.Name = "mtb2";
            this.mtb2.Size = new System.Drawing.Size(22, 30);
            this.mtb2.TabIndex = 33;
            this.mtb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb3
            // 
            this.mtb3.Enabled = false;
            this.mtb3.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb3.Location = new System.Drawing.Point(112, 64);
            this.mtb3.Mask = "0";
            this.mtb3.Name = "mtb3";
            this.mtb3.Size = new System.Drawing.Size(22, 30);
            this.mtb3.TabIndex = 35;
            this.mtb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb4
            // 
            this.mtb4.Enabled = false;
            this.mtb4.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb4.Location = new System.Drawing.Point(181, 64);
            this.mtb4.Mask = "0";
            this.mtb4.Name = "mtb4";
            this.mtb4.Size = new System.Drawing.Size(22, 30);
            this.mtb4.TabIndex = 36;
            this.mtb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb5
            // 
            this.mtb5.Enabled = false;
            this.mtb5.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb5.Location = new System.Drawing.Point(112, 102);
            this.mtb5.Mask = "0";
            this.mtb5.Name = "mtb5";
            this.mtb5.Size = new System.Drawing.Size(22, 30);
            this.mtb5.TabIndex = 38;
            this.mtb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb6
            // 
            this.mtb6.Enabled = false;
            this.mtb6.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb6.Location = new System.Drawing.Point(181, 102);
            this.mtb6.Mask = "0";
            this.mtb6.Name = "mtb6";
            this.mtb6.Size = new System.Drawing.Size(22, 30);
            this.mtb6.TabIndex = 39;
            this.mtb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb7
            // 
            this.mtb7.Enabled = false;
            this.mtb7.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb7.Location = new System.Drawing.Point(112, 141);
            this.mtb7.Mask = "0";
            this.mtb7.Name = "mtb7";
            this.mtb7.Size = new System.Drawing.Size(22, 30);
            this.mtb7.TabIndex = 41;
            this.mtb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb8
            // 
            this.mtb8.Enabled = false;
            this.mtb8.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb8.Location = new System.Drawing.Point(181, 141);
            this.mtb8.Mask = "0";
            this.mtb8.Name = "mtb8";
            this.mtb8.Size = new System.Drawing.Size(22, 30);
            this.mtb8.TabIndex = 42;
            this.mtb8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb9
            // 
            this.mtb9.Enabled = false;
            this.mtb9.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb9.Location = new System.Drawing.Point(112, 179);
            this.mtb9.Mask = "0";
            this.mtb9.Name = "mtb9";
            this.mtb9.Size = new System.Drawing.Size(22, 30);
            this.mtb9.TabIndex = 44;
            this.mtb9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb10
            // 
            this.mtb10.Enabled = false;
            this.mtb10.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb10.Location = new System.Drawing.Point(181, 179);
            this.mtb10.Mask = "0";
            this.mtb10.Name = "mtb10";
            this.mtb10.Size = new System.Drawing.Size(22, 30);
            this.mtb10.TabIndex = 45;
            this.mtb10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb11
            // 
            this.mtb11.Enabled = false;
            this.mtb11.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb11.Location = new System.Drawing.Point(112, 218);
            this.mtb11.Mask = "0";
            this.mtb11.Name = "mtb11";
            this.mtb11.Size = new System.Drawing.Size(22, 30);
            this.mtb11.TabIndex = 47;
            this.mtb11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtb12
            // 
            this.mtb12.Enabled = false;
            this.mtb12.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb12.Location = new System.Drawing.Point(181, 218);
            this.mtb12.Mask = "0";
            this.mtb12.Name = "mtb12";
            this.mtb12.Size = new System.Drawing.Size(22, 30);
            this.mtb12.TabIndex = 48;
            this.mtb12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guncelle1Btn
            // 
            this.guncelle1Btn.Enabled = false;
            this.guncelle1Btn.Location = new System.Drawing.Point(338, 28);
            this.guncelle1Btn.Name = "guncelle1Btn";
            this.guncelle1Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle1Btn.TabIndex = 34;
            this.guncelle1Btn.Text = "Puanları Güncelle";
            this.guncelle1Btn.UseVisualStyleBackColor = true;
            this.guncelle1Btn.Click += new System.EventHandler(this.guncelle1Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 16);
            this.label6.TabIndex = 46;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 16);
            this.label7.TabIndex = 47;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 16);
            this.label8.TabIndex = 48;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 49;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 50;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 16);
            this.label11.TabIndex = 51;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 52;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(165, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 53;
            this.label13.Text = "PUAN";
            // 
            // puandurumuGBox
            // 
            this.puandurumuGBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.puandurumuGBox.Controls.Add(this.label19);
            this.puandurumuGBox.Controls.Add(this.label18);
            this.puandurumuGBox.Controls.Add(this.label17);
            this.puandurumuGBox.Controls.Add(this.label16);
            this.puandurumuGBox.Controls.Add(this.label15);
            this.puandurumuGBox.Controls.Add(this.zaferTBox);
            this.puandurumuGBox.Controls.Add(this.AVERAJ);
            this.puandurumuGBox.Controls.Add(this.label4);
            this.puandurumuGBox.Controls.Add(this.label3);
            this.puandurumuGBox.Controls.Add(this.label2);
            this.puandurumuGBox.Controls.Add(this.label1);
            this.puandurumuGBox.Controls.Add(this.label14);
            this.puandurumuGBox.Controls.Add(this.label8);
            this.puandurumuGBox.Controls.Add(this.label13);
            this.puandurumuGBox.Controls.Add(this.label5);
            this.puandurumuGBox.Controls.Add(this.label12);
            this.puandurumuGBox.Controls.Add(this.label6);
            this.puandurumuGBox.Controls.Add(this.label11);
            this.puandurumuGBox.Controls.Add(this.label7);
            this.puandurumuGBox.Controls.Add(this.label10);
            this.puandurumuGBox.Controls.Add(this.label9);
            this.puandurumuGBox.Location = new System.Drawing.Point(518, 297);
            this.puandurumuGBox.Name = "puandurumuGBox";
            this.puandurumuGBox.Size = new System.Drawing.Size(403, 320);
            this.puandurumuGBox.TabIndex = 54;
            this.puandurumuGBox.TabStop = false;
            this.puandurumuGBox.Text = "Puan Durumu";
            this.puandurumuGBox.Visible = false;
            // 
            // zaferTBox
            // 
            this.zaferTBox.Enabled = false;
            this.zaferTBox.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zaferTBox.Location = new System.Drawing.Point(59, 258);
            this.zaferTBox.Name = "zaferTBox";
            this.zaferTBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.zaferTBox.Size = new System.Drawing.Size(224, 31);
            this.zaferTBox.TabIndex = 60;
            this.zaferTBox.Visible = false;
            // 
            // AVERAJ
            // 
            this.AVERAJ.AutoSize = true;
            this.AVERAJ.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVERAJ.Location = new System.Drawing.Point(234, 27);
            this.AVERAJ.Name = "AVERAJ";
            this.AVERAJ.Size = new System.Drawing.Size(73, 18);
            this.AVERAJ.TabIndex = 59;
            this.AVERAJ.Text = "AVERAJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(43, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 18);
            this.label14.TabIndex = 54;
            this.label14.Text = "OYUNCU";
            // 
            // fiksturGBox
            // 
            this.fiksturGBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fiksturGBox.Controls.Add(this.guncelle6Btn);
            this.fiksturGBox.Controls.Add(this.guncelle5Btn);
            this.fiksturGBox.Controls.Add(this.guncelle4Btn);
            this.fiksturGBox.Controls.Add(this.guncelle3Btn);
            this.fiksturGBox.Controls.Add(this.guncelle2Btn);
            this.fiksturGBox.Controls.Add(this.guncelle1Btn);
            this.fiksturGBox.Controls.Add(this.ev1);
            this.fiksturGBox.Controls.Add(this.dep1);
            this.fiksturGBox.Controls.Add(this.mtb12);
            this.fiksturGBox.Controls.Add(this.ev2);
            this.fiksturGBox.Controls.Add(this.mtb11);
            this.fiksturGBox.Controls.Add(this.dep2);
            this.fiksturGBox.Controls.Add(this.mtb10);
            this.fiksturGBox.Controls.Add(this.ev3);
            this.fiksturGBox.Controls.Add(this.mtb9);
            this.fiksturGBox.Controls.Add(this.dep3);
            this.fiksturGBox.Controls.Add(this.mtb8);
            this.fiksturGBox.Controls.Add(this.ev4);
            this.fiksturGBox.Controls.Add(this.mtb7);
            this.fiksturGBox.Controls.Add(this.dep4);
            this.fiksturGBox.Controls.Add(this.mtb6);
            this.fiksturGBox.Controls.Add(this.ev5);
            this.fiksturGBox.Controls.Add(this.mtb5);
            this.fiksturGBox.Controls.Add(this.dep5);
            this.fiksturGBox.Controls.Add(this.mtb4);
            this.fiksturGBox.Controls.Add(this.ev6);
            this.fiksturGBox.Controls.Add(this.mtb3);
            this.fiksturGBox.Controls.Add(this.dep6);
            this.fiksturGBox.Controls.Add(this.mtb2);
            this.fiksturGBox.Controls.Add(this.mtb1);
            this.fiksturGBox.Location = new System.Drawing.Point(12, 297);
            this.fiksturGBox.Name = "fiksturGBox";
            this.fiksturGBox.Size = new System.Drawing.Size(500, 320);
            this.fiksturGBox.TabIndex = 55;
            this.fiksturGBox.TabStop = false;
            this.fiksturGBox.Text = "Fikstür";
            this.fiksturGBox.Visible = false;
            // 
            // guncelle6Btn
            // 
            this.guncelle6Btn.Location = new System.Drawing.Point(338, 225);
            this.guncelle6Btn.Name = "guncelle6Btn";
            this.guncelle6Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle6Btn.TabIndex = 49;
            this.guncelle6Btn.Text = "Puanları Güncelle";
            this.guncelle6Btn.UseVisualStyleBackColor = true;
            this.guncelle6Btn.Click += new System.EventHandler(this.guncelle6Btn_Click);
            // 
            // guncelle5Btn
            // 
            this.guncelle5Btn.Location = new System.Drawing.Point(338, 187);
            this.guncelle5Btn.Name = "guncelle5Btn";
            this.guncelle5Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle5Btn.TabIndex = 46;
            this.guncelle5Btn.Text = "Puanları Güncelle";
            this.guncelle5Btn.UseVisualStyleBackColor = true;
            this.guncelle5Btn.Click += new System.EventHandler(this.guncelle5Btn_Click);
            // 
            // guncelle4Btn
            // 
            this.guncelle4Btn.Location = new System.Drawing.Point(338, 148);
            this.guncelle4Btn.Name = "guncelle4Btn";
            this.guncelle4Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle4Btn.TabIndex = 43;
            this.guncelle4Btn.Text = "Puanları Güncelle";
            this.guncelle4Btn.UseVisualStyleBackColor = true;
            this.guncelle4Btn.Click += new System.EventHandler(this.guncelle4Btn_Click);
            // 
            // guncelle3Btn
            // 
            this.guncelle3Btn.Location = new System.Drawing.Point(338, 103);
            this.guncelle3Btn.Name = "guncelle3Btn";
            this.guncelle3Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle3Btn.TabIndex = 40;
            this.guncelle3Btn.Text = "Puanları Güncelle";
            this.guncelle3Btn.UseVisualStyleBackColor = true;
            this.guncelle3Btn.Click += new System.EventHandler(this.guncelle3Btn_Click);
            // 
            // guncelle2Btn
            // 
            this.guncelle2Btn.Location = new System.Drawing.Point(338, 64);
            this.guncelle2Btn.Name = "guncelle2Btn";
            this.guncelle2Btn.Size = new System.Drawing.Size(129, 33);
            this.guncelle2Btn.TabIndex = 37;
            this.guncelle2Btn.Text = "Puanları Güncelle";
            this.guncelle2Btn.UseVisualStyleBackColor = true;
            this.guncelle2Btn.Click += new System.EventHandler(this.guncelle2Btn_Click);
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(73, 28);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 56;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(73, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 57;
            this.textBox6.Visible = false;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(73, 84);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 58;
            this.textBox7.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(73, 115);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 59;
            this.textBox8.Visible = false;
            // 
            // ileri2Btn
            // 
            this.ileri2Btn.Enabled = false;
            this.ileri2Btn.Location = new System.Drawing.Point(89, 213);
            this.ileri2Btn.Name = "ileri2Btn";
            this.ileri2Btn.Size = new System.Drawing.Size(75, 25);
            this.ileri2Btn.TabIndex = 60;
            this.ileri2Btn.Text = "Ileri";
            this.ileri2Btn.UseVisualStyleBackColor = true;
            this.ileri2Btn.Click += new System.EventHandler(this.ileri2Btn_Click);
            // 
            // sonGBox
            // 
            this.sonGBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sonGBox.Controls.Add(this.btnFikstur);
            this.sonGBox.Controls.Add(this.textBox8);
            this.sonGBox.Controls.Add(this.textBox5);
            this.sonGBox.Controls.Add(this.textBox7);
            this.sonGBox.Controls.Add(this.textBox6);
            this.sonGBox.Location = new System.Drawing.Point(593, 13);
            this.sonGBox.Name = "sonGBox";
            this.sonGBox.Size = new System.Drawing.Size(275, 267);
            this.sonGBox.TabIndex = 61;
            this.sonGBox.TabStop = false;
            this.sonGBox.Text = "Takımlar";
            // 
            // oyuncuGBox
            // 
            this.oyuncuGBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.oyuncuGBox.Controls.Add(this.textBox4);
            this.oyuncuGBox.Controls.Add(this.textBox3);
            this.oyuncuGBox.Controls.Add(this.textBox2);
            this.oyuncuGBox.Controls.Add(this.textBox1);
            this.oyuncuGBox.Controls.Add(this.ileri2Btn);
            this.oyuncuGBox.Controls.Add(this.oyuncuIsimleriBtn);
            this.oyuncuGBox.Location = new System.Drawing.Point(302, 13);
            this.oyuncuGBox.Name = "oyuncuGBox";
            this.oyuncuGBox.Size = new System.Drawing.Size(275, 267);
            this.oyuncuGBox.TabIndex = 62;
            this.oyuncuGBox.TabStop = false;
            this.oyuncuGBox.Text = "Oyuncu İsimleri";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(77, 112);
            this.textBox4.Mask = "aaaaaaaa";
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 64;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(77, 84);
            this.textBox3.Mask = "aaaaaaaa";
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 57);
            this.textBox2.Mask = "aaaaaaaa";
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 62;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 29);
            this.textBox1.Mask = "aaaaaaaa";
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 61;
            // 
            // takimSecimiGBox
            // 
            this.takimSecimiGBox.BackColor = System.Drawing.Color.LightSkyBlue;
            this.takimSecimiGBox.Controls.Add(this.button1);
            this.takimSecimiGBox.Controls.Add(this.ileriBtn);
            this.takimSecimiGBox.Controls.Add(this.checkBox1);
            this.takimSecimiGBox.Controls.Add(this.checkBox2);
            this.takimSecimiGBox.Controls.Add(this.checkBox3);
            this.takimSecimiGBox.Controls.Add(this.checkBox8);
            this.takimSecimiGBox.Controls.Add(this.checkBox4);
            this.takimSecimiGBox.Controls.Add(this.checkBox7);
            this.takimSecimiGBox.Controls.Add(this.checkBox5);
            this.takimSecimiGBox.Controls.Add(this.checkBox6);
            this.takimSecimiGBox.Location = new System.Drawing.Point(12, 13);
            this.takimSecimiGBox.Name = "takimSecimiGBox";
            this.takimSecimiGBox.Size = new System.Drawing.Size(275, 267);
            this.takimSecimiGBox.TabIndex = 63;
            this.takimSecimiGBox.TabStop = false;
            this.takimSecimiGBox.Text = "Takım Seçimi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Lucida Bright", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(316, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 18);
            this.label15.TabIndex = 61;
            this.label15.Text = "İKİLİ AVR";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(335, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 16);
            this.label16.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(334, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 63;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(334, 162);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 16);
            this.label18.TabIndex = 64;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(334, 211);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 16);
            this.label19.TabIndex = 65;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(811, 631);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(110, 41);
            this.exitBtn.TabIndex = 640;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(933, 676);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.takimSecimiGBox);
            this.Controls.Add(this.oyuncuGBox);
            this.Controls.Add(this.sonGBox);
            this.Controls.Add(this.fiksturGBox);
            this.Controls.Add(this.puandurumuGBox);
            this.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Turnuva";
            this.puandurumuGBox.ResumeLayout(false);
            this.puandurumuGBox.PerformLayout();
            this.fiksturGBox.ResumeLayout(false);
            this.fiksturGBox.PerformLayout();
            this.sonGBox.ResumeLayout(false);
            this.sonGBox.PerformLayout();
            this.oyuncuGBox.ResumeLayout(false);
            this.oyuncuGBox.PerformLayout();
            this.takimSecimiGBox.ResumeLayout(false);
            this.takimSecimiGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ileriBtn;
        private System.Windows.Forms.Button btnFikstur;
        private System.Windows.Forms.Button oyuncuIsimleriBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label ev1;
        private System.Windows.Forms.Label dep1;
        private System.Windows.Forms.Label ev2;
        private System.Windows.Forms.Label dep2;
        private System.Windows.Forms.Label ev3;
        private System.Windows.Forms.Label dep3;
        private System.Windows.Forms.Label ev4;
        private System.Windows.Forms.Label dep4;
        private System.Windows.Forms.Label ev5;
        private System.Windows.Forms.Label dep5;
        private System.Windows.Forms.Label ev6;
        private System.Windows.Forms.Label dep6;
        private System.Windows.Forms.MaskedTextBox mtb1;
        private System.Windows.Forms.MaskedTextBox mtb2;
        private System.Windows.Forms.MaskedTextBox mtb3;
        private System.Windows.Forms.MaskedTextBox mtb4;
        private System.Windows.Forms.MaskedTextBox mtb5;
        private System.Windows.Forms.MaskedTextBox mtb6;
        private System.Windows.Forms.MaskedTextBox mtb7;
        private System.Windows.Forms.MaskedTextBox mtb8;
        private System.Windows.Forms.MaskedTextBox mtb9;
        private System.Windows.Forms.MaskedTextBox mtb10;
        private System.Windows.Forms.MaskedTextBox mtb11;
        private System.Windows.Forms.MaskedTextBox mtb12;
        private System.Windows.Forms.Button guncelle1Btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox puandurumuGBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox fiksturGBox;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button ileri2Btn;
        private System.Windows.Forms.GroupBox sonGBox;
        private System.Windows.Forms.GroupBox oyuncuGBox;
        private System.Windows.Forms.GroupBox takimSecimiGBox;
        private System.Windows.Forms.Button guncelle2Btn;
        private System.Windows.Forms.Button guncelle6Btn;
        private System.Windows.Forms.Button guncelle5Btn;
        private System.Windows.Forms.Button guncelle4Btn;
        private System.Windows.Forms.Button guncelle3Btn;
        private System.Windows.Forms.Label AVERAJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zaferTBox;
        private System.Windows.Forms.MaskedTextBox textBox4;
        private System.Windows.Forms.MaskedTextBox textBox3;
        private System.Windows.Forms.MaskedTextBox textBox2;
        private System.Windows.Forms.MaskedTextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button exitBtn;
    }
}

