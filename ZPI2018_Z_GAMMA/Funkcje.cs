using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZPI2018_Z_GAMMA
{
    class Funkcje
    {
        public void myMessage(string v)
        {
            MessageBox.Show(v,
              "Important Note",
              MessageBoxButtons.OK,
              MessageBoxIcon.Exclamation,
              MessageBoxDefaultButton.Button1); 
        }

        public int IloscSesji (string wal, List<Waluta> dane)
        {
            int sSpad = 0;
            int sBezZmian = 0;
            int sWzrost = 0;
            float tmpVal = 0;

            for (int a= 0; a < dane.Count(); a++)
            {

                if (a == 0)
                {
                    tmpVal = dane[a].Wartosc;
                    continue;
                }
                else
                {
                    if (tmpVal == dane[a].Wartosc)
                        sBezZmian++;
                    if (tmpVal < dane[a].Wartosc)
                        sWzrost++;
                    if (tmpVal > dane[a].Wartosc)
                        sSpad++;
                    tmpVal = dane[a].Wartosc;
                }
            }

            if (dane.Count() < 2)
            {
                 MessageBox.Show("Zbyt mała ilośc danych do obliczenia sesji",
                 "Ważne",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
                return 0;
            }

                MessageBox.Show("Ilość notowań: " + dane.Count() + " Sesje rosnące: " + sWzrost + " sesje malejące " + sSpad + " sesje bez zmian " + sBezZmian,
                "Wynik",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                return dane.Count();
        }

        public float Mediana(string wal, List<Waluta> dane)
        {
            return 0;
        }

        public class Waluta
        {
            public float Wartosc;
        }

        public List<Waluta> getData( string wal, string dni)
        {
            List<Waluta> list = new List<Waluta>();
            try
            {
                string link = "http://api.nbp.pl/api/exchangerates/rates/A/" + wal + "/last/" + dni + "?format=xml";
              

                XDocument xDoc = XDocument.Load(link);
                list = xDoc.Descendants("Rate")
                            .Select(o => new Waluta
                            {
                                Wartosc = (float)o.Element("Mid"),
                            })
                            .ToList();
                int lc = list.Count();
                string str = lc.ToString();

             
            }
            catch
            {
                MessageBox.Show("Nie mozna wygenerować danych",
                " ",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            return list;
        }

    }
}
