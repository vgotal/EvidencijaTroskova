namespace Evidencija_troškova
{
    partial class Dodatni_troškovi
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
            this.lbPopisDodatnihTroskova = new System.Windows.Forms.Label();
            this.lbNazivTroska = new System.Windows.Forms.Label();
            this.cbDodatniTroskovi = new System.Windows.Forms.ComboBox();
            this.tbUnosDodatnihTroskova = new System.Windows.Forms.TextBox();
            this.tbUnesiNoviTrosak = new System.Windows.Forms.TextBox();
            this.btnUnesiTrosak = new System.Windows.Forms.Button();
            this.btnUnesiNoviTrosak = new System.Windows.Forms.Button();
            this.lbNapomena = new System.Windows.Forms.Label();
            this.lbBrisanjeNazivaTroska = new System.Windows.Forms.Label();
            this.cbIzbrisi = new System.Windows.Forms.ComboBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPopisDodatnihTroskova
            // 
            this.lbPopisDodatnihTroskova.AutoSize = true;
            this.lbPopisDodatnihTroskova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbPopisDodatnihTroskova.Location = new System.Drawing.Point(12, 50);
            this.lbPopisDodatnihTroskova.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPopisDodatnihTroskova.Name = "lbPopisDodatnihTroskova";
            this.lbPopisDodatnihTroskova.Size = new System.Drawing.Size(160, 17);
            this.lbPopisDodatnihTroskova.TabIndex = 0;
            this.lbPopisDodatnihTroskova.Text = "Popis dodatnih troškova";
            // 
            // lbNazivTroska
            // 
            this.lbNazivTroska.AutoSize = true;
            this.lbNazivTroska.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbNazivTroska.Location = new System.Drawing.Point(78, 182);
            this.lbNazivTroska.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNazivTroska.Name = "lbNazivTroska";
            this.lbNazivTroska.Size = new System.Drawing.Size(94, 17);
            this.lbNazivTroska.TabIndex = 1;
            this.lbNazivTroska.Text = "Naziv troška :";
            // 
            // cbDodatniTroskovi
            // 
            this.cbDodatniTroskovi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDodatniTroskovi.FormattingEnabled = true;
            this.cbDodatniTroskovi.Location = new System.Drawing.Point(212, 50);
            this.cbDodatniTroskovi.Margin = new System.Windows.Forms.Padding(2);
            this.cbDodatniTroskovi.Name = "cbDodatniTroskovi";
            this.cbDodatniTroskovi.Size = new System.Drawing.Size(152, 21);
            this.cbDodatniTroskovi.TabIndex = 2;
            // 
            // tbUnosDodatnihTroskova
            // 
            this.tbUnosDodatnihTroskova.Location = new System.Drawing.Point(212, 88);
            this.tbUnosDodatnihTroskova.Margin = new System.Windows.Forms.Padding(2);
            this.tbUnosDodatnihTroskova.Name = "tbUnosDodatnihTroskova";
            this.tbUnosDodatnihTroskova.Size = new System.Drawing.Size(152, 20);
            this.tbUnosDodatnihTroskova.TabIndex = 3;
            this.tbUnosDodatnihTroskova.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbUnosDodatnihTroskova_KeyPress);
            // 
            // tbUnesiNoviTrosak
            // 
            this.tbUnesiNoviTrosak.Location = new System.Drawing.Point(212, 182);
            this.tbUnesiNoviTrosak.Margin = new System.Windows.Forms.Padding(2);
            this.tbUnesiNoviTrosak.Name = "tbUnesiNoviTrosak";
            this.tbUnesiNoviTrosak.Size = new System.Drawing.Size(152, 20);
            this.tbUnesiNoviTrosak.TabIndex = 4;
            // 
            // btnUnesiTrosak
            // 
            this.btnUnesiTrosak.Location = new System.Drawing.Point(387, 83);
            this.btnUnesiTrosak.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnesiTrosak.Name = "btnUnesiTrosak";
            this.btnUnesiTrosak.Size = new System.Drawing.Size(65, 29);
            this.btnUnesiTrosak.TabIndex = 5;
            this.btnUnesiTrosak.Text = "Unesi";
            this.btnUnesiTrosak.UseVisualStyleBackColor = true;
            this.btnUnesiTrosak.Click += new System.EventHandler(this.UnesiTrosak_Click);
            // 
            // btnUnesiNoviTrosak
            // 
            this.btnUnesiNoviTrosak.Location = new System.Drawing.Point(387, 177);
            this.btnUnesiNoviTrosak.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnesiNoviTrosak.Name = "btnUnesiNoviTrosak";
            this.btnUnesiNoviTrosak.Size = new System.Drawing.Size(65, 29);
            this.btnUnesiNoviTrosak.TabIndex = 6;
            this.btnUnesiNoviTrosak.Text = "Unesi";
            this.btnUnesiNoviTrosak.UseVisualStyleBackColor = true;
            this.btnUnesiNoviTrosak.Click += new System.EventHandler(this.BtnUnesiNoviTrosak_Click);
            // 
            // lbNapomena
            // 
            this.lbNapomena.AutoSize = true;
            this.lbNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbNapomena.Location = new System.Drawing.Point(12, 144);
            this.lbNapomena.Name = "lbNapomena";
            this.lbNapomena.Size = new System.Drawing.Size(234, 17);
            this.lbNapomena.TabIndex = 7;
            this.lbNapomena.Text = "Ovdje možete unjeti nove troškove :";
            // 
            // lbBrisanjeNazivaTroska
            // 
            this.lbBrisanjeNazivaTroska.AutoSize = true;
            this.lbBrisanjeNazivaTroska.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbBrisanjeNazivaTroska.Location = new System.Drawing.Point(12, 248);
            this.lbBrisanjeNazivaTroska.Name = "lbBrisanjeNazivaTroska";
            this.lbBrisanjeNazivaTroska.Size = new System.Drawing.Size(299, 17);
            this.lbBrisanjeNazivaTroska.TabIndex = 8;
            this.lbBrisanjeNazivaTroska.Text = "Brisanje dodatnog troška kojeg više nemamo :";
            // 
            // cbIzbrisi
            // 
            this.cbIzbrisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIzbrisi.FormattingEnabled = true;
            this.cbIzbrisi.Location = new System.Drawing.Point(330, 248);
            this.cbIzbrisi.Name = "cbIzbrisi";
            this.cbIzbrisi.Size = new System.Drawing.Size(145, 21);
            this.cbIzbrisi.TabIndex = 9;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(500, 243);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(65, 29);
            this.btnIzbrisi.TabIndex = 10;
            this.btnIzbrisi.Text = "Izbriši";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.BtnIzbrisi_Click);
            // 
            // Dodatni_troškovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnIzbrisi);
            this.Controls.Add(this.cbIzbrisi);
            this.Controls.Add(this.lbBrisanjeNazivaTroska);
            this.Controls.Add(this.lbNapomena);
            this.Controls.Add(this.btnUnesiNoviTrosak);
            this.Controls.Add(this.btnUnesiTrosak);
            this.Controls.Add(this.tbUnesiNoviTrosak);
            this.Controls.Add(this.tbUnosDodatnihTroskova);
            this.Controls.Add(this.cbDodatniTroskovi);
            this.Controls.Add(this.lbNazivTroska);
            this.Controls.Add(this.lbPopisDodatnihTroskova);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dodatni_troškovi";
            this.Text = "Dodatni_troškovi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPopisDodatnihTroskova;
        private System.Windows.Forms.Label lbNazivTroska;
        private System.Windows.Forms.ComboBox cbDodatniTroskovi;
        private System.Windows.Forms.TextBox tbUnosDodatnihTroskova;
        private System.Windows.Forms.TextBox tbUnesiNoviTrosak;
        private System.Windows.Forms.Button btnUnesiTrosak;
        private System.Windows.Forms.Button btnUnesiNoviTrosak;
        private System.Windows.Forms.Label lbNapomena;
        private System.Windows.Forms.Label lbBrisanjeNazivaTroska;
        private System.Windows.Forms.ComboBox cbIzbrisi;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}