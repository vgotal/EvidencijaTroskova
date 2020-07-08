using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Evidencija_troškova
{
    public partial class Primanja : Form
    {
        private int IDKorisnik;
        private OleDbConnection konekcija;
        private OleDbDataReader reader;
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public Primanja(int reader)
        {
            konekcija = new OleDbConnection(connString);
            InitializeComponent();
            IDKorisnik = reader;
        }

        private void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        private void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        private void BtnPrimanje_Click(object sender, EventArgs e)
        {
            double primanje;
            decimal staroPrimanje = 0;

            if (!String.IsNullOrEmpty(tbPrimanje.Text))
            {
                OtvoriKonekciju();
                OleDbCommand dohvatiTrenutnoStanjeCmd = new OleDbCommand("SELECT Primanje FROM Korisnik WHERE ID=@ID", konekcija);
                dohvatiTrenutnoStanjeCmd.Parameters.AddWithValue("ID", IDKorisnik);
                reader = dohvatiTrenutnoStanjeCmd.ExecuteReader();
                while (reader.Read())
                {
                    staroPrimanje = reader.GetDecimal(0);
                }
                primanje = (double)staroPrimanje + double.Parse(tbPrimanje.Text);

                OleDbCommand ucitajNovoPrimanjeCmd = new OleDbCommand("UPDATE Korisnik SET Primanje=@NovoPrimanje WHERE ID=@IDKorisnik", konekcija);
                ucitajNovoPrimanjeCmd.Parameters.AddWithValue("NovoPrimanje", primanje);
                ucitajNovoPrimanjeCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnik);

                if (ucitajNovoPrimanjeCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show($"Unjeli ste novo primanje i ono sada iznosi {primanje}");
                    tbPrimanje.Clear();
                }
                ZatvoriKonekciju();
            }
            else
            {
                MessageBox.Show("Niste unjeli novo primanje!");
            }
        }

        private void TbPrimanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
        }
    }
}
