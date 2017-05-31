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
using System.Threading;

namespace VB2_2017
{//test aendernung 
    public partial class SchiffeVersenkenForm : Form  // 1a
    {
        /** 1d
         * */
        private Button[] spielfeldButtons = new Button[100]; 
        public bool firstTimeClick = true;
        public int anzahlVersucheClick = 0;
        public int timerValue = 0;

        /** 1e
         * */
        SchiffeVersenken mySchiffeVersenken = new SchiffeVersenken();
        SpielstandEintragenForm mySpielstandEintragenForm = new SpielstandEintragenForm();
        SpielstandAnzeigenFormen mySpielstandAnzeigenForm = new SpielstandAnzeigenFormen();
        Hilfe myMilfe = new Hilfe();


        /** 1f
         * */
        const string RANGLISTENPFAD = "../../dateien/rangliste.txt";

        public SchiffeVersenkenForm()
        {
            InitializeComponent();

            /** 1g
             * -Genereriert die Felder nach der vorgegebenen Benennung
             * */  
            felderGenerieren();

            /** 1h
             * -Button 'btnStart' ist klickbar
             * -Button 'btnBestenliste' ist klickbar
             * -Button 'chkZufaelligesSpiel' ist klickbar
             * -Button 'btnRadar' ist nicht aktiviert
             * -Label 'lblGeloest' ist nicht sichtbar
             * */
            btnStart.Enabled = true;
            btnBestenliste.Enabled = true;
            ckbZufaelligesSpiel.Enabled = true;
            btnRadar.Enabled = false;
            lblGeloest.Visible = false;

            EnableSpielfeld(false);


            /** 3b
             * */

        }
        /** 1i
         * @params:schalter
         * -Setzt die Buttons im ButtonArray 'spielfeldbuttons' auf den wert @param:schalter
         * */
        private void EnableSpielfeld(bool schalter)
        {
            foreach (Button spielButton in spielfeldButtons)
            {
                spielButton.Enabled = schalter;
            }
        }

        /**
         * Generiert in dem ButtonArray 'spielfeldButtons' neue Buttons
         * */
        private void felderGenerieren()
        {
            string[] bezeichnung1 = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", };
            string[] bezeichnung2 = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", };
            int position = 0;
            int hoeheBreite = 35;

            int xPos = 35;
            int yPos = 10;
            for (int i = 0; i < 10; i++)
            {
                for (int o = 0; o < 10; o++)
                {
                    spielfeldButtons[position] = new Button();
                    spielfeldButtons[position].Size = new Size(hoeheBreite, hoeheBreite);
                    spielfeldButtons[position].TabIndex = 0;
                    spielfeldButtons[position].TabStop = false;
                    spielfeldButtons[position].Location = new Point(xPos, yPos);
                    spielfeldButtons[position].Name = "btn" + bezeichnung1[o] + bezeichnung2[i];
                    spielfeldButtons[position].Text = "";
                    spielfeldButtons[position].FlatStyle = FlatStyle.Flat;
                    spielfeldButtons[position].UseVisualStyleBackColor = true;
                    spielfeldButtons[position].BackColor = System.Drawing.Color.DarkGray;
                    this.spielfeldButtons[position].Click += new EventHandler(this.btnSpielfeld_Click);
                    this.Controls.Add(spielfeldButtons[position]);

                    xPos += hoeheBreite + 5;
                    position++;
                }
                yPos += hoeheBreite + 5;
                xPos = hoeheBreite;
            }
        }

        /** 1m
         * @param:sender
         * @param:e
         * -Prüft ob das Objekt wirklich ein Button ist
         * -Startet Timer falls nötig
         * -Button wird aufgedeckt
         * -Button wird deaktiviert
         * -Label 'lblVersuchEff' wird erhöht
         * -Prüft ob das Spiel gewonnen wurde 
         * */
        private void btnSpielfeld_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                
                bool status = false, treffer = true;
                int position = 0; //ButtonObjekt Position im Array
                Button btn = sender as Button; //Aktueller Button aus dem object

                position = arrayPosition(btn); //Ermittelt die eindimesionale Position im Array

                if (firstTimeClick)
                {
                    btnRadar.Enabled = false;
                    tmrSpiel.Start();
                    firstTimeClick = false;
                    ckbZufaelligesSpiel.Enabled = false;
                }

                if (btn.BackColor == Color.DarkGray)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }


                if (mySchiffeVersenken.FeldAufdecken(position, treffer) == true)
                {
                    treffer = true;
                }
                else
                {
                    treffer = false;
                }

                Aufdecken(btn, status, treffer); //Deckt den jeweiligen Buttion auf 
                anzahlVersucheClick++; 
                lblVersucheEff.Text = anzahlVersucheClick.ToString();


                if (mySchiffeVersenken.SpielGewonnen())
                {
                    Thread.Sleep(500);
                    tmrSpiel.Stop();
                    AlleAufdecken(true);
                    lblGeloest.Visible = true;
                    btnStart.Enabled = true;
                    Thread.Sleep(1000);
                    mySpielstandEintragenForm.zeit = timerValue.ToString();
                    mySpielstandEintragenForm.pfad = RANGLISTENPFAD;
                    mySpielstandEintragenForm.punkte = anzahlVersucheClick.ToString();
                    mySpielstandEintragenForm.ShowDialog();
                    firstTimeClick = true;
                    ckbZufaelligesSpiel.Checked = false;
                    ckbZufaelligesSpiel.Enabled = true;
                }
            }
        }

        /** 1j
         * */

        private void Aufdecken(Button aktuellerButton, bool status, bool mitTreffer)
        {
            if (mitTreffer)
            {
                aktuellerButton.BackColor = Color.Red;
                aktuellerButton.Enabled = status;
            }

            if (!mitTreffer)
            {
                aktuellerButton.BackColor = Color.Blue;
                aktuellerButton.Enabled = status;
            }
        }

        /** 1k
         * @param:status
         * -Wechselt den jeweiligen status der Buttons (nicht ausgewaehlt, schiff, wasser)
         * */
        private void AlleAufdecken(bool status)
        {
            if (status)
            {
                foreach (Button btn in spielfeldButtons)
                {
                    int position = arrayPosition(btn);
                    if (mySchiffeVersenken.FeldAufdecken(position, false) == true)
                    {
                        btn.BackColor = Color.Red;
                    }
                    else
                    {
                        btn.BackColor = Color.Blue;
                    }
                }
            }
            else if (!status)
            {
                foreach (Button btn in spielfeldButtons)
                {
                    btn.BackColor = Color.DarkGray;
                }
            }

        }
         

        /** 1p
         * @param:sender
         * @param:e
         * -Deckt alle Felder Auf
         **/
        private void btnRadar_MouseDown(object sender, MouseEventArgs e)
        {
            AlleAufdecken(true);

        }

        /** 1q
         * @param:sender
         * @param:e
         * -Deckt alle Felder zu
         * */
        private void btnRadar_MouseUp(object sender, MouseEventArgs e)
        {
            AlleAufdecken(false);

        }

        /** 1r
         * @param:sender
         * @param:e
         * -Erhöht die Zeitangabe
         * -Setztz die Zeit
         * */
        private void tmrSpiel_Tick(object sender, EventArgs e)
        {
            timerValue += 1;
            lblZeitEff.Text = timerValue.ToString();
        }

        /**
         * @param:btn
         * Ermittelt die eindimensionale ArrayPosition
         * */
        private int arrayPosition(Button btn)
        {

            string name = btn.Name;
            name = name.Replace("btn", "");
            int position = 0;


            foreach (Button b in spielfeldButtons)
            {
                switch (name[0])
                {
                    case 'A': position += 0; break;
                    case 'B': position += 10; break;
                    case 'C': position += 20; break;
                    case 'D': position += 30; break;
                    case 'E': position += 40; break;
                    case 'F': position += 50; break;
                    case 'G': position += 60; break;
                    case 'H': position += 70; break;
                    case 'I': position += 80; break;
                    case 'J': position += 90; break;
                    default: break;
                }


                switch (name[1])
                {
                    case '1': position += 0; break;
                    case '2': position += 1; break;
                    case '3': position += 2; break;
                    case '4': position += 3; break;
                    case '5': position += 4; break;
                    case '6': position += 5; break;
                    case '7': position += 6; break;
                    case '8': position += 7; break;
                    case '9': position += 8; break;
                    default: break;
                }

                if (name.Length == 3)
                {
                    position += 9;
                }
            }
            position = position / 100;
            return position;
        }

        /**
         * Setzt die Farbe der Buttons auf den Standardwert 'Grau' zurück
         * */
        private void felderReset()
        {
            foreach (Button btn in spielfeldButtons)
            {
                btn.BackColor = Color.DarkGray;
            }
        }

        /** 1l
         * @param:sender
         * @param:e
         * interpretiert den Konpfdruck des Buttons 'btnStart'
         * */
        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (ckbZufaelligesSpiel.Checked == false)
            {
                mySchiffeVersenken.SpielfeldFuellen();
            }
            else
            {
                //mySchiffeVersenken.ZufallWuerflen(); ist obsolet da dies beim Eventlistener von 'ckhZufealligesSpiel'
            }
            lblVersucheEff.Text = "0";
            lblZeitEff.Text = "0";
            anzahlVersucheClick = 0;
            timerValue = 0;
            btnStart.Enabled = false;
            btnRadar.Enabled = true;
            lblGeloest.Visible = false;
            EnableSpielfeld(true);
            felderReset();
        }

        private void btnBestenliste_Click(object sender, EventArgs e)
        {
            mySpielstandAnzeigenForm.pfad = RANGLISTENPFAD;
            mySpielstandAnzeigenForm.ShowDialog();
        }

        private void ckbZufaelligesSpiel_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;

            if (chk.Checked == true)
            {
                mySchiffeVersenken.ZufallWuerflen();
            }
        }

        private void SchiffeVersenkenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRadar_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            myMilfe.ShowDialog();
        }
    }
}
