namespace InfoDOM
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2Domu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2Działka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokalizacja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOtodom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iliscPokoji = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CenaM2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIT = new System.Windows.Forms.Button();
            this.startparsing = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AdressWWW = new System.Windows.Forms.TextBox();
            this.wwwPag = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CodeBlockHtml1 = new System.Windows.Forms.TextBox();
            this.CodeBlockHtml2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1_2 = new System.Windows.Forms.TextBox();
            this.textBox1_1 = new System.Windows.Forms.TextBox();
            this.textBox2_2 = new System.Windows.Forms.TextBox();
            this.textBox2_1 = new System.Windows.Forms.TextBox();
            this.textBox3_2 = new System.Windows.Forms.TextBox();
            this.textBox3_1 = new System.Windows.Forms.TextBox();
            this.textBox4_2 = new System.Windows.Forms.TextBox();
            this.textBox4_1 = new System.Windows.Forms.TextBox();
            this.textBox5_2 = new System.Windows.Forms.TextBox();
            this.textBox5_1 = new System.Windows.Forms.TextBox();
            this.textBox6_2 = new System.Windows.Forms.TextBox();
            this.textBox6_1 = new System.Windows.Forms.TextBox();
            this.textBox7_2 = new System.Windows.Forms.TextBox();
            this.textBox7_1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.m2Domu,
            this.m2Działka,
            this.Cena,
            this.Lokalizacja,
            this.idOtodom,
            this.iliscPokoji,
            this.CenaM2});
            this.dataGridView1.Location = new System.Drawing.Point(13, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(943, 224);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // m2Domu
            // 
            this.m2Domu.HeaderText = "m2 Domu";
            this.m2Domu.Name = "m2Domu";
            // 
            // m2Działka
            // 
            this.m2Działka.HeaderText = "m2 Działka";
            this.m2Działka.Name = "m2Działka";
            // 
            // Cena
            // 
            this.Cena.HeaderText = "Cena";
            this.Cena.Name = "Cena";
            // 
            // Lokalizacja
            // 
            this.Lokalizacja.HeaderText = "Lokalizacja";
            this.Lokalizacja.Name = "Lokalizacja";
            // 
            // idOtodom
            // 
            this.idOtodom.HeaderText = "id Otodom";
            this.idOtodom.Name = "idOtodom";
            // 
            // iliscPokoji
            // 
            this.iliscPokoji.HeaderText = "ilisc Pokoji";
            this.iliscPokoji.Name = "iliscPokoji";
            // 
            // CenaM2
            // 
            this.CenaM2.HeaderText = "Cena/m2";
            this.CenaM2.Name = "CenaM2";
            // 
            // EXIT
            // 
            this.EXIT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EXIT.Location = new System.Drawing.Point(881, 482);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(75, 23);
            this.EXIT.TabIndex = 1;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = true;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // startparsing
            // 
            this.startparsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.startparsing.Location = new System.Drawing.Point(800, 482);
            this.startparsing.Name = "startparsing";
            this.startparsing.Size = new System.Drawing.Size(75, 23);
            this.startparsing.TabIndex = 2;
            this.startparsing.Text = "Start Parsing";
            this.startparsing.UseVisualStyleBackColor = true;
            this.startparsing.Click += new System.EventHandler(this.startparsing_Click);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Location = new System.Drawing.Point(719, 482);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Odśwież";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // AdressWWW
            // 
            this.AdressWWW.Location = new System.Drawing.Point(13, 22);
            this.AdressWWW.Name = "AdressWWW";
            this.AdressWWW.Size = new System.Drawing.Size(862, 20);
            this.AdressWWW.TabIndex = 5;
            this.AdressWWW.Text = "https://www.otodom.pl/sprzedaz/dom/warszawa/?search%5Bfilter_float_m%3Ato%5D=500&" +
    "search%5Bdescription%5D=1&search%5Bdist%5D=25&search%5Bsubregion_id%5D=197&searc" +
    "h%5Bcity_id%5D=26&page=";
            this.AdressWWW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdressWWW_KeyDown);
            // 
            // wwwPag
            // 
            this.wwwPag.Location = new System.Drawing.Point(880, 21);
            this.wwwPag.Name = "wwwPag";
            this.wwwPag.Size = new System.Drawing.Size(75, 20);
            this.wwwPag.TabIndex = 6;
            this.wwwPag.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adress www";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(872, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adress www enum";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Code block html";
            // 
            // CodeBlockHtml1
            // 
            this.CodeBlockHtml1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeBlockHtml1.Location = new System.Drawing.Point(99, 288);
            this.CodeBlockHtml1.Name = "CodeBlockHtml1";
            this.CodeBlockHtml1.Size = new System.Drawing.Size(347, 20);
            this.CodeBlockHtml1.TabIndex = 10;
            this.CodeBlockHtml1.Text = "<div class=\"offer-item-details\">";
            // 
            // CodeBlockHtml2
            // 
            this.CodeBlockHtml2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeBlockHtml2.Location = new System.Drawing.Point(452, 288);
            this.CodeBlockHtml2.Name = "CodeBlockHtml2";
            this.CodeBlockHtml2.Size = new System.Drawing.Size(446, 20);
            this.CodeBlockHtml2.TabIndex = 11;
            this.CodeBlockHtml2.Text = "<div class=\"offer-item-details-bottom\" data-tracking=\"click_body\" data-tracking-d" +
    "ata=";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pole 1";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pole 2";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pole 3";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Pole 4";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 402);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pole 5";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 424);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pole 6";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Pole 7";
            // 
            // textBox1_2
            // 
            this.textBox1_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_2.Location = new System.Drawing.Point(452, 310);
            this.textBox1_2.Name = "textBox1_2";
            this.textBox1_2.Size = new System.Drawing.Size(446, 20);
            this.textBox1_2.TabIndex = 21;
            this.textBox1_2.Text = "</span>";
            // 
            // textBox1_1
            // 
            this.textBox1_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1_1.Location = new System.Drawing.Point(99, 310);
            this.textBox1_1.Name = "textBox1_1";
            this.textBox1_1.Size = new System.Drawing.Size(347, 20);
            this.textBox1_1.TabIndex = 20;
            this.textBox1_1.Text = "<span class=\"offer-item-title\">";
            // 
            // textBox2_2
            // 
            this.textBox2_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_2.Location = new System.Drawing.Point(452, 332);
            this.textBox2_2.Name = "textBox2_2";
            this.textBox2_2.Size = new System.Drawing.Size(446, 20);
            this.textBox2_2.TabIndex = 23;
            this.textBox2_2.Text = "\\s+m²</strong>";
            // 
            // textBox2_1
            // 
            this.textBox2_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2_1.Location = new System.Drawing.Point(99, 332);
            this.textBox2_1.Name = "textBox2_1";
            this.textBox2_1.Size = new System.Drawing.Size(347, 20);
            this.textBox2_1.TabIndex = 22;
            this.textBox2_1.Text = "<strong class=\"visible-xs-block\">";
            // 
            // textBox3_2
            // 
            this.textBox3_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_2.Location = new System.Drawing.Point(452, 354);
            this.textBox3_2.Name = "textBox3_2";
            this.textBox3_2.Size = new System.Drawing.Size(446, 20);
            this.textBox3_2.TabIndex = 25;
            this.textBox3_2.Text = "</li>";
            // 
            // textBox3_1
            // 
            this.textBox3_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3_1.Location = new System.Drawing.Point(99, 354);
            this.textBox3_1.Name = "textBox3_1";
            this.textBox3_1.Size = new System.Drawing.Size(347, 20);
            this.textBox3_1.TabIndex = 24;
            this.textBox3_1.Text = "<li class=\"hidden-xs offer-item-area\">działka ";
            // 
            // textBox4_2
            // 
            this.textBox4_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4_2.Location = new System.Drawing.Point(452, 376);
            this.textBox4_2.Name = "textBox4_2";
            this.textBox4_2.Size = new System.Drawing.Size(446, 20);
            this.textBox4_2.TabIndex = 27;
            this.textBox4_2.Text = "\\s</li>";
            // 
            // textBox4_1
            // 
            this.textBox4_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4_1.Location = new System.Drawing.Point(99, 376);
            this.textBox4_1.Name = "textBox4_1";
            this.textBox4_1.Size = new System.Drawing.Size(347, 20);
            this.textBox4_1.TabIndex = 26;
            this.textBox4_1.Text = "<li class=\"offer-item-price\">\\s+";
            // 
            // textBox5_2
            // 
            this.textBox5_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5_2.Location = new System.Drawing.Point(452, 398);
            this.textBox5_2.Name = "textBox5_2";
            this.textBox5_2.Size = new System.Drawing.Size(446, 20);
            this.textBox5_2.TabIndex = 29;
            this.textBox5_2.Text = "</p>";
            // 
            // textBox5_1
            // 
            this.textBox5_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5_1.Location = new System.Drawing.Point(99, 398);
            this.textBox5_1.Name = "textBox5_1";
            this.textBox5_1.Size = new System.Drawing.Size(347, 20);
            this.textBox5_1.TabIndex = 28;
            this.textBox5_1.Text = "<span class=\"hidden-xs\">Dom na sprzedaż: </span>";
            // 
            // textBox6_2
            // 
            this.textBox6_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6_2.Location = new System.Drawing.Point(452, 420);
            this.textBox6_2.Name = "textBox6_2";
            this.textBox6_2.Size = new System.Drawing.Size(446, 20);
            this.textBox6_2.TabIndex = 31;
            this.textBox6_2.Text = "\" href=\"#\">";
            // 
            // textBox6_1
            // 
            this.textBox6_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6_1.Location = new System.Drawing.Point(99, 420);
            this.textBox6_1.Name = "textBox6_1";
            this.textBox6_1.Size = new System.Drawing.Size(347, 20);
            this.textBox6_1.TabIndex = 30;
            this.textBox6_1.Text = "data-id=\"";
            // 
            // textBox7_2
            // 
            this.textBox7_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7_2.Location = new System.Drawing.Point(452, 442);
            this.textBox7_2.Name = "textBox7_2";
            this.textBox7_2.Size = new System.Drawing.Size(446, 20);
            this.textBox7_2.TabIndex = 33;
            this.textBox7_2.Text = "</li>";
            // 
            // textBox7_1
            // 
            this.textBox7_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7_1.Location = new System.Drawing.Point(99, 442);
            this.textBox7_1.Name = "textBox7_1";
            this.textBox7_1.Size = new System.Drawing.Size(347, 20);
            this.textBox7_1.TabIndex = 32;
            this.textBox7_1.Text = "<li class=\"offer-item-rooms hidden-xs\">";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 510);
            this.Controls.Add(this.textBox7_2);
            this.Controls.Add(this.textBox7_1);
            this.Controls.Add(this.textBox6_2);
            this.Controls.Add(this.textBox6_1);
            this.Controls.Add(this.textBox5_2);
            this.Controls.Add(this.textBox5_1);
            this.Controls.Add(this.textBox4_2);
            this.Controls.Add(this.textBox4_1);
            this.Controls.Add(this.textBox3_2);
            this.Controls.Add(this.textBox3_1);
            this.Controls.Add(this.textBox2_2);
            this.Controls.Add(this.textBox2_1);
            this.Controls.Add(this.textBox1_2);
            this.Controls.Add(this.textBox1_1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CodeBlockHtml2);
            this.Controls.Add(this.CodeBlockHtml1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wwwPag);
            this.Controls.Add(this.AdressWWW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.startparsing);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2Domu;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2Działka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokalizacja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtodom;
        private System.Windows.Forms.DataGridViewTextBoxColumn iliscPokoji;
        private System.Windows.Forms.DataGridViewTextBoxColumn CenaM2;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button startparsing;
        private new System.Windows.Forms.Button Refresh;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox AdressWWW;
        public System.Windows.Forms.TextBox wwwPag;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox CodeBlockHtml1;
        public System.Windows.Forms.TextBox CodeBlockHtml2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox textBox1_2;
        public System.Windows.Forms.TextBox textBox1_1;
        public System.Windows.Forms.TextBox textBox2_2;
        public System.Windows.Forms.TextBox textBox2_1;
        public System.Windows.Forms.TextBox textBox3_2;
        public System.Windows.Forms.TextBox textBox3_1;
        public System.Windows.Forms.TextBox textBox4_2;
        public System.Windows.Forms.TextBox textBox4_1;
        public System.Windows.Forms.TextBox textBox5_2;
        public System.Windows.Forms.TextBox textBox5_1;
        public System.Windows.Forms.TextBox textBox6_2;
        public System.Windows.Forms.TextBox textBox6_1;
        public System.Windows.Forms.TextBox textBox7_2;
        public System.Windows.Forms.TextBox textBox7_1;
    }

}