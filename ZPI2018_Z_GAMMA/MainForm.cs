﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPI2018_Z_GAMMA
{
   

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        string WybranaOperacja = "";
        string WalutaA = "";
        string WalutaB = "";
        string CzasZakres = "";

        private void ProcessChoice()
        {
            if(CzasZakres == "" && WybranaOperacja != "ROZKLAD")
            {
                 MessageBox.Show("Wybierz zakres czasu",
                 "Wybierz Parametry",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation,
                 MessageBoxDefaultButton.Button1);
                return;
            }

            if (WybranaOperacja == "")
            {
                MessageBox.Show("Wybierz operacje do wykonania",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }

            if (WybranaOperacja == "ROZKLAD" && (WalutaA=="" || WalutaB==""))
            {
                MessageBox.Show("Wybierz dwie waluty",
                "Wybierz Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                return;
            }
            /*
            MessageBox.Show("WybranaOperacja " + WybranaOperacja + " CzasZakres " + CzasZakres + " Waluta " + WalutaA,
                "Wybrane Parametry",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
                */
            return;
        }

        private void Mediana_CheckedChanged(object sender, EventArgs e)
        {
            if (Mediana.Checked)
                WybranaOperacja = "MEDIANA";
        }

        private void Dominata_CheckedChanged(object sender, EventArgs e)
        {
            if(Dominata.Checked)
                WybranaOperacja = "DOMINATA"; 

        }

        private void Sesje_CheckedChanged(object sender, EventArgs e)
        {
            if (Sesje.Checked)
                WybranaOperacja = "SESJE";
        }

        private void OdchylenieStd_CheckedChanged(object sender, EventArgs e)
        {
            if (OdchylenieStd.Checked)
                WybranaOperacja = "ODCHYLENIESTD";
        }

        private void WspolczynnikZmiennosci_CheckedChanged(object sender, EventArgs e)
        {
            if (WspolczynnikZmiennosci.Checked)
                WybranaOperacja = "WSPOLZMIEN";
        }

        private void RozkladCzestosci_CheckedChanged(object sender, EventArgs e)
        {
            if (RozkladCzestosci.Checked)
                WybranaOperacja = "ROZKLAD";
        }
        private void Waluta_SelectedIndexChanged(object sender, EventArgs e)
        {
             WalutaA = Waluta.GetItemText(Waluta.SelectedItem);
        }

        private void Waluta2_SelectedIndexChanged(object sender, EventArgs e)
        {
             WalutaB = Waluta2.GetItemText(Waluta2.SelectedItem);
        }

        private void Czas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CzasZakres = Czas.GetItemText(Czas.SelectedItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ProcessChoice();
        }
    }
}
