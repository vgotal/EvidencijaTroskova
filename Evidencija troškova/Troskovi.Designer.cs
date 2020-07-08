namespace Evidencija_troškova
{
    partial class Troskovi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osnovniTroškoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodatniTroškoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaTroškovaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazIzAplikacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 323);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.osnovniTroškoviToolStripMenuItem,
            this.dodatniTroškoviToolStripMenuItem,
            this.evidencijaTroškovaToolStripMenuItem,
            this.primanjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuItemClicked);
            // 
            // osnovniTroškoviToolStripMenuItem
            // 
            this.osnovniTroškoviToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.osnovniTroškoviToolStripMenuItem.Name = "osnovniTroškoviToolStripMenuItem";
            this.osnovniTroškoviToolStripMenuItem.Size = new System.Drawing.Size(125, 21);
            this.osnovniTroškoviToolStripMenuItem.Text = "Osnovni troškovi";
            // 
            // dodatniTroškoviToolStripMenuItem
            // 
            this.dodatniTroškoviToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dodatniTroškoviToolStripMenuItem.Name = "dodatniTroškoviToolStripMenuItem";
            this.dodatniTroškoviToolStripMenuItem.Size = new System.Drawing.Size(122, 21);
            this.dodatniTroškoviToolStripMenuItem.Text = "Dodatni troškovi";
            // 
            // evidencijaTroškovaToolStripMenuItem
            // 
            this.evidencijaTroškovaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.evidencijaTroškovaToolStripMenuItem.Name = "evidencijaTroškovaToolStripMenuItem";
            this.evidencijaTroškovaToolStripMenuItem.Size = new System.Drawing.Size(142, 21);
            this.evidencijaTroškovaToolStripMenuItem.Text = "Evidencija troškova";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.izlazIzAplikacijeToolStripMenuItem});
            this.izbornikToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // izlazIzAplikacijeToolStripMenuItem
            // 
            this.izlazIzAplikacijeToolStripMenuItem.Name = "izlazIzAplikacijeToolStripMenuItem";
            this.izlazIzAplikacijeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazIzAplikacijeToolStripMenuItem.Text = "Izlaz iz aplikacije";
            this.izlazIzAplikacijeToolStripMenuItem.Click += new System.EventHandler(this.IzlazIzAplikacijeToolStripMenuItem_Click);
            // 
            // primanjaToolStripMenuItem
            // 
            this.primanjaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.primanjaToolStripMenuItem.Name = "primanjaToolStripMenuItem";
            this.primanjaToolStripMenuItem.Size = new System.Drawing.Size(75, 21);
            this.primanjaToolStripMenuItem.Text = "Primanja";
            // 
            // Troskovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Troskovi";
            this.Text = "Troskovi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem osnovniTroškoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodatniTroškoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaTroškovaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazIzAplikacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primanjaToolStripMenuItem;
    }
}