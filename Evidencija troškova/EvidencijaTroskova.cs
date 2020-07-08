using System;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Configuration;

namespace Evidencija_troškova
{
    public partial class EvidencijaTroskova : Form
    {
        private int IDKorisnika;
        private ScriptEngine pyEngine;
        private ScriptScope pyScope;
        private string putanjaZaIzracune = ConfigurationManager.AppSettings["pythonSkriptaPutanja"].ToString(); 

        public EvidencijaTroskova(int reader)
        {
            InitializeComponent();
            IDKorisnika = reader;
            pyEngine = Python.CreateEngine(); 
            pyScope = pyEngine.CreateScope(); 
        }

        private void BtnProvjeriStanje_Click(object sender, EventArgs e)
        {
            ScriptSource scriptNewFunction = pyEngine.CreateScriptSourceFromFile(putanjaZaIzracune); 
            scriptNewFunction.Execute(pyScope); 
            dynamic function = pyScope.GetVariable("ispisPrimanja"); 
            function(this, IDKorisnika);
        }

        private void LbPrikazTroskova_Click(object sender, EventArgs e)
        {
            ScriptSource scriptNewFunction = pyEngine.CreateScriptSourceFromFile(putanjaZaIzracune); 
            scriptNewFunction.Execute(pyScope); 
            dynamic function = pyScope.GetVariable("prikazTroskovaUTablicu"); 
            function(this, IDKorisnika);
        }

        private void BtnPrikaziGraf_Click(object sender, EventArgs e)
        {
            DateTimePicker pocetniDatum = dateTimePicker1;
            DateTimePicker krajnjiDatum = dateTimePicker2;
            Form prikazGrafova = new PrikazGrafova(IDKorisnika, pocetniDatum, krajnjiDatum);
            prikazGrafova.ShowDialog();
        }
    }
}
