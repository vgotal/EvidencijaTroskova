using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Evidencija_troškova
{
    public partial class Osnovni_troškovi : Form
    {
        private int IDKorisnika;
        OleDbDataReader reader;
        OleDbConnection konekcija;
        private double primanje;
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public Osnovni_troškovi(int reader)
        {
            konekcija = new OleDbConnection(connString);
            InitializeComponent();
            IDKorisnika = reader;
            UcitajRezije();
            UcitajPrimanje();
        }

        private void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        private void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        private void UcitajRezije()
        {
            OtvoriKonekciju();
            OleDbCommand dohvatiRezijeCmd = new OleDbCommand("SELECT ID, Naziv FROM PodvrstaTroska ORDER BY Naziv ASC", konekcija);
            reader = dohvatiRezijeCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Naziv", typeof(string));
            dt.Load(reader);

            cbRezije.ValueMember = "Naziv";
            cbRezije.DisplayMember = "Naziv";
            cbRezije.DataSource = dt;
            ZatvoriKonekciju();
        }

        private void UcitajPrimanje()
        {
            OtvoriKonekciju();
            OleDbCommand dohvatiTrenutnoStanjeCmd = new OleDbCommand("SELECT Primanje FROM Korisnik WHERE ID=@ID", konekcija);
            dohvatiTrenutnoStanjeCmd.Parameters.AddWithValue("ID", IDKorisnika);
            reader = dohvatiTrenutnoStanjeCmd.ExecuteReader();
            while (reader.Read())
            {
                primanje = (double)reader.GetDecimal(0);
            }
            ZatvoriKonekciju();
        }

        private int DohvatiIDVrsteTroska(string naziv)
        {
            int IDVrsta = 0;

            OtvoriKonekciju();
            OleDbCommand DohvatiIDVrsteTroskaCmd = new OleDbCommand("SELECT ID FROM VrstaTroska WHERE NazivTroska='" + naziv + "'", konekcija);
            reader = DohvatiIDVrsteTroskaCmd.ExecuteReader();
            while (reader.Read())
            {
                IDVrsta = reader.GetInt32(0);
            }
            ZatvoriKonekciju();
            return IDVrsta;
        }

        private int DohvatiIDPodVrsteTroska()
        {
            int IDPodvrsta = 0;
            OtvoriKonekciju();
            OleDbCommand DohvatiIDVrsteTroskaCmd = new OleDbCommand("SELECT ID FROM PodvrstaTroska WHERE Naziv='" + cbRezije.SelectedValue.ToString() + "'", konekcija);
            reader = DohvatiIDVrsteTroskaCmd.ExecuteReader();
            while (reader.Read())
            {
                IDPodvrsta = reader.GetInt32(0);
            }
            ZatvoriKonekciju();
            return IDPodvrsta;
        }

        private double UnesiTrosak(string iznos, int IDVrsta, int IDPodvrstaTroska)
        {
            OtvoriKonekciju();
            OleDbCommand ucitajUBazuCmd = new OleDbCommand("INSERT INTO Trosak (IDVrsteTroska,Iznos,Datum,IDKorisnika,IDPodvrstaTroska) VALUES (@IDVrstaTroska,@iznos,Now(),@IDKorisnik,@IDPodvrsta)", konekcija);
            ucitajUBazuCmd.Parameters.AddWithValue("IDVrstaTroska", IDVrsta);
            ucitajUBazuCmd.Parameters.AddWithValue("iznos", iznos);
            ucitajUBazuCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnika);
            ucitajUBazuCmd.Parameters.AddWithValue("IDPodvrsta", IDPodvrstaTroska);
            ucitajUBazuCmd.ExecuteNonQuery();
            ZatvoriKonekciju();
            return double.Parse(iznos);
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            double suma = 0;
            bool potvrdaUnosa = false;

            if (!string.IsNullOrEmpty(tbHrana.Text) && (primanje - double.Parse(tbHrana.Text) >= 0))
            {
                suma += UnesiTrosak(tbHrana.Text, DohvatiIDVrsteTroska("Hrana"), 0);
                AzurirajPrimanje(double.Parse(tbHrana.Text));
                tbHrana.Clear();
                potvrdaUnosa = true;
            }

            if (!string.IsNullOrEmpty(tbPrijevoz.Text) && (primanje - double.Parse(tbPrijevoz.Text) >= 0))
            {
                suma += UnesiTrosak(tbPrijevoz.Text, DohvatiIDVrsteTroska("Prijevoz"), 0);
                AzurirajPrimanje(double.Parse(tbPrijevoz.Text));
                tbPrijevoz.Clear();
                potvrdaUnosa = true;
            }

            if (!string.IsNullOrEmpty(tbRezije.Text) && (primanje - double.Parse(tbRezije.Text) >= 0))
            {
                suma += UnesiTrosak(tbRezije.Text, DohvatiIDVrsteTroska("Rezije"), DohvatiIDPodVrsteTroska());
                AzurirajPrimanje(double.Parse(tbRezije.Text));
                tbRezije.Clear();
                potvrdaUnosa = true;
            }

            if (potvrdaUnosa == true)
            {
                MessageBox.Show($"Unjeli ste nove troškove u iznosu od {suma} kn i vaše stanje na računu iznosi {primanje}");
            }
            else
            {
                MessageBox.Show("Niste unjeli nove troškove ili nemate dovoljan iznos na računu!");
            }
        }

        private void AzurirajPrimanje(double trosak)
        {
            decimal staroPrimanje = 0;
            OtvoriKonekciju();
            OleDbCommand dohvatiTrenutnoStanjeCmd = new OleDbCommand("SELECT Primanje FROM Korisnik WHERE ID=@ID", konekcija);
            dohvatiTrenutnoStanjeCmd.Parameters.AddWithValue("ID", IDKorisnika);
            reader = dohvatiTrenutnoStanjeCmd.ExecuteReader();
            while (reader.Read())
            {
                staroPrimanje = reader.GetDecimal(0);
            }
            primanje = (double)staroPrimanje - trosak;
            OleDbCommand ucitajNovoPrimanjeCmd = new OleDbCommand("UPDATE Korisnik SET Primanje=@NovoPrimanje WHERE ID=@IDKorisnik", konekcija);
            ucitajNovoPrimanjeCmd.Parameters.AddWithValue("NovoPrimanje", primanje);
            ucitajNovoPrimanjeCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnika);
            ucitajNovoPrimanjeCmd.ExecuteNonQuery();
            ZatvoriKonekciju();
        }

        private void ProvjeraUnosa(KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
        }

        private void TbHrana_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeraUnosa(e);
        }

        private void TbPrijevoz_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeraUnosa(e);
        }

        private void TbRezije_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeraUnosa(e);
        }
    }
}




