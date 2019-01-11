﻿using System;
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
                MessageBox.Show(link,
               " ",
               MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation,
               MessageBoxDefaultButton.Button1);

                XDocument xDoc = XDocument.Load(link);
                list = xDoc.Descendants("Rate")
                            .Select(o => new Waluta
                            {
                                Wartosc = (float)o.Element("Mid"),
                            })
                            .ToList();
                int lc = list.Count();
                string str = lc.ToString();

                MessageBox.Show(str + " " + list[1].Wartosc,
                  "Important Note");
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
