using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace Evidencija_troškova
{
    public partial class Korisnik : Form
    {
        private OleDbConnection konekcija;
        private OleDbDataReader reader;
        private string connString = ConfigurationManager.ConnectionStrings["connString"].ToString();
        private int IDKorisnika;

        public Korisnik()
        {
            konekcija = new OleDbConnection(connString);
            InitializeComponent();
            PopuniKorisnike();
        }

        private void DisplayForm(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void OtvoriKonekciju()
        {
            konekcija.Open();
        }

        private void ZatvoriKonekciju()
        {
            konekcija.Close();
        }

        private void BtnUnesi_Click(object sender, EventArgs e)
        {
            int brojIstihKorisnika = 0;

            if (!String.IsNullOrEmpty(tbNoviKorisnikIme.Text)
                && !String.IsNullOrEmpty(tbNoviKorisnikPrezime.Text)
                && !String.IsNullOrEmpty(tbPrimanje.Text)
                && !String.IsNullOrEmpty(tbNovaLozinka.Text)
                && !String.IsNullOrEmpty(tbPonovljenaNovaLozinka.Text))
            {
                if (tbNovaLozinka.Text == tbPonovljenaNovaLozinka.Text)
                {
                    OtvoriKonekciju();
                    OleDbCommand unesiKorisnikaCmd = new OleDbCommand("INSERT INTO Korisnik(Ime, Prezime, Primanje, Lozinka) VALUES (@Ime, @Prezime, @Primanje, @Lozinka)", konekcija);
                    OleDbCommand provjeraPostojecegKorisnikaCmd = new OleDbCommand("SELECT ID FROM Korisnik WHERE Ime='" + tbNoviKorisnikIme.Text + "' AND Prezime='" + tbNoviKorisnikPrezime.Text + "'", konekcija);

                    reader = provjeraPostojecegKorisnikaCmd.ExecuteReader();
                    while (reader.Read())
                    {
                        brojIstihKorisnika = (reader.GetInt32(0));
                    }
                    if (brojIstihKorisnika != 0)
                    {
                        MessageBox.Show("Uneseni Korisnik već postoji!");
                    }
                    else
                    {
                        unesiKorisnikaCmd.Parameters.AddWithValue("@Ime", tbNoviKorisnikIme.Text);
                        unesiKorisnikaCmd.Parameters.AddWithValue("@Prezime", tbNoviKorisnikPrezime.Text);
                        unesiKorisnikaCmd.Parameters.AddWithValue("@Primanje", tbPrimanje.Text);
                        unesiKorisnikaCmd.Parameters.AddWithValue("@Lozinka", tbNovaLozinka.Text);

                        try
                        {
                            if (unesiKorisnikaCmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show($"Kreiran je novi korisnik: {tbNoviKorisnikIme.Text} {tbNoviKorisnikPrezime.Text}");
                                ZatvoriKonekciju();

                                PopuniKorisnike();
                                tbNoviKorisnikIme.Clear();
                                tbNoviKorisnikPrezime.Clear();
                                tbPrimanje.Clear();
                                tbNovaLozinka.Clear();
                                tbPonovljenaNovaLozinka.Clear();
                                cbNovaLozinka.Checked = false;
                            }
                        }
                        catch (Exception err )
                        {
                            Console.WriteLine(err.Message);

                            throw;
                        }
                    }
                    ZatvoriKonekciju();
                }
                else
                {
                    MessageBox.Show("Lozinke se ne poklapaju, pokušajte ponovno!");
                }
            }
            else
            {
                MessageBox.Show("Niste unjeli sve podatke!");
            }
        }

        private void ProvjeraUnosa(KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        public void PopuniKorisnike()
        {
            OtvoriKonekciju();

            OleDbCommand ucitajKorisnikeCmd = new OleDbCommand("SELECT ID, Ime, Prezime FROM Korisnik ORDER BY Ime ASC", konekcija);
            reader = ucitajKorisnikeCmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("Ime", typeof(string));
            dt.Columns.Add("Prezime", typeof(string));
            dt.Columns.Add("ImePrezime", typeof(string), "Ime + ' ' + Prezime");
            dt.Load(reader);

            cbStariKorisnik.ValueMember = "ImePrezime";
            cbStariKorisnik.DisplayMember = "ImePrezime";
            cbStariKorisnik.DataSource = dt;

            ZatvoriKonekciju();
        }

        private void BtnStariKorisnikStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLozinka.Text))
            {
                if (ProvjeriKorisnika())
                {
                    Form formToShow = new Troskovi(IDKorisnika, panel2);
                    DisplayForm(formToShow);
                    panel2.Controls.Clear();
                    panel2.Controls.Add(formToShow);
                }
                else
                {
                    MessageBox.Show("Neispravno ime ili lozinka!");
                }

            }
            else
            {
                MessageBox.Show("Niste unjeli lozinku!");
            }
        }

        private void TbNoviKorisnikIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeraUnosa(e);
        }

        private void TbNoviKorisnikPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            ProvjeraUnosa(e);
        }

        private void TbPrimanje_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ',';

        }

        private void CheckBox_Show_Hide_CheckedChange(object sender, EventArgs e)
        {
            if (cbLozinka.Checked)
            {
                tbLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbLozinka.UseSystemPasswordChar = true;
            }
            if (cbNovaLozinka.Checked)
            {
                tbNovaLozinka.UseSystemPasswordChar = false;
            }
            else
            {
                tbNovaLozinka.UseSystemPasswordChar = true;
            }
        }

        private void BtnObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbLozinka.Text))
            {
                if (ProvjeriKorisnika())
                {
                    var korisnik = cbStariKorisnik.SelectedValue.ToString();
                    string[] ime = korisnik.Split();
                    OtvoriKonekciju();
                    OleDbCommand obrisiTroskoveKorisnikaCmd = new OleDbCommand("DELETE FROM Trosak WHERE IDKorisnika=" + IDKorisnika, konekcija);
                    OleDbCommand obrisiDodatneTroskoveKorisnikaCmd = new OleDbCommand("DELETE FROM VrstaTroska WHERE IDKorisnika=" + IDKorisnika, konekcija);
                    OleDbCommand obrisiKorisnikaCmd = new OleDbCommand("DELETE FROM Korisnik WHERE ID=" + IDKorisnika, konekcija);
                    obrisiTroskoveKorisnikaCmd.ExecuteNonQuery();
                    obrisiDodatneTroskoveKorisnikaCmd.ExecuteNonQuery();
                    obrisiKorisnikaCmd.ExecuteNonQuery();
                    ZatvoriKonekciju();
                    MessageBox.Show($"Izbrisan je korisnik {ime[0]} {ime[1]} i svi njegovi troškovi");
                    PopuniKorisnike();
                    tbLozinka.Clear();
                    tbLozinka.UseSystemPasswordChar = true;
                    cbLozinka.Checked = false;
                }
                else
                {
                    MessageBox.Show("Neispravno ime ili lozinka!");
                }
            }
            else
            {
                MessageBox.Show("Niste unjeli lozinku!");
            }
        }

        private bool ProvjeriKorisnika()
        {
            string lozinka = "";
            OtvoriKonekciju();

            var korisnik = cbStariKorisnik.SelectedValue.ToString();
            string[] ime = korisnik.Split();
            OleDbCommand selectIDCmd = new OleDbCommand("SELECT ID, Lozinka FROM Korisnik WHERE Ime='" + ime[0] + "' and Prezime='" + ime[1] + "'", konekcija);
            reader = selectIDCmd.ExecuteReader();
            while (reader.Read())
            {
                IDKorisnika = reader.GetInt32(0);
                lozinka = reader.GetString(1);
            }
            ZatvoriKonekciju();

            return tbLozinka.Text == lozinka;
        }
    }

}
