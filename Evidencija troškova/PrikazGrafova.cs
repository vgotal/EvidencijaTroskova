using System.Configuration;
using System.Windows.Forms;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Evidencija_troškova
{
    public partial class PrikazGrafova : Form
    {
        ScriptEngine pyEngine = null; 
        ScriptScope pyScope = null;  
        private int IDKorisnika;
        public DateTimePicker pocetniDatum;
        public DateTimePicker krajnjiDatum;
        private string putanjaZaIzracune = ConfigurationManager.AppSettings["pythonSkriptaPutanja"].ToString();

        public PrikazGrafova (int reader, DateTimePicker pocetniDatum, DateTimePicker krajnjiDatum)
        {
            InitializeComponent();
            IDKorisnika = reader;
            this.pocetniDatum = pocetniDatum;
            this.krajnjiDatum = krajnjiDatum;
            pyEngine = Python.CreateEngine(); 
            pyScope = pyEngine.CreateScope(); 
            PrikaziGrafove();
        }

        private void PrikaziGrafove()
        {
            ScriptSource scriptNewFunction = pyEngine.CreateScriptSourceFromFile(putanjaZaIzracune); 
            scriptNewFunction.Execute(pyScope); 
            dynamic function = pyScope.GetVariable("prikaziGraf"); 
            function(this, IDKorisnika, pocetniDatum, krajnjiDatum);
          
        }     
    }
}
