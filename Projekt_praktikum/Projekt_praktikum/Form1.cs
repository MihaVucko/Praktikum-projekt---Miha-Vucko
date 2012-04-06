using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projekt_praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ZaporedjeTonov mojeZaporedje = new ZaporedjeTonov();
            mojeZaporedje.dodajNoto("C", 0, 1);
            mojeZaporedje.dodajNoto("D", 1, 1);
            mojeZaporedje.dodajNoto("B", 7, 1);
            mojeZaporedje.dodajPavzo(1);
            MessageBox.Show(mojeZaporedje.porocilo());
        }
    }
}
