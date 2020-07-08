namespace Evidencija_troškova
{
    partial class Osnovni_troškovi
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
            this.lbRezije = new System.Windows.Forms.Label();
            this.lbHrana = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.tbHrana = new System.Windows.Forms.TextBox();
            this.tbRezije = new System.Windows.Forms.TextBox();
            this.lbPrijevoz = new System.Windows.Forms.Label();
            this.tbPrijevoz = new System.Windows.Forms.TextBox();
            this.lbPoruka = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRezije = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRezije
            // 
            this.lbRezije.AutoSize = true;
            this.lbRezije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbRezije.Location = new System.Drawing.Point(47, 136);
            this.lbRezije.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRezije.Name = "lbRezije";
            this.lbRezije.Size = new System.Drawing.Size(87, 17);
            this.lbRezije.TabIndex = 8;
            this.lbRezije.Text = "Vrsta rezije :";
            // 
            // lbHrana
            // 
            this.lbHrana.AutoSize = true;
            this.lbHrana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbHrana.Location = new System.Drawing.Point(47, 61);
            this.lbHrana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHrana.Name = "lbHrana";
            this.lbHrana.Size = new System.Drawing.Size(55, 17);
            this.lbHrana.TabIndex = 6;
            this.lbHrana.Text = "Hrana :";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(231, 223);
            this.btnUnesi.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(65, 29);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.BtnUnesi_Click);
            // 
            // tbHrana
            // 
            this.tbHrana.Location = new System.Drawing.Point(138, 61);
            this.tbHrana.Margin = new System.Windows.Forms.Padding(2);
            this.tbHrana.Name = "tbHrana";
            this.tbHrana.Size = new System.Drawing.Size(158, 20);
            this.tbHrana.TabIndex = 9;
            this.tbHrana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbHrana_KeyPress);
            // 
            // tbRezije
            // 
            this.tbRezije.Location = new System.Drawing.Point(139, 175);
            this.tbRezije.Margin = new System.Windows.Forms.Padding(2);
            this.tbRezije.Name = "tbRezije";
            this.tbRezije.Size = new System.Drawing.Size(158, 20);
            this.tbRezije.TabIndex = 12;
            this.tbRezije.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbRezije_KeyPress);
            // 
            // lbPrijevoz
            // 
            this.lbPrijevoz.AutoSize = true;
            this.lbPrijevoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbPrijevoz.Location = new System.Drawing.Point(47, 99);
            this.lbPrijevoz.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPrijevoz.Name = "lbPrijevoz";
            this.lbPrijevoz.Size = new System.Drawing.Size(66, 17);
            this.lbPrijevoz.TabIndex = 15;
            this.lbPrijevoz.Text = "Prijevoz :";
            // 
            // tbPrijevoz
            // 
            this.tbPrijevoz.Location = new System.Drawing.Point(138, 96);
            this.tbPrijevoz.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrijevoz.Name = "tbPrijevoz";
            this.tbPrijevoz.Size = new System.Drawing.Size(158, 20);
            this.tbPrijevoz.TabIndex = 16;
            this.tbPrijevoz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrijevoz_KeyPress);
            // 
            // lbPoruka
            // 
            this.lbPoruka.AutoSize = true;
            this.lbPoruka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoruka.Location = new System.Drawing.Point(27, 14);
            this.lbPoruka.Name = "lbPoruka";
            this.lbPoruka.Size = new System.Drawing.Size(270, 20);
            this.lbPoruka.TabIndex = 18;
            this.lbPoruka.Text = "Unesite iznos za određene troškove :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EvidencijaTroskova.Properties.Resources.kalkulator;
            this.pictureBox1.Location = new System.Drawing.Point(314, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 233);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(47, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Iznos :";
            // 
            // cbRezije
            // 
            this.cbRezije.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRezije.FormattingEnabled = true;
            this.cbRezije.Location = new System.Drawing.Point(138, 136);
            this.cbRezije.Margin = new System.Windows.Forms.Padding(2);
            this.cbRezije.Name = "cbRezije";
            this.cbRezije.Size = new System.Drawing.Size(158, 21);
            this.cbRezije.TabIndex = 11;
            // 
            // Osnovni_troškovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPoruka);
            this.Controls.Add(this.tbPrijevoz);
            this.Controls.Add(this.lbPrijevoz);
            this.Controls.Add(this.tbRezije);
            this.Controls.Add(this.cbRezije);
            this.Controls.Add(this.tbHrana);
            this.Controls.Add(this.lbRezije);
            this.Controls.Add(this.lbHrana);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Osnovni_troškovi";
            this.Text = "Osnovni_troškovi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRezije;
        private System.Windows.Forms.Label lbHrana;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.TextBox tbHrana;
        private System.Windows.Forms.TextBox tbRezije;
        private System.Windows.Forms.Label lbPrijevoz;
        private System.Windows.Forms.TextBox tbPrijevoz;
        private System.Windows.Forms.Label lbPoruka;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRezije;
    }
}