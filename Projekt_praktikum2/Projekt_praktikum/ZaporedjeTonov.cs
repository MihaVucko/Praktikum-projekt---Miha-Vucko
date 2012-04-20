using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projekt_praktikum
{
    class ZaporedjeTonov
    {
        private List<Znak> zaporedje;
        private int tempo;
        private double takt;

        public ZaporedjeTonov()
        {
            this.zaporedje = new List<Znak>();
            this.tempo = 120;
            this.takt = 1;
        }

        public ZaporedjeTonov(int tempo, double takt)
        {
            this.zaporedje = new List<Znak>();
            this.tempo = tempo;
            this.takt = takt;
        }

        public void dodajNoto(string ton, int oktava, double trajanje)
        {
            this.zaporedje.Add(new Znak(trajanje, ton, oktava));
        }

        public void dodajPavzo(double trajanje)
        {
            this.zaporedje.Add(new Znak(trajanje));
        }

        public void izbrisi(int index)
        {
            if (index < this.zaporedje.Count)
            {
                this.zaporedje.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Napaka!");
            }
        }

        public List<Znak> getZaporedje()
        {
            return this.zaporedje;
        }        
    }
}
