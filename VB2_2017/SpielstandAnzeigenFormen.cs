using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace VB2_2017
{
    public partial class SpielstandAnzeigenFormen : Form
    {
        public string pfad { get; set; } //Pfad aus der klasse 'SchiffeVersenkenForm'
        int anzahlPersonen = 5;
        string local;
        List<String> datenListe = new List<String>();
        List<String> sortierteDaten = new List<String>();
        
        

        public SpielstandAnzeigenFormen()
        {
            InitializeComponent();
          
            
        }

        /**
         * @param:sender
         * @param:e
         * Reagiert auf das Event 'Load'
         * */
        private void SpielstandAnzeigenFormen_Load(object sender, EventArgs e)
        {

            this.local = this.pfad;
            datenCahcheLoeschen();
            datenLaden();
            datenAuswerten();
            datenAusgeben();
        }

        private void datenLaden()
        {
            foreach (string line in File.ReadLines(local))
            {
                datenListe.Add(line);
            }
        }

        private void datenCahcheLoeschen()
        {
            txtBestenliste.Text = "";
            datenListe.Clear();
            sortierteDaten.Clear();
        }

        private void datenAusgeben()
        {
            try
            {
                if (datenListe.Count < anzahlPersonen)
                {
                    anzahlPersonen = sortierteDaten.Count;
                }

                for (int i = 0; i < anzahlPersonen; i++)
                {
                    txtBestenliste.Text = txtBestenliste.Text + sortierteDaten[i] + Environment.NewLine;
                }
            }
            catch(Exception)
            {

            }
        }

        /**
         * Sortiert die Daten nach den 5 besten Spieler
         * */
        private void datenAuswerten()
        {
            int index = 0;
            int indextreffer = 0;
            int minVersuche = 1000;
            int minZeit = 1000;
            int durchlauefe = 5;

               if(datenListe.Count < 5 &&  datenListe.Count != 1)
               {
                durchlauefe = datenListe.Count;
               
               }
           
            try
            {

                for (int i = 0; i < durchlauefe; i++)
                {
                    minVersuche = 10000;
                    minZeit = 10000;

                    foreach (string line in datenListe)
                    {
                        string[] eintrag = line.Split(';');

                        //   if (Convert.ToInt32(eintrag[2]) <= minVersuche && Convert.ToInt32(eintrag[1]) <= minZeit)
                        if (Convert.ToInt32(eintrag[2]) <= minVersuche && Convert.ToInt32(eintrag[1]) <= minZeit)
                        {

                            minVersuche = Convert.ToInt32(eintrag[2]);
                            minZeit = Convert.ToInt32(eintrag[1]);
                            indextreffer = index;
                        }

                        index++;

                    }

                    sortierteDaten.Add(datenListe[indextreffer]);
                    datenListe.RemoveAt(indextreffer);
                    index = 0;
                    indextreffer = 0;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Datenquelle ist fehlerhaft !!","Fehler",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
            

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            txtBestenliste.Text = "";
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
