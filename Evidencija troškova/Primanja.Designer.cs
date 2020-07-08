namespace Evidencija_troškova
{
    partial class Primanja
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
            this.lbNapomena = new System.Windows.Forms.Label();
            this.tbPrimanje = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrimanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNapomena
            // 
            this.lbNapomena.AutoSize = true;
            this.lbNapomena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbNapomena.Location = new System.Drawing.Point(71, 37);
            this.lbNapomena.Name = "lbNapomena";
            this.lbNapomena.Size = new System.Drawing.Size(463, 17);
            this.lbNapomena.TabIndex = 0;
            this.lbNapomena.Text = "Ovdje unosite svako primanje i ono se pridodaje na vaš mjesečni budžet";
            // 
            // tbPrimanje
            // 
            this.tbPrimanje.Location = new System.Drawing.Point(402, 114);
            this.tbPrimanje.Name = "tbPrimanje";
            this.tbPrimanje.Size = new System.Drawing.Size(172, 20);
            this.tbPrimanje.TabIndex = 1;
            this.tbPrimanje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbPrimanje_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EvidencijaTroskova.Properties.Resources.Primanja;
            this.pictureBox1.Location = new System.Drawing.Point(74, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 247);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrimanje
            // 
            this.btnPrimanje.Location = new System.Drawing.Point(501, 173);
            this.btnPrimanje.Name = "btnPrimanje";
            this.btnPrimanje.Size = new System.Drawing.Size(73, 35);
            this.btnPrimanje.TabIndex = 3;
            this.btnPrimanje.Text = "Unesi";
            this.btnPrimanje.UseVisualStyleBackColor = true;
            this.btnPrimanje.Click += new System.EventHandler(this.BtnPrimanje_Click);
            // 
            // Primanja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 366);
            this.Controls.Add(this.btnPrimanje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPrimanje);
            this.Controls.Add(this.lbNapomena);
            this.Name = "Primanja";
            this.Text = "Primanja";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNapomena;
        private System.Windows.Forms.TextBox tbPrimanje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrimanje;
    }
}