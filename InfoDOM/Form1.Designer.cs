namespace InfoDOM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loaudBD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deletOldBD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StartParsing = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2Domu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m2Działka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lokalizacja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOtodom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlPokojów = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsfDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaBDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsfDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loaudBD
            // 
            this.loaudBD.Location = new System.Drawing.Point(698, 8);
            this.loaudBD.Name = "loaudBD";
            this.loaudBD.Size = new System.Drawing.Size(75, 23);
            this.loaudBD.TabIndex = 5;
            this.loaudBD.Text = "Odśwież";
            this.loaudBD.UseVisualStyleBackColor = true;
            this.loaudBD.Click += new System.EventHandler(this.loaudBD_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.deletOldBD);
            this.panel1.Controls.Add(this.loaudBD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.StartParsing);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Location = new System.Drawing.Point(-38, 502);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 38);
            this.panel1.TabIndex = 5;
            // 
            // deletOldBD
            // 
            this.deletOldBD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletOldBD.Location = new System.Drawing.Point(579, 8);
            this.deletOldBD.Name = "deletOldBD";
            this.deletOldBD.Size = new System.Drawing.Size(102, 23);
            this.deletOldBD.TabIndex = 22;
            this.deletOldBD.Text = "Usuń starą baze";
            this.deletOldBD.UseVisualStyleBackColor = true;
            this.deletOldBD.Click += new System.EventHandler(this.deletOldBD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // StartParsing
            // 
            this.StartParsing.Location = new System.Drawing.Point(797, 8);
            this.StartParsing.Name = "StartParsing";
            this.StartParsing.Size = new System.Drawing.Size(80, 23);
            this.StartParsing.TabIndex = 3;
            this.StartParsing.Text = "Start Parsing";
            this.StartParsing.UseVisualStyleBackColor = true;
            this.StartParsing.Click += new System.EventHandler(this.StartParsing_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(898, 8);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "EXIT";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.m2Domu,
            this.m2Działka,
            this.Cena,
            this.Lokalizacja,
            this.idOtodom,
            this.IlPokojów,
            this.list});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView.Location = new System.Drawing.Point(1, 1);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(950, 495);
            this.dataGridView.TabIndex = 8;
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
            this.m2Domu.HeaderText = "m2Domu";
            this.m2Domu.Name = "m2Domu";
            // 
            // m2Działka
            // 
            this.m2Działka.HeaderText = "m2Działka";
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
            this.idOtodom.HeaderText = "idOtodom";
            this.idOtodom.Name = "idOtodom";
            // 
            // IlPokojów
            // 
            this.IlPokojów.HeaderText = "IlPokojów";
            this.IlPokojów.Name = "IlPokojów";
            // 
            // list
            // 
            this.list.HeaderText = "List";
            this.list.Name = "list";
            // 
            // bazaBDBindingSource
            // 
            this.bazaBDBindingSource.DataMember = "BazaBD";
            this.bazaBDBindingSource.DataSource = this.dsfDataSetBindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 540);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsfDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaBDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loaudBD;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartParsing;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button deletOldBD;
        public System.Windows.Forms.DataGridView dataGridView;    
        private System.Windows.Forms.BindingSource dsfDataSetBindingSource;
        private System.Windows.Forms.BindingSource bazaBDBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2Domu;
        private System.Windows.Forms.DataGridViewTextBoxColumn m2Działka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lokalizacja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOtodom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlPokojów;
        private System.Windows.Forms.DataGridViewTextBoxColumn list;
    }
}