# -*- coding: utf-8 -*-
import clr
import System
clr.AddReference("System.Data")
clr.AddReference('System.Windows.Forms')
clr.AddReference('System.Drawing')
clr.AddReference('ScottPlot')
clr.AddReference('System')
from System.Windows.Forms import *
from ScottPlot import *
from System.Web import *
from System.Drawing import *
from System.Data.OleDb import *
from System.Data import *
import System.Array
conStr = r"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Valentina\source\repos\Evidencija troškova\Evidencija troškova\Popis_troskova.accdb;"
con = OleDbConnection(conStr)

def dohvatiPrimanjeKorisnika(IDKorisnika):  
    con.Open()
    command1=OleDbCommand("SELECT Primanje FROM Korisnik WHERE ID=@ID", con) 
    command1.Parameters.AddWithValue("ID", IDKorisnika)   
    reader1=command1.ExecuteReader()
    reader1.Read()
    Primanje=decimal(reader1[0])  
    reader1.Close()
    command1.ExecuteNonQuery()
    con.Close()
    return Primanje
    

def ispisPrimanja(form, IDKorisnika):     
    Primanje=dohvatiPrimanjeKorisnika(IDKorisnika)
    form.textBox1.Text=String.Format("{0:0.00}", Primanje)  #vidi ovo
  

def prikazTroskovaUTablicu(form, IDKorisnika):
    con.Open()
    ds=DataSet()
    dohvatiIznosIDatum = OleDbCommand("SELECT Iznos AS IznosRacuna, Datum  FROM Trosak WHERE IDKorisnika=@ID",con)
    dohvatiIznosIDatum.Parameters.AddWithValue("ID", IDKorisnika)   
    adapter = OleDbDataAdapter(dohvatiIznosIDatum)
    adapter.Fill(ds,"Stavke")
    form.GridView1.DataSource = ds
    form.GridView1.DataMember="Stavke"
    con.Close()

def dohvatiNaziveTroskova(IDKorisnika):
    con.Open()      
    command1=OleDbCommand("SELECT NazivTroska FROM VrstaTroska WHERE IDKorisnika=@ID OR IDKorisnika=@a", con) 
    command1.Parameters.AddWithValue("ID", IDKorisnika) 
    command1.Parameters.AddWithValue("a", 0) 
    reader=command1.ExecuteReader()
    nazivi=[]
    while reader.Read():
        nazivi.append(str(reader[0]))
    reader.Close()
    command1.ExecuteNonQuery()
    con.Close()
    return nazivi

def prikaziGraf(form, IDKorisnika, DateTimePicker1,DateTimePicker2):
    con.Open()     
    nazivi=dohvatiNaziveTroskova(IDKorisnika)
    command2=OleDbCommand("SELECT ID FROM VrstaTroska WHERE IDKorisnika=@ID OR IDKorisnika=@a", con) 
    command2.Parameters.AddWithValue("ID", IDKorisnika) 
    command2.Parameters.AddWithValue("a", 0) 
    reader=command2.ExecuteReader()
    naziviID=[]
    while reader.Read():
        naziviID.append(int(reader[0]))
    reader.Close()
    command2.ExecuteNonQuery()
    iznosi=[]
    Dohvat=len(naziviID)
    for i in naziviID:
        command=OleDbCommand("SELECT SUM(Iznos) FROM Trosak WHERE  IDKorisnika=@ID AND IDVrsteTroska=@Vrsta AND Datum BETWEEN @od AND @do", con) 
        command.Parameters.AddWithValue("ID", IDKorisnika) 
        command.Parameters.AddWithValue("Vrsta", i) 
        command.Parameters.AddWithValue("od", DateTimePicker1.Value.Date)
        command.Parameters.AddWithValue("do", DateTimePicker2.Value.Date)
        reader=command.ExecuteReader()
        try:
            while reader.Read():
                MessageBox.Show("prije")
                iznosi.append(int(reader[0]))
                MessageBox.Show(str(iznosi))
        except:  
            iznosi.append(0)
        
        reader.Close()
        command.ExecuteNonQuery()

    pointCount = len(naziviID)
    x=DataGen.Consecutive(pointCount) #daje mi od 0 do koliko brojeve imam
    y=System.Array[float](iznosi) #pretvara u odg tip    
    form.formsPlot1.plt.PlotBar(x,y)
    strArray = Array[str](nazivi)
    form.formsPlot1.plt.XTicks(x, strArray)
    form.formsPlot1.plt.Legend()
        
    con.Close()

    
         