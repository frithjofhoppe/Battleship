using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace VB2_2017
{
    /* *********************************************************************** */
    /* Diese Klasse händelt die Logik für das Schiffe versenken Spiel. Die     */
    /* Klasse ist vollständig. Es müssen keine Änderungen mehr vorgenommen     */
    /* werden.                                                                 */
    /* *********************************************************************** */
    class SchiffeVersenken // 2a
    {
        // Spielfeld mit Schiffen 
        private bool[,] spielFeld;  // 2b
        private bool[][,] spielFelder = new bool[11][,];  // 2c
        private int gewaehltesSpiel;  // 2d
        private int treffer;  // 2e
        private const int SPIELFELDGROESSE = 10;  // 2f
        private const int MAXTREFFER = 20;  // 2f
        private int[,] korrektePosition = new int[2, 5];
        public string name = "out.txt";
        public List<String> t = new List<string>();

        public SchiffeVersenken()
        {

            // 2g
            spielFelder[0] = new bool[10, 10] { { true,  true,  true,  true,  false, false, false, false, true,  true },
                                                { false, false, false, false, false, true,  false, false, false, false },
                                                { false, false, false, false, false, true,  false, false, false, false },
                                                { false, false, false, false, false, true,  false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, true,  true,  false, false, true,  false, true,  false, false },
                                                { false, false, false, false, false, false, false, true,  false, false },
                                                { false, false, false, false, false, false, false, true,  false, false },
                                                { false, false, false, true,  false, false, false, false, false, false },
                                                { true,  false, true,  true,  false, false, false, false, false, true  }};
            spielFelder[1] = new bool[10, 10] { { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, true,  true,  true,  false, true,  true,  true,  false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, true,  true,  false, true,  true,  false, true,  false, false },
                                                { false, false, false, false, false, false, false, true,  false, false },
                                                { true,  false, true,  false, false, true,  false, true,  false, false },
                                                { false, false, false, false, false, true,  false, true,  false, false },
                                                { false, false, false, true,  false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, true  }};
            spielFelder[2] = new bool[10, 10] { { true,  false, false, false, true,  false, false, true,  false, true  },
                                                { true,  false, false, false, true,  false, false, false, false, false },
                                                { true,  false, false, false, false, false, false, false, false, false },
                                                { false, false, true,  false, false, false, true,  true,  true,  true  },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, true,  false, false, false, false, true,  false, false },
                                                { true,  false, true,  false, false, false, false, true,  false, false },
                                                { true,  false, true,  false, false, false, false, false, false, false },
                                                { false, false, false, false, false, true,  false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false }};
            spielFelder[3] = new bool[10, 10] { { false, false, false, false, false, false, false, false, false, false },
                                                { false, true,  false, false, true,  true,  false, false, true,  false },
                                                { false, true,  false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, true,  false, false, false },
                                                { false, false, false, false, true,  false, true,  false, true,  false },
                                                { false, true,  false, false, true,  false, true,  false, false, false },
                                                { false, true,  false, false, true,  false, false, false, false, false },
                                                { false, false, false, false, true,  false, false, false, false, false },
                                                { false, true,  false, false, false, false, false, false, false, false },
                                                { false, false, false, true,  false, false, false, true,  true,  true }};
            spielFelder[4] = new bool[10, 10] { { false, false, false, false, false, true,  false, true,  true,  true  },
                                                { false, false, false, false, false, true,  false, false, false, false },
                                                { true,  false, true,  true,  false, false, false, true,  false, true  },
                                                { true,  false, false, false, false, false, false, false, false, false },
                                                { false, false, false, true,  false, false, true,  true,  true,  false },
                                                { true,  false, false, true,  false, false, false, false, false, false },
                                                { false, false, false, true,  false, false, false, false, false, false },
                                                { false, false, false, true,  false, false, false, false, false, false },
                                                { false, true,  false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false }};
            spielFelder[5] = new bool[10, 10] { { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, true,  false, false, true,  true,  true,  false, false },
                                                { false, false, true,  false, false, false, false, false, false, false },
                                                { false, false, true,  false, false, true,  false, false, true,  false },
                                                { false, false, true,  false, false, true,  false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, true,  false, true,  false, false, true,  false, false },
                                                { false, false, true,  false, false, false, false, true,  false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { true,  false, true,  false, true,  true,  true,  false, false, false }};
            spielFelder[6] = new bool[10, 10] { { true,  false, false, false, false, false, false, false, false, false },
                                                { false, false, false, false, true,  true,  true,  false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, true,  false, false, true,  false, false, true,  true  },
                                                { false, false, true,  false, false, true,  false, false, false, false },
                                                { false, false, true,  false, false, false, false, true,  false, false },
                                                { false, false, true,  false, false, false, false, true,  false, false },
                                                { false, false, false, false, true,  false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { true,  true,  true,  false, false, true,  false, false, false, true  }};
            spielFelder[7] = new bool[10, 10] { { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { true,  false, false, false, false, false, false, true,  false, false },
                                                { false, false, false, false, false, false, false, true,  false, false },
                                                { false, true,  false, true,  true,  true,  false, false, false, false },
                                                { false, false, false, false, false, false, false, true,  false, false },
                                                { true,  false, false, true,  true,  true,  false, true,  false, true  },
                                                { false, false, false, false, false, false, false, false, false, true  },
                                                { false, true,  false, true,  true,  true,  true,  false, false, false }};
            spielFelder[8] = new bool[10, 10] { { false, true,  false, false, false, false, false, false, false, true  },
                                                { false, false, false, false, true,  true,  false, true,  false, false },
                                                { false, true,  false, false, false, false, false, false, false, false },
                                                { false, true,  false, false, false, false, false, false, false, false },
                                                { false, false, false, true,  true,  true,  true,  false, false, false },
                                                { false, false, false, false, false, false, false, false, true,  false },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, true,  false, true,  false, true,  true,  false, false, false },
                                                { false, true,  false, true,  false, false, false, false, false, false },
                                                { false, true,  false, true,  false, false, false, false, false, false }};
            spielFelder[9] = new bool[10, 10] { { false, false, false, false, false, false, false, true,  true,  true  },
                                                { false, false, false, false, false, false, false, false, false, false },
                                                { false, false, false, false, false, false, false, false, false, true  },
                                                { false, false, true,  true,  false, false, true,  false, false, true  },
                                                { false, false, false, false, false, false, true,  false, false, true  },
                                                { false, false, false, false, true,  false, false, false, false, false },
                                                { false, true,  false, false, true,  false, false, true,  false, false },
                                                { false, true,  false, false, false, false, false, false, false, true  },
                                                { false, true,  false, false, false, false, false, true,  false, false },
                                                { false, true,  false, false, false, false, false, false, false, true  }};
            spielFelder[10] = new bool[10, 10] { { false, false,  false, false, false, false, false, false, false, false  },
                                                { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false,  false, false, false, false, false, false, false, false  },
                                                { false, false,  false, false, false, false, false, false, false, false  },
                                                { false, false,  false, false, false, false, false, false, false, false  },
                                                { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false,  false, false, false, false, false, false, false, false },
                                                { false, false,  false, false, false, false, false, false, false, false  }};

            gewaehltesSpiel = 0;
        }

        // 2h
        public void SpielfeldFuellen()
        {
            // Zufälliges Spiel wählen
            Random zufall = new Random();
            gewaehltesSpiel = zufall.Next(0, 10);

            // Spiel in das aktuelle Spiel einfügen.
            spielFeld = spielFelder[gewaehltesSpiel];

            // Es gibt noch keine Treffer.
            treffer = 0;
        }

        // 2i
        public bool FeldAufdecken(int buttonPosition, bool mitTreffer)
        {
            bool feldInhalt = spielFeld[(buttonPosition % SPIELFELDGROESSE), (buttonPosition / SPIELFELDGROESSE)];
            int a = buttonPosition % SPIELFELDGROESSE;
            int b = buttonPosition / SPIELFELDGROESSE;


            if (mitTreffer)
                treffer += (feldInhalt ? 1 : 0);
            return feldInhalt;
        }

        // 2j
        public bool SpielGewonnen()
        {
            return (treffer > MAXTREFFER - 1);
        }

        /**
         * -Initiiert das Zufällige Wuerflen
         * -Setzt alle Einstellungen zurück
         * */
        public void ZufallWuerflen()
        {
            spielFeld = spielFelder[10];
            resetField();
            writeClear();

            int[] laenge = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };

            for (int i = 0; i < laenge.Length; i++)
            {                
                generieren(laenge[i]);
            }
            writeDown();
        }

        public void resetField()
        {
            for (int o = 0; o < 10; o++)
            {
                for (int i = 0; i < 10; i++)
                {
                    spielFeld[o, i] = false;
                }
            }
        }

        /**
         * @param:laenge
         * -Routine zum Erstellen der Würfel
         * */
        public void generieren(int laenge)
        {
            bool druchlauf = true;

            int xPosition = 0;
            int yPosition = 0;
            int richtung = 1;

            Random rnd1 = new Random();


            xPosition = rnd1.Next(0, 9);
            yPosition = rnd1.Next(0, 9);

            while (druchlauf)
            {

                Array.Clear(korrektePosition,0,8);

                korrektePosition[0, 0] = yPosition;
                korrektePosition[1, 0] = xPosition;

                if (checkLocationStart(korrektePosition[0, 0], korrektePosition[1, 0],laenge,richtung) == false) //erste Position
                {
                    generateNewPositionsValues(korrektePosition[0, 0], korrektePosition[1, 0],richtung,laenge);

                    if (checkGeneratedPositions(richtung,korrektePosition,laenge))
                    {
                        setPosition(korrektePosition,laenge);
                        druchlauf = false;
                    }
                }

                richtung++;


                if (richtung == 4)
                {
                    richtung = 1;
                    xPosition = rnd1.Next(0, 9);
                    yPosition = rnd1.Next(0, 9);
                }
            }
        }

        /**
         * @param:x
         * @param:y
         * @param:laenge
         * @param:richtung
         * -Überprüft ob die Startposition des Schiffes nicht über den Feldrand hinausgeht.
         * */
        public bool checkLocationStart(int y, int x, int laenge,int richtung)
        {
            bool rueckgabe = false;
            bool platz = false;
          

            for (int i = 0; i < laenge; i++)
            {
                if (richtung == 1)
                {
                    if(y - laenge < 0) { platz = true; }
                }
                if (richtung == 2)
                {
                    if (x + laenge > 10) { platz = true; }
                }
                 if (richtung == 3)
                {
                    if (y + laenge > 10) { platz = true; }
                }
                 if (richtung == 4)
                {
                    if (x - laenge < 0) { platz = true; }
                }
            }

            if (checkField(y, x) && platz == false && checkOriginPoint(y,x) == false)
            {
                rueckgabe = false;
            }
            else
            {
                rueckgabe = true;
            }
            return rueckgabe;
        }

        public bool chekcLocationField(int y, int x)
        {
            bool rueckgabe = false;



            return rueckgabe;
        }

        /**
         * @param:x
         * @param:y
         * -Prüft ob der Auganganspunkt nicht bereits im Spielfeld belegt ist
         * */
        public bool checkOriginPoint(int y, int x)
        {
            bool rueckgabe = true;

            rueckgabe = spielFeld[y, x];

            return rueckgabe;
        }

        /**
         * @param:y
         * @param:x
         * @param:richung
         * @param:laenge
         * -Erzeugt neue Positionen in die jeweilige Richtung
         * */
        public void generateNewPositionsValues(int y,int x,int richtung,int laenge)
        {
            int wertX = 0;
            int wertY = 0;
            int actX = x;
            int actY = y;

            switch (richtung)
            {
                case 1: wertY = -1; wertX = 0; break;
                case 2: wertY =  0; wertX = 1; break;
                case 3: wertY =  1; wertX = 0; break; //aenderung -1
                case 4: wertY = 0; wertX = -1; break;
                default:break;
            }
          
            t.Add(korrektePosition[1, 0] + "ä" + korrektePosition[0, 0]);
            for (int i = 1; i <= laenge; i++)
            {
                actX += wertX;
                actY += wertY;
                korrektePosition[0, i] = actY;
                korrektePosition[1, i] = actX;
            }
        }

        /**
         * @param:richtung
         * @param:positionen
         * @param:laenge
         * -Überprüft ob die generierten Positionen vom Schiff belegbar sind bzw. den Anforderungen entsprechen
         * */
        public bool checkGeneratedPositions(int richtung, int[,] positionen,int laenge)
        {
            bool rueckgabe = false;
            int anzahl = 0;
            

            for (int i = 0; i < laenge; i++)
            {
               
                if (checkPosition(positionen[0, i], positionen[1, i],richtung,laenge))
                {
                    anzahl++;
                }
            }

            if (anzahl == laenge)
            {
                rueckgabe = true;
            }

            return rueckgabe;
        }

        /**
         * @param:x
         * @param:y
         * @param:richtung
         * @param:laenge
         * -Üperprüft einzelne Positionen
         * */
        public bool checkPosition(int y, int x,int richtung,int laenge)
        {
            bool rueckgabe = true;   
            rueckgabe = checkField(y, x);
            return rueckgabe;   
        }

        /**
         * @param:y
         * @param:x
         * -Prüft ob die Felder in der umgebung der Position bereits besetzt sind
         * */
        public bool checkField(int y, int x)
        {
            bool rueckgabe = true;
            bool r = true;

            if (y == 0) 
            {
                if (x == 0)
                {
                    if (spielFeld[y, x + 1] == false && spielFeld[y + 1, x + 1] == false && spielFeld[y + 1, x] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x != 0 && x != 9)
                {
                    if (spielFeld[y, x - 1] == false && spielFeld[y + 1, x - 1] == false && spielFeld[y+1, x + 1] == false && spielFeld[y, x + 1] == false && spielFeld[y + 1, x] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x == 9)
                {
                    if (spielFeld[y, x - 1] == false && spielFeld[y + 1, x - 1] == false && spielFeld[y + 1, x] == false) { rueckgabe = r; }
                    else { rueckgabe = false; }
                }
            }
            else if (y != 0 && y != 9)
            {
                if (x == 0)
                {
                    if (spielFeld[y - 1, x] == false && spielFeld[y - 1, x + 1] == false && spielFeld[y, x + 1] == false && spielFeld[y + 1, x + 1] == false && spielFeld[y + 1, x] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x != 0 && x != 9)
                {
                    if (spielFeld[y - 1, x] == false && spielFeld[y - 1, x + 1] == false && spielFeld[y, x + 1] == false && spielFeld[y + 1, x + 1] == false && spielFeld[y + 1, x] == false && spielFeld[y + 1, x - 1] == false && spielFeld[y, x - 1] == false && spielFeld[y - 1, x - 1] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x == 9)
                {
                    if (spielFeld[y - 1, x] == false && spielFeld[y - 1, x - 1] == false && spielFeld[y, x - 1] == false && spielFeld[y + 1, x - 1] == false && spielFeld[y + 1, x] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
            }
            else if (y == 9)
            {
                if (x == 0)
                {
                    if (spielFeld[y - 1, x] == false && spielFeld[y - 1,x - 1] == false && spielFeld[y, x - 1] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x != 0 && x != 9)
                {
                    if (spielFeld[y, x - 1] == false && spielFeld[y - 1, x - 1] == false && spielFeld[y - 1, x] == false && spielFeld[y - 1, x + 1] == false && spielFeld[y, x + 1] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
                else if (x == 9)
                {
                    if (spielFeld[y, x - 1] && spielFeld[y - 1, x - 1] == false && spielFeld[y - 1, x] == false)
                    {
                        rueckgabe = r;
                    }
                    else { rueckgabe = false; }
                }
            }
            else { MessageBox.Show("fehler"); }

            return rueckgabe;
        }

        /**
         * @param:positionen
         * @param:laenge
         * -Fügt die neuen Positionen dem Spielfeld hinzu
         * */
        public void setPosition(int[,] positionen,int laenge)
        {
            for(int i = 0; i < laenge;i++)
            {
                spielFeld[positionen[0, i], positionen[1, i]] = true;
            }
        }

        public void writeDown()
        {
           File.AppendAllLines(name, t);
        }

        public void writeClear()
        {
            File.WriteAllText(name, " ");
        }
    }
}
