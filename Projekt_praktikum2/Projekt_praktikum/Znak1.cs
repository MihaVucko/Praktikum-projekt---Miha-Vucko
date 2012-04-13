using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt_praktikum
{
    public class Znak
    {
        private double[,] frekvence = new double[,]{{16.35,	17.32,	18.35,	19.45,	20.60,	21.83,	23.12,	24.50,	25.96,	27.50,	29.14,	30.87},
                                                    {32.70,	34.65,	36.71,	38.89,	41.20,	43.65,	46.25,	49.00,	51.91,	55.00,	58.27,	61.74},
                                                    {65.41,	69.30,	73.42,	77.78,	82.41,	87.31,	92.50,	98.00,	103.8,	110.0,	116.5,	123.5},
                                                    {130.8,	138.6,	146.8,	155.6,	164.8,	174.6,	185.0,	196.0,	207.7,	220.0,	233.1,	246.9},
                                                    {261.6,	277.2,	293.7,	311.1,	329.6,	349.2,	370.0,	392.0,	415.3,	440.0,	466.2,	493.9},
                                                    {523.3,	554.4,	587.3,	622.3,	659.3,	698.5,	740.0,	784.0,	830.6,	880.0,	932.3,	987.8},
                                                    {1047,	1109,	1175,	1245,	1319,	1397,	1480,	1568,	1661,	1760,	1865,	1976},
                                                    {2093,	2217,	2349,	2489,	2637,	2794,	2960,	3136,	3322,	3520,	3729,	3951},
                                                    {4186,	4435,	4699,	4978,	5274,	5588,	5920,	6272,	6645,	7040,	7459,	7902}};

        private string[] toni = new string[] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "H" };

        private double trajanje;
        private double frekvenca;
        private string ton;
        private int oktava;
        private bool zvisana;
        private int sirina;

        public Znak(double trajanje)
        {
            this.trajanje = trajanje;
            this.frekvenca = 0;
            this.ton = "pavza";
            this.oktava = -1;
            this.zvisana = false;
            this.sirina = 30;
        }

        public Znak(double trajanje, string ton, int oktava)
        {
            this.oktava = oktava;
            this.ton = ton;
            this.trajanje = trajanje;
            this.sirina = 30;
            this.frekvenca = this.frekvence[oktava, Array.IndexOf(this.toni, ton)];
            if (this.ton.Length == 2 && this.ton.Substring(1, 1) == "#")
            {
                this.zvisana = true;
                this.sirina += 15;
            }
        }

        public double getTrajanje()
        {
            return this.trajanje;
        }

        public double getFrekvenca()
        {
            return this.frekvenca;
        }

        public string getTon()
        {
            return this.ton;
        }

        public int getKoordinataY()
        {
            if (this.ton.Substring(0, 1) == "C")
            {
                if (this.oktava == 6)
                    return 10;
                else if (this.oktava == 5)
                    return 45;
                else if (this.oktava == 4)
                    return 80;
            }
            else if (this.ton.Substring(0, 1) == "D")
            {
                if (this.oktava == 5)
                    return 40;
                else if (this.oktava == 4)
                    return 75;
            }
            else if (this.ton.Substring(0, 1) == "E")
            {
                if (this.oktava == 5)
                    return 35;
                else if (this.oktava == 4)
                    return 70;
            }
            else if (this.ton.Substring(0, 1) == "F")
            {
                if (this.oktava == 5)
                    return 30;
                else if (this.oktava == 4)
                    return 65;
            }
            else if (this.ton.Substring(0, 1) == "G")
            {
                if (this.oktava == 5)
                    return 25;
                else if (this.oktava == 4)
                    return 60;
            }
            else if (this.ton.Substring(0, 1) == "A")
            {
                if (this.oktava == 5)
                    return 20;
                else if (this.oktava == 4)
                    return 55;
                else if (this.oktava == 3)
                    return 90;
            }
            else if (this.ton.Substring(0, 1) == "H")
            {
                if (this.oktava == 5)
                    return 15;
                else if (this.oktava == 4)
                    return 50;
                else if (this.oktava == 3)
                    return 85;
            }
            return -1;
        }

        public int getSirina()
        {
            return this.sirina;
        }

        public bool getZvisana()
        {
            return this.zvisana;
        }
    }
}
