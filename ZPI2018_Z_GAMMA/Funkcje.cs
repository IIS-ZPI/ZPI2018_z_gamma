using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ZPI2018_Z_GAMMA
{
    public class Funkcje
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
            float r = 0;
            //dane.Sort;
            r = dane[(dane.Count / 2)].Wartosc;
            MessageBox.Show("Ilość notowań: " + dane.Count() + " Mediana " + r,
               "Wynik",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            return r;

        }

        public float Dominata(string wal, List<Waluta> dane)
        {
            int[] L = { };
            //tablica liczby wystapien
            int[] W = { };
            int[] tab = { 2, 2, 4, 4, 1, 3, 4, 2, 5, 1, 3, 1, 4, 4 };
   
            //zlicz wystepowanie poszczegolnych liczb w tablicy tab
            for (int i = 0; i < tab.Length; i++)
            {
                //zapytanie czy zawiera - można też zrobić w pętli
                if (L.Contains(tab[i]))
                {
                    int index = Array.IndexOf(L, tab[i]);
                    W[index] += 1;
                }
                else
                {
                    int l = L.Length + 1;
                    int w = W.Length + 1;
                    Array.Resize(ref L, l); //zmiana wielkości tablicy
                    Array.Resize(ref W, w);
                    L[l - 1] = tab[i];      //dodanie nowej wartości
                    W[w - 1] = 1;
                }
            }

            //poszukaj liczbe najczesciej wystepujaca
            int max = 0;
            int indexmax = 0;
            for (int i = 0; i < W.Length; i++)
            {
                if (W[i] > max)
                {
                    max = W[i];
                    indexmax = i;
                }
            }
            return L[indexmax];
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
