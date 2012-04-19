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
        int stevec, imenovalec;

        public ZaporedjeTonov()
        {
            this.zaporedje = new List<Znak>();
            this.tempo = 120;
            this.takt = 1;
            this.stevec = 4;
            this.imenovalec = 4;
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

        public void setTempo(int tempo)
        {
            this.tempo = tempo;
        }

        public int getTempo()
        {
            return this.tempo;
        }

        public void setTakt(int stevec, int imenovalec)
        {
            this.stevec = stevec;
            this.imenovalec = imenovalec;
            this.takt = Convert.ToDouble(stevec) / Convert.ToDouble(imenovalec);
        }

        public double getTakt()
        {
            return this.takt;
        }

        public string getPorocilo()
        {
            string porocilo = "Ključ: " + "\n";
            porocilo += "Tempo: " + this.tempo.ToString() + " bpm" + "\n";
            porocilo += "Takt: " + this.stevec.ToString() + " / " + this.imenovalec;
            return porocilo;
        }
    }
}
