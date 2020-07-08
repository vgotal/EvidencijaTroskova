using System;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Evidencija_troškova
{
    public partial class Troskovi : Form
    {
        private int IDKorisnika;
        ScriptEngine pyEngine = null;
        ScriptScope pyScope = null;
        Form formToShow = null;
        Panel panel2;

        public Troskovi(int reader, Panel panel)
        {
            panel2 = panel;
            InitializeComponent();
            IDKorisnika = reader;
            pyEngine = Python.CreateEngine();
            pyScope = pyEngine.CreateScope();
            formToShow = new Osnovni_troškovi(IDKorisnika);
            DisplayForm(formToShow);
            panel1.Controls.Add(formToShow);
        }

        private void DisplayForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            Console.WriteLine($"{IDKorisnika}");
            Console.ReadLine();
        }

        private void MenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Evidencija troškova":
                    formToShow = new EvidencijaTroskova(IDKorisnika);
                    DisplayForm(formToShow);
                    break;

                case "Osnovni troškovi":
                    formToShow = new Osnovni_troškovi(IDKorisnika);
                    DisplayForm(formToShow);
                    break;
                case "Dodatni troškovi":
                    formToShow = new Dodatni_troškovi(IDKorisnika);
                    DisplayForm(formToShow);
                    break;
                case "Primanja":
                    formToShow = new Primanja(IDKorisnika);
                    DisplayForm(formToShow);
                    break;
                
                default:
                    break;
            }
            panel1.Controls.Clear();
            panel1.Controls.Add(formToShow);
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formToShow = new Korisnik();           
            DisplayForm(formToShow);
            panel2.Controls.Clear();
            panel2.Controls.Add(formToShow);
        }

        private void IzlazIzAplikacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
