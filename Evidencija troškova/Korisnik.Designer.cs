namespace Evidencija_troškova
{
    partial class Korisnik
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
            this.lbPrimanje = new System.Windows.Forms.Label();
            this.tbPrimanje = new System.Windows.Forms.TextBox();
            this.lbImeIPrezime = new System.Windows.Forms.Label();
            this.cbStariKorisnik = new System.Windows.Forms.ComboBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.tbNoviKorisnikIme = new System.Windows.Forms.TextBox();
            this.tbNoviKorisnikPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNoviIme = new System.Windows.Forms.Label();
            this.lbNoviPrezime = new System.Windows.Forms.Label();
            this.btnStariKorisnikStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnObrisiKorisnika = new System.Windows.Forms.Button();
            this.cbNovaLozinka = new System.Windows.Forms.CheckBox();
            this.cbLozinka = new System.Windows.Forms.CheckBox();
            this.tbPonovljenaNovaLozinka = new System.Windows.Forms.TextBox();
            this.tbNovaLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLozinka = new System.Windows.Forms.TextBox();
            this.lbLozinkaNovogKorisnika = new System.Windows.Forms.Label();
            this.lbLozinka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrimanje
            // 
            this.lbPrimanje.AutoSize = true;
            this.lbPrimanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbPrimanje.Location = new System.Drawing.Point(34, 323);
            this.lbPrimanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrimanje.Name = "lbPrimanje";
            this.lbPrimanje.Size = new System.Drawing.Size(138, 17);
            this.lbPrimanje.TabIndex = 0;
            this.lbPrimanje.Text = "Mjesečno primanje : ";
            // 
            // tbPrimanje
            // 
            this.tbPrimanje.Location = new System.Drawing.Point(176, 323);
            this.tbPrimanje.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrimanje.Name = "tbPrimanje";
            this.tbPrimanje.Size = new System.Drawing.Size(124, 20);
            this.tbPrimanje.TabIndex = 1;
            this.tbPrimanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrimanje_KeyPress);
            // 
            // lbImeIPrezime
            // 
            this.lbImeIPrezime.AutoSize = true;
            this.lbImeIPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImeIPrezime.Location = new System.Drawing.Point(34, 47);
            this.lbImeIPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbImeIPrezime.Name = "lbImeIPrezime";
            this.lbImeIPrezime.Size = new System.Drawing.Size(100, 17);
            this.lbImeIPrezime.TabIndex = 2;
            this.lbImeIPrezime.Text = "Ime i Prezime :";
            // 
            // cbStariKorisnik
            // 
            this.cbStariKorisnik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStariKorisnik.FormattingEnabled = true;
            this.cbStariKorisnik.Location = new System.Drawing.Point(143, 47);
            this.cbStariKorisnik.Margin = new System.Windows.Forms.Padding(2);
            this.cbStariKorisnik.Name = "cbStariKorisnik";
            this.cbStariKorisnik.Size = new System.Drawing.Size(124, 21);
            this.cbStariKorisnik.TabIndex = 3;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(216, 359);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(84, 29);
            this.btnUnesi.TabIndex = 4;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // tbNoviKorisnikIme
            // 
            this.tbNoviKorisnikIme.Location = new System.Drawing.Point(143, 197);
            this.tbNoviKorisnikIme.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoviKorisnikIme.Name = "tbNoviKorisnikIme";
            this.tbNoviKorisnikIme.Size = new System.Drawing.Size(124, 20);
            this.tbNoviKorisnikIme.TabIndex = 6;
            this.tbNoviKorisnikIme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNoviKorisnikIme_KeyPress);
            // 
            // tbNoviKorisnikPrezime
            // 
            this.tbNoviKorisnikPrezime.Location = new System.Drawing.Point(143, 224);
            this.tbNoviKorisnikPrezime.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoviKorisnikPrezime.Name = "tbNoviKorisnikPrezime";
            this.tbNoviKorisnikPrezime.Size = new System.Drawing.Size(124, 20);
            this.tbNoviKorisnikPrezime.TabIndex = 8;
            this.tbNoviKorisnikPrezime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbNoviKorisnikPrezime_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Postojeći korisnik : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Novi korisnik";
            // 
            // lbNoviIme
            // 
            this.lbNoviIme.AutoSize = true;
            this.lbNoviIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbNoviIme.Location = new System.Drawing.Point(34, 197);
            this.lbNoviIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNoviIme.Name = "lbNoviIme";
            this.lbNoviIme.Size = new System.Drawing.Size(38, 17);
            this.lbNoviIme.TabIndex = 11;
            this.lbNoviIme.Text = "Ime :";
            // 
            // lbNoviPrezime
            // 
            this.lbNoviPrezime.AutoSize = true;
            this.lbNoviPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbNoviPrezime.Location = new System.Drawing.Point(34, 224);
            this.lbNoviPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNoviPrezime.Name = "lbNoviPrezime";
            this.lbNoviPrezime.Size = new System.Drawing.Size(67, 17);
            this.lbNoviPrezime.TabIndex = 12;
            this.lbNoviPrezime.Text = "Prezime :";
            // 
            // btnStariKorisnikStart
            // 
            this.btnStariKorisnikStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStariKorisnikStart.Location = new System.Drawing.Point(192, 117);
            this.btnStariKorisnikStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStariKorisnikStart.Name = "btnStariKorisnikStart";
            this.btnStariKorisnikStart.Size = new System.Drawing.Size(108, 29);
            this.btnStariKorisnikStart.TabIndex = 14;
            this.btnStariKorisnikStart.Text = "Idi na troškove";
            this.btnStariKorisnikStart.UseVisualStyleBackColor = true;
            this.btnStariKorisnikStart.Click += new System.EventHandler(this.BtnStariKorisnikStart_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnObrisiKorisnika);
            this.panel2.Controls.Add(this.cbNovaLozinka);
            this.panel2.Controls.Add(this.cbLozinka);
            this.panel2.Controls.Add(this.tbPonovljenaNovaLozinka);
            this.panel2.Controls.Add(this.tbNovaLozinka);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbLozinka);
            this.panel2.Controls.Add(this.lbLozinkaNovogKorisnika);
            this.panel2.Controls.Add(this.lbLozinka);
            this.panel2.Controls.Add(this.btnStariKorisnikStart);
            this.panel2.Controls.Add(this.lbNoviPrezime);
            this.panel2.Controls.Add(this.lbNoviIme);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbNoviKorisnikPrezime);
            this.panel2.Controls.Add(this.tbNoviKorisnikIme);
            this.panel2.Controls.Add(this.btnUnesi);
            this.panel2.Controls.Add(this.cbStariKorisnik);
            this.panel2.Controls.Add(this.lbImeIPrezime);
            this.panel2.Controls.Add(this.tbPrimanje);
            this.panel2.Controls.Add(this.lbPrimanje);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 404);
            this.panel2.TabIndex = 16;
            // 
            // btnObrisiKorisnika
            // 
            this.btnObrisiKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisiKorisnika.Location = new System.Drawing.Point(64, 117);
            this.btnObrisiKorisnika.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiKorisnika.Name = "btnObrisiKorisnika";
            this.btnObrisiKorisnika.Size = new System.Drawing.Size(108, 29);
            this.btnObrisiKorisnika.TabIndex = 24;
            this.btnObrisiKorisnika.Text = "Obriši korisnika";
            this.btnObrisiKorisnika.UseVisualStyleBackColor = true;
            this.btnObrisiKorisnika.Click += new System.EventHandler(this.BtnObrisiKorisnika_Click);
            // 
            // cbNovaLozinka
            // 
            this.cbNovaLozinka.AutoSize = true;
            this.cbNovaLozinka.Location = new System.Drawing.Point(273, 256);
            this.cbNovaLozinka.Name = "cbNovaLozinka";
            this.cbNovaLozinka.Size = new System.Drawing.Size(53, 17);
            this.cbNovaLozinka.TabIndex = 23;
            this.cbNovaLozinka.Text = "Show";
            this.cbNovaLozinka.UseVisualStyleBackColor = true;
            this.cbNovaLozinka.CheckedChanged += new System.EventHandler(this.CheckBox_Show_Hide_CheckedChange);
            // 
            // cbLozinka
            // 
            this.cbLozinka.AutoSize = true;
            this.cbLozinka.Location = new System.Drawing.Point(273, 83);
            this.cbLozinka.Name = "cbLozinka";
            this.cbLozinka.Size = new System.Drawing.Size(53, 17);
            this.cbLozinka.TabIndex = 22;
            this.cbLozinka.Text = "Show";
            this.cbLozinka.UseVisualStyleBackColor = true;
            this.cbLozinka.CheckedChanged += new System.EventHandler(this.CheckBox_Show_Hide_CheckedChange);
            // 
            // tbPonovljenaNovaLozinka
            // 
            this.tbPonovljenaNovaLozinka.Location = new System.Drawing.Point(176, 292);
            this.tbPonovljenaNovaLozinka.MaxLength = 10;
            this.tbPonovljenaNovaLozinka.Name = "tbPonovljenaNovaLozinka";
            this.tbPonovljenaNovaLozinka.Size = new System.Drawing.Size(124, 20);
            this.tbPonovljenaNovaLozinka.TabIndex = 21;
            this.tbPonovljenaNovaLozinka.UseSystemPasswordChar = true;
            // 
            // tbNovaLozinka
            // 
            this.tbNovaLozinka.Location = new System.Drawing.Point(143, 254);
            this.tbNovaLozinka.MaxLength = 10;
            this.tbNovaLozinka.Name = "tbNovaLozinka";
            this.tbNovaLozinka.Size = new System.Drawing.Size(124, 20);
            this.tbNovaLozinka.TabIndex = 20;
            this.tbNovaLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(34, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ponovite lozinku :";
            // 
            // tbLozinka
            // 
            this.tbLozinka.Location = new System.Drawing.Point(143, 80);
            this.tbLozinka.MaxLength = 10;
            this.tbLozinka.MinimumSize = new System.Drawing.Size(5, 5);
            this.tbLozinka.Name = "tbLozinka";
            this.tbLozinka.Size = new System.Drawing.Size(124, 20);
            this.tbLozinka.TabIndex = 18;
            this.tbLozinka.UseSystemPasswordChar = true;
            // 
            // lbLozinkaNovogKorisnika
            // 
            this.lbLozinkaNovogKorisnika.AutoSize = true;
            this.lbLozinkaNovogKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbLozinkaNovogKorisnika.Location = new System.Drawing.Point(34, 254);
            this.lbLozinkaNovogKorisnika.Name = "lbLozinkaNovogKorisnika";
            this.lbLozinkaNovogKorisnika.Size = new System.Drawing.Size(65, 17);
            this.lbLozinkaNovogKorisnika.TabIndex = 17;
            this.lbLozinkaNovogKorisnika.Text = "Lozinka :";
            // 
            // lbLozinka
            // 
            this.lbLozinka.AutoSize = true;
            this.lbLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbLozinka.Location = new System.Drawing.Point(34, 80);
            this.lbLozinka.Name = "lbLozinka";
            this.lbLozinka.Size = new System.Drawing.Size(65, 17);
            this.lbLozinka.TabIndex = 16;
            this.lbLozinka.Text = "Lozinka :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EvidencijaTroskova.Properties.Resources.zenaRacuna;
            this.pictureBox1.Location = new System.Drawing.Point(331, 47);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 334);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Korisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 398);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Korisnik";
            this.Text = "Korisnik";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPrimanje;
        private System.Windows.Forms.TextBox tbPrimanje;
        private System.Windows.Forms.Label lbImeIPrezime;
        private System.Windows.Forms.ComboBox cbStariKorisnik;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox tbNoviKorisnikIme;
        private System.Windows.Forms.TextBox tbNoviKorisnikPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNoviIme;
        private System.Windows.Forms.Label lbNoviPrezime;
        private System.Windows.Forms.Button btnStariKorisnikStart;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbPonovljenaNovaLozinka;
        private System.Windows.Forms.TextBox tbNovaLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLozinka;
        private System.Windows.Forms.Label lbLozinkaNovogKorisnika;
        private System.Windows.Forms.Label lbLozinka;
        private System.Windows.Forms.CheckBox cbLozinka;
        private System.Windows.Forms.CheckBox cbNovaLozinka;
        private System.Windows.Forms.Button btnObrisiKorisnika;
    }
}