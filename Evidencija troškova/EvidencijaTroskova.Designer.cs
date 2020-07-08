namespace Evidencija_troškova
{
    partial class EvidencijaTroskova
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
            this.lbPrikazTroskova = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbStanjeNaRacunu = new System.Windows.Forms.Label();
            this.btnProvjeriStanje = new System.Windows.Forms.Button();
            this.GridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrikaziGraf = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrikazTroskova
            // 
            this.lbPrikazTroskova.AutoSize = true;
            this.lbPrikazTroskova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbPrikazTroskova.Location = new System.Drawing.Point(34, 61);
            this.lbPrikazTroskova.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrikazTroskova.Name = "lbPrikazTroskova";
            this.lbPrikazTroskova.Size = new System.Drawing.Size(110, 17);
            this.lbPrikazTroskova.TabIndex = 0;
            this.lbPrikazTroskova.Text = "*Prikaz troškova";
            this.lbPrikazTroskova.Click += new System.EventHandler(this.LbPrikazTroskova_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox1.Location = new System.Drawing.Point(235, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lbStanjeNaRacunu
            // 
            this.lbStanjeNaRacunu.AutoSize = true;
            this.lbStanjeNaRacunu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbStanjeNaRacunu.Location = new System.Drawing.Point(34, 25);
            this.lbStanjeNaRacunu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStanjeNaRacunu.Name = "lbStanjeNaRacunu";
            this.lbStanjeNaRacunu.Size = new System.Drawing.Size(184, 17);
            this.lbStanjeNaRacunu.TabIndex = 2;
            this.lbStanjeNaRacunu.Text = "Trenutno stanje na računu :";
            // 
            // btnProvjeriStanje
            // 
            this.btnProvjeriStanje.Location = new System.Drawing.Point(377, 21);
            this.btnProvjeriStanje.Margin = new System.Windows.Forms.Padding(2);
            this.btnProvjeriStanje.Name = "btnProvjeriStanje";
            this.btnProvjeriStanje.Size = new System.Drawing.Size(65, 29);
            this.btnProvjeriStanje.TabIndex = 3;
            this.btnProvjeriStanje.Text = "Provjeri";
            this.btnProvjeriStanje.UseVisualStyleBackColor = true;
            this.btnProvjeriStanje.Click += new System.EventHandler(this.BtnProvjeriStanje_Click);
            // 
            // GridView1
            // 
            this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView1.Location = new System.Drawing.Point(37, 80);
            this.GridView1.Margin = new System.Windows.Forms.Padding(2);
            this.GridView1.Name = "GridView1";
            this.GridView1.RowTemplate.Height = 24;
            this.GridView1.Size = new System.Drawing.Size(268, 214);
            this.GridView1.TabIndex = 5;
            // 
            // btnPrikaziGraf
            // 
            this.btnPrikaziGraf.Location = new System.Drawing.Point(469, 265);
            this.btnPrikaziGraf.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziGraf.Name = "btnPrikaziGraf";
            this.btnPrikaziGraf.Size = new System.Drawing.Size(107, 29);
            this.btnPrikaziGraf.TabIndex = 7;
            this.btnPrikaziGraf.Text = "Prikazi Graf";
            this.btnPrikaziGraf.UseVisualStyleBackColor = true;
            this.btnPrikaziGraf.Click += new System.EventHandler(this.BtnPrikaziGraf_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d.M.yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(422, 170);
            this.dateTimePicker1.MaxDate = new System.DateTime(2040, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2020, 7, 5, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "d.M.yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(422, 212);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2020, 7, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ovdje možete odabrati datume između";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "kojih želite vidjeti vašu potrošnju.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "OD :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "DO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "* Klikom na Prikaz troškova dobit ćete popis troškova";
            // 
            // EvidencijaTroskova
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnPrikaziGraf);
            this.Controls.Add(this.GridView1);
            this.Controls.Add(this.btnProvjeriStanje);
            this.Controls.Add(this.lbStanjeNaRacunu);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbPrikazTroskova);
            this.Name = "EvidencijaTroskova";
            this.Text = "EvidencijaTroskova";
            ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbPrikazTroskova;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbStanjeNaRacunu;
        private System.Windows.Forms.Button btnProvjeriStanje;
        public System.Windows.Forms.DataGridView GridView1;
        private System.Windows.Forms.Button btnPrikaziGraf;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}