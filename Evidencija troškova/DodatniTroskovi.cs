using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Evidencija_troškova
{
    public partial class Dodatni_troškovi : Form
    {
        private int IDKorisnik;
        private OleDbConnection konekcija;
        private OleDbDataReader reader;
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();

        public Dodatni_troškovi(int reader)
        {
            konekcija = new OleDbConnection(connString);
            InitializeComponent();
            IDKorisnik = reader;
            UcitajDodatneTroskove(cbDodatniTroskovi);
            UcitajDodatneTroskove(cbIzbrisi);
        }

        private void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        private void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        private void UcitajDodatneTroskove(ComboBox cbOdabrani)
        {
            OtvoriKonekciju();

            OleDbCommand UcitajDodatneTroskoveCmd = new OleDbCommand("SELECT NazivTroska FROM VrstaTroska WHERE GlavniTrosak =False AND IDKorisnika=@ID", konekcija);
            UcitajDodatneTroskoveCmd.Parameters.AddWithValue("ID", IDKorisnik);
            reader = UcitajDodatneTroskoveCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("NazivTroska", typeof(string));
            dt.Load(reader);
            cbOdabrani.ValueMember = "NazivTroska";
            cbOdabrani.DisplayMember = "NazivTroska";
            cbOdabrani.DataSource = dt;

            ZatvoriKonekciju();
        }

        private void BtnUnesiNoviTrosak_Click(object sender, EventArgs e)
        {
            int brojIstihTroskova = 0;

            if (!String.IsNullOrEmpty(tbUnesiNoviTrosak.Text))
            {

                OtvoriKonekciju();
                OleDbCommand dodajNovuVrstuTroskaCmd = new OleDbCommand("INSERT INTO VrstaTroska(NazivTroska, GlavniTrosak, IDKorisnika) values(@naziv,@glavniTrosak,@IDKorisnik)", konekcija);
                OleDbCommand dohvatiVrstuTroskaCmd = new OleDbCommand("SELECT ID FROM VrstaTroska WHERE NazivTroska='" + tbUnesiNoviTrosak.Text + "' AND IDKorisnika=@ID", konekcija);
                dohvatiVrstuTroskaCmd.Parameters.AddWithValue("ID", IDKorisnik);
                reader = dohvatiVrstuTroskaCmd.ExecuteReader();
                while (reader.Read())
                {
                    brojIstihTroskova = (reader.GetInt32(0));
                }
                if (brojIstihTroskova != 0)
                {
                    MessageBox.Show("Uneseni Trosak već postoji!");
                }
                else
                {
                    dodajNovuVrstuTroskaCmd.Parameters.AddWithValue("naziv", tbUnesiNoviTrosak.Text);
                    dodajNovuVrstuTroskaCmd.Parameters.AddWithValue("glavniTrosak", 0);
                    dodajNovuVrstuTroskaCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnik);
                    dodajNovuVrstuTroskaCmd.ExecuteNonQuery();
                    MessageBox.Show($"Uneseni je novi trosak, pod nazivom {tbUnesiNoviTrosak.Text}!");
                }
                tbUnesiNoviTrosak.Clear();
                ZatvoriKonekciju();

                UcitajDodatneTroskove(cbDodatniTroskovi);
                UcitajDodatneTroskove(cbIzbrisi);
            }
            else
            {
                MessageBox.Show("Niste unjeli novi trosak!");
            }

        }

        private void UnesiTrosak_Click(object sender, EventArgs e)
        {
            int IDVrsta = -1;
            double staroPrimanje = 0;

            if (!String.IsNullOrEmpty(tbUnosDodatnihTroskova.Text) && cbDodatniTroskovi.SelectedValue != null)
            {
                OtvoriKonekciju();
                OleDbCommand dohvatiTrenutnoStanjeCmd = new OleDbCommand("SELECT Primanje FROM Korisnik WHERE ID=@ID", konekcija);
                dohvatiTrenutnoStanjeCmd.Parameters.AddWithValue("ID", IDKorisnik);
                reader = dohvatiTrenutnoStanjeCmd.ExecuteReader();
                while (reader.Read())
                {
                    staroPrimanje = (double)reader.GetDecimal(0);
                }

                double novoPrimanje = staroPrimanje - Convert.ToDouble(tbUnosDodatnihTroskova.Text);

                if (novoPrimanje >= 0)
                {
                    OleDbCommand dohvatiIdVrsteTroskaCmd = new OleDbCommand("SELECT ID FROM VrstaTroska WHERE NazivTroska='" + cbDodatniTroskovi.SelectedValue.ToString() + "'", konekcija);
                    reader = dohvatiIdVrsteTroskaCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        IDVrsta = reader.GetInt32(0);
                    }
                    OleDbCommand unosNovogTroskaCmd = new OleDbCommand("INSERT INTO Trosak (IDVrsteTroska,Iznos,Datum,IDKorisnika,IDPodvrstaTroska) VALUES (@IdVrsta,@iznos,Now(),@IDKorisnik,@IDPodvrsta)", konekcija);
                    unosNovogTroskaCmd.Parameters.AddWithValue("IdVrsta", IDVrsta);
                    unosNovogTroskaCmd.Parameters.AddWithValue("iznos", tbUnosDodatnihTroskova.Text);
                    unosNovogTroskaCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnik);
                    unosNovogTroskaCmd.Parameters.AddWithValue("IDPodvrsta", 0);

                    int provjera = unosNovogTroskaCmd.ExecuteNonQuery();

                    if (provjera > 0)
                    {
                        MessageBox.Show($"Unesen je novi trošak u iznosu od {tbUnosDodatnihTroskova.Text} i iznos na računu iznosi {novoPrimanje}");
                        ZatvoriKonekciju();
                        AzurirajPrimanje(novoPrimanje);
                        tbUnosDodatnihTroskova.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Nemate dovoljno novaca na računu!");
                }
            }
            else
            {
                MessageBox.Show("Niste unjeli iznos ili odabrali vrstu troška!");
            }
            ZatvoriKonekciju();
        }

        private void TbUnosDodatnihTroskova_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';
        }

        private void AzurirajPrimanje(double novoPrimanje)
        {
            OtvoriKonekciju();
            OleDbCommand ucitajNovoPrimanjeCmd = new OleDbCommand("UPDATE Korisnik SET Primanje=@NovoPrimanje WHERE ID=@IDKorisnik", konekcija);
            ucitajNovoPrimanjeCmd.Parameters.AddWithValue("NovoPrimanje", novoPrimanje);
            ucitajNovoPrimanjeCmd.Parameters.AddWithValue("IDKorisnik", IDKorisnik);
            ucitajNovoPrimanjeCmd.ExecuteNonQuery();
            ZatvoriKonekciju();
        }

        private void BtnIzbrisi_Click(object sender, EventArgs e)
        {
            int IDVrsta = 0;
            if (cbIzbrisi.SelectedValue != null)
            {
                OtvoriKonekciju();
                OleDbCommand dohvatiIdVrsteTroskaCmd = new OleDbCommand("SELECT ID FROM VrstaTroska WHERE NazivTroska='" + cbIzbrisi.SelectedValue.ToString() + "'", konekcija);
                reader = dohvatiIdVrsteTroskaCmd.ExecuteReader();
                while (reader.Read())
                {
                    IDVrsta = reader.GetInt32(0);
                }

                OleDbCommand izbrisiTroskoveCmd = new OleDbCommand("DELETE FROM Trosak WHERE IDVrsteTroska=" + IDVrsta, konekcija);
                OleDbCommand izbrisiVrstuTroskaCmd = new OleDbCommand("DELETE FROM VrstaTroska WHERE ID=" + IDVrsta, konekcija);
                izbrisiTroskoveCmd.ExecuteNonQuery();
                izbrisiVrstuTroskaCmd.ExecuteNonQuery();
                MessageBox.Show($"Izbrisan je trošak pod nazivom {cbIzbrisi.SelectedValue.ToString()}");
                ZatvoriKonekciju();

                cbIzbrisi.DataSource = null;
                cbDodatniTroskovi.DataSource = null;

                cbIzbrisi.Items.Clear();
                cbDodatniTroskovi.Items.Clear();

                UcitajDodatneTroskove(cbIzbrisi);
                UcitajDodatneTroskove(cbDodatniTroskovi);
            }
            else
            {
                MessageBox.Show("Niste izabrali dodatan trošak!");
            }
        }
    }
}
