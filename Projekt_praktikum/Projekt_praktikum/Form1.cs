using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Projekt_praktikum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ContextMenu meni = new ContextMenu();

            MenuItem notaCelinka = new MenuItem();
            MenuItem notaPolovinka = new MenuItem();
            MenuItem notaCetrtinka = new MenuItem();
            MenuItem notaOsminka = new MenuItem();
            MenuItem pavzaCelinka = new MenuItem();
            MenuItem pavzaPolovinka = new MenuItem();
            MenuItem pavzaCetrtinka = new MenuItem();
            MenuItem pavzaOsminka = new MenuItem();

            notaCelinka.Text = "Nota celinka";
            notaPolovinka.Text = "Nota polovinka";
            notaCetrtinka.Text = "Nota četrtinka";
            notaOsminka.Text = "Nota osminka";
            pavzaCelinka.Text = "Pavza celinka";
            pavzaPolovinka.Text = "Pavza polovinka";
            pavzaCetrtinka.Text = "Pavza četrtinka";
            pavzaOsminka.Text = "Pavza osminka";

            pavzaCelinka.Click += new System.EventHandler(this.dodajPavzoCelinko);
            pavzaPolovinka.Click += new System.EventHandler(this.dodajPavzoPolovinko);
            pavzaCetrtinka.Click += new System.EventHandler(this.dodajPavzoCetrtinko);
            pavzaOsminka.Click += new System.EventHandler(this.dodajPavzoOsminko);
            notaCelinka.Click += new System.EventHandler(this.dodajNotoCelinko);
            notaPolovinka.Click += new System.EventHandler(this.dodajNotoPolovinko);
            notaCetrtinka.Click += new System.EventHandler(this.dodajNotoCetrtinko);
            notaOsminka.Click += new System.EventHandler(this.dodajNotoOsminko);

            meni.MenuItems.Add(notaCelinka);
            meni.MenuItems.Add(notaPolovinka);
            meni.MenuItems.Add(notaCetrtinka);
            meni.MenuItems.Add(notaOsminka);
            meni.MenuItems.Add(pavzaCelinka);
            meni.MenuItems.Add(pavzaPolovinka);
            meni.MenuItems.Add(pavzaCetrtinka);
            meni.MenuItems.Add(pavzaOsminka);

            meni.Popup += new System.EventHandler(this.meniPopup);
            
            imageBox1.ContextMenu = meni;

            kvadrateki = new List<kvadrat>();
            radioNavadna.Checked = true;
            comboKljuc.SelectedIndex = 0;
            nasoZaporedje = new ZaporedjeTonov();

            for (int x = 10; x < 260; x = x + 10)
            {
                comboTempo.Items.Add(x);
            }
            comboTempo.SelectedItem = 120;

            for (int x = 1; x <= 10; x++)
            {
                comboTaktStevec.Items.Add(x);
                comboTaktImenovalec.Items.Add(x);
            }
            comboTaktStevec.SelectedItem = 4;
            comboTaktImenovalec.SelectedItem = 4;

            notnoCrtovje = new Image<Gray, byte>(700, 500);
            for (int x = 0; x < 700; x++)
            {
                for (int y = 0; y < 500; y++)
                {
                    notnoCrtovje.Data[y, x, 0] = 255;
                }
            }

            notneCrte = new List<LineSegment2D>();
            notneCrte.Add(new LineSegment2D(new Point(0, 30), new Point(699, 30)));
            notneCrte.Add(new LineSegment2D(new Point(0, 40), new Point(699, 40)));
            notneCrte.Add(new LineSegment2D(new Point(0, 50), new Point(699, 50)));
            notneCrte.Add(new LineSegment2D(new Point(0, 60), new Point(699, 60)));
            notneCrte.Add(new LineSegment2D(new Point(0, 70), new Point(699, 70)));

            notneCrte.Add(new LineSegment2D(new Point(0, 130), new Point(699, 130)));
            notneCrte.Add(new LineSegment2D(new Point(0, 140), new Point(699, 140)));
            notneCrte.Add(new LineSegment2D(new Point(0, 150), new Point(699, 150)));
            notneCrte.Add(new LineSegment2D(new Point(0, 160), new Point(699, 160)));
            notneCrte.Add(new LineSegment2D(new Point(0, 170), new Point(699, 170)));

            notneCrte.Add(new LineSegment2D(new Point(0, 230), new Point(699, 230)));
            notneCrte.Add(new LineSegment2D(new Point(0, 240), new Point(699, 240)));
            notneCrte.Add(new LineSegment2D(new Point(0, 250), new Point(699, 250)));
            notneCrte.Add(new LineSegment2D(new Point(0, 260), new Point(699, 260)));
            notneCrte.Add(new LineSegment2D(new Point(0, 270), new Point(699, 270)));

            notneCrte.Add(new LineSegment2D(new Point(0, 330), new Point(699, 330)));
            notneCrte.Add(new LineSegment2D(new Point(0, 340), new Point(699, 340)));
            notneCrte.Add(new LineSegment2D(new Point(0, 350), new Point(699, 350)));
            notneCrte.Add(new LineSegment2D(new Point(0, 360), new Point(699, 360)));
            notneCrte.Add(new LineSegment2D(new Point(0, 370), new Point(699, 370)));

            notneCrte.Add(new LineSegment2D(new Point(0, 430), new Point(699, 430)));
            notneCrte.Add(new LineSegment2D(new Point(0, 440), new Point(699, 440)));
            notneCrte.Add(new LineSegment2D(new Point(0, 450), new Point(699, 450)));
            notneCrte.Add(new LineSegment2D(new Point(0, 460), new Point(699, 460)));
            notneCrte.Add(new LineSegment2D(new Point(0, 470), new Point(699, 470)));
            foreach (LineSegment2D trenutna in notneCrte)
            {
                notnoCrtovje.Draw(trenutna, new Gray(100), 2);
            }

            imageBox1.Image = notnoCrtovje;
            labelInfo.Text = nasoZaporedje.getPorocilo();
        }
        ZaporedjeTonov nasoZaporedje;
        Image<Gray, byte> notnoCrtovje;
        List<LineSegment2D> notneCrte;
        List<kvadrat> kvadrateki;
        Point pozicija;

        struct kvadrat
        {
            int x1, x2, y1, y2;

            public kvadrat(int x1, int x2, int y1, int y2)
            {
                this.x1 = x1;
                this.x2 = x2;
                this.y1 = y1;
                this.y2 = y2;
            }

            public int getx1()
            {
                return this.x1;
            }

            public int getx2()
            {
                return this.x2;
            }

            public int gety1()
            {
                return this.y1;
            }

            public int gety2()
            {
                return this.y2;
            }
        }        

        private void dodajPavzoCelinko(object sender, System.EventArgs e)
        {
            this.nasoZaporedje.dodajPavzo(1);
            narisi();
        }

        private void dodajPavzoPolovinko(object sender, System.EventArgs e)
        {
            this.nasoZaporedje.dodajPavzo(0.5);
            narisi();
        }

        private void dodajPavzoCetrtinko(object sender, System.EventArgs e)
        {
            this.nasoZaporedje.dodajPavzo(0.25);
            narisi();
        }

        private void dodajPavzoOsminko(object sender, System.EventArgs e)
        {
            this.nasoZaporedje.dodajPavzo(0.125);
            narisi();
        }

        private void dodajNotoCelinko(object sender, System.EventArgs e)
        {
            int x = pozicija.X;
            int y = pozicija.Y;
            int rely = y % 100;
            if (rely >= 10 && rely <= 90)
            {
                int ostanek = y % 5;
                y -= ostanek;
                if (ostanek == 3 || ostanek == 4)
                    y += 5;
                rely = y % 100;
            }

            if (radioNavadna.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C", 6, 1);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("H", 5, 1);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A", 5, 1);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G", 5, 1);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F", 5, 1);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("E", 5, 1);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D", 5, 1);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C", 5, 1);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("H", 4, 1);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A", 4, 1);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G", 4, 1);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F", 4, 1);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("E", 4, 1);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D", 4, 1);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C", 4, 1);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("H", 3, 1);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A", 3, 1);
            }
            else if (radioZvisana.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C#", 6, 1);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("C", 6, 1);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A#", 5, 1);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G#", 5, 1);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F#", 5, 1);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("F", 5, 1);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D#", 5, 1);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C#", 5, 1);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("C", 5, 1);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A#", 4, 1);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G#", 4, 1);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F#", 4, 1);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("F", 4, 1);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D#", 4, 1);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C#", 4, 1);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("C", 4, 1);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A#", 3, 1);
            }
            narisi();
        }

        private void dodajNotoPolovinko(object sender, System.EventArgs e)
        {
            int x = pozicija.X;
            int y = pozicija.Y;
            int rely = y % 100;
            if (rely >= 10 && rely <= 90)
            {
                int ostanek = y % 5;
                y -= ostanek;
                if (ostanek == 3 || ostanek == 4)
                    y += 5;
                rely = y % 100;
            }

            if (radioNavadna.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C", 6, 0.5);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("H", 5, 0.5);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A", 5, 0.5);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G", 5, 0.5);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F", 5, 0.5);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("E", 5, 0.5);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D", 5, 0.5);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C", 5, 0.5);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("H", 4, 0.5);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A", 4, 0.5);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G", 4, 0.5);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F", 4, 0.5);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("E", 4, 0.5);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D", 4, 0.5);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C", 4, 0.5);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("H", 3, 0.5);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A", 3, 0.5);
            }
            else if (radioZvisana.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C#", 6, 0.5);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("C", 6, 0.5);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A#", 5, 0.5);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G#", 5, 0.5);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F#", 5, 0.5);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("F", 5, 0.5);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D#", 5, 0.5);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C#", 5, 0.5);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("C", 5, 0.5);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A#", 4, 0.5);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G#", 4, 0.5);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F#", 4, 0.5);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("F", 4, 0.5);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D#", 4, 0.5);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C#", 4, 0.5);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("C", 4, 0.5);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A#", 3, 0.5);
            }

            narisi();
        }

        private void dodajNotoCetrtinko(object sender, System.EventArgs e)
        {
            int x = pozicija.X;
            int y = pozicija.Y;
            int rely = y % 100;
            if (rely >= 10 && rely <= 90)
            {
                int ostanek = y % 5;
                y -= ostanek;
                if (ostanek == 3 || ostanek == 4)
                    y += 5;
                rely = y % 100;
            }
            if (radioNavadna.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C", 6, 0.25);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("H", 5, 0.25);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A", 5, 0.25);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G", 5, 0.25);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F", 5, 0.25);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("E", 5, 0.25);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D", 5, 0.25);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C", 5, 0.25);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("H", 4, 0.25);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A", 4, 0.25);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G", 4, 0.25);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F", 4, 0.25);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("E", 4, 0.25);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D", 4, 0.25);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C", 4, 0.25);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("H", 3, 0.25);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A", 3, 0.25);
            }
            else if (radioZvisana.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C#", 6, 0.25);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("C", 6, 0.25);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A#", 5, 0.25);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G#", 5, 0.25);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F#", 5, 0.25);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("F", 5, 0.25);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D#", 5, 0.25);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C#", 5, 0.25);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("C", 5, 0.25);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A#", 4, 0.25);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G#", 4, 0.25);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F#", 4, 0.25);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("F", 4, 0.25);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D#", 4, 0.25);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C#", 4, 0.25);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("C", 4, 0.25);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A#", 3, 0.25);
            }
            narisi();
        }

        private void dodajNotoOsminko(object sender, System.EventArgs e)
        {
            int x = pozicija.X;
            int y = pozicija.Y;
            int rely = y % 100;
            if (rely >= 10 && rely <= 90)
            {
                int ostanek = y % 5;
                y -= ostanek;
                if (ostanek == 3 || ostanek == 4)
                    y += 5;
                rely = y % 100;
            }
            if (radioNavadna.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C", 6, 0.125);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("H", 5, 0.125);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A", 5, 0.125);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G", 5, 0.125);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F", 5, 0.125);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("E", 5, 0.125);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D", 5, 0.125);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C", 5, 0.125);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("H", 4, 0.125);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A", 4, 0.125);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G", 4, 0.125);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F", 4, 0.125);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("E", 4, 0.125);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D", 4, 0.125);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C", 4, 0.125);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("H", 3, 0.125);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A", 3, 0.125);
            }
            else if (radioZvisana.Checked)
            {
                if (rely == 10)
                    nasoZaporedje.dodajNoto("C#", 6, 0.125);
                else if (rely == 15)
                    nasoZaporedje.dodajNoto("C", 6, 0.125);
                else if (rely == 20)
                    nasoZaporedje.dodajNoto("A#", 5, 0.125);
                else if (rely == 25)
                    nasoZaporedje.dodajNoto("G#", 5, 0.125);
                else if (rely == 30)
                    nasoZaporedje.dodajNoto("F#", 5, 0.125);
                else if (rely == 35)
                    nasoZaporedje.dodajNoto("F", 5, 0.125);
                else if (rely == 40)
                    nasoZaporedje.dodajNoto("D#", 5, 0.125);
                else if (rely == 45)
                    nasoZaporedje.dodajNoto("C#", 5, 0.125);
                else if (rely == 50)
                    nasoZaporedje.dodajNoto("C", 5, 0.125);
                else if (rely == 55)
                    nasoZaporedje.dodajNoto("A#", 4, 0.125);
                else if (rely == 60)
                    nasoZaporedje.dodajNoto("G#", 4, 0.125);
                else if (rely == 65)
                    nasoZaporedje.dodajNoto("F#", 4, 0.125);
                else if (rely == 70)
                    nasoZaporedje.dodajNoto("F", 4, 0.125);
                else if (rely == 75)
                    nasoZaporedje.dodajNoto("D#", 4, 0.125);
                else if (rely == 80)
                    nasoZaporedje.dodajNoto("C#", 4, 0.125);
                else if (rely == 85)
                    nasoZaporedje.dodajNoto("C", 4, 0.125);
                else if (rely == 90)
                    nasoZaporedje.dodajNoto("A#", 3, 0.125);
            }
            narisi();
        }

        private void meniPopup(object sender, EventArgs e)
        {
            ContextMenu menu = sender as ContextMenu;

            if (menu != null)
            {
                // Get cursor position in screen coordinates
                Point screenPoint = Cursor.Position;

                // Convert screen coordinates to a point relative to the control
                // that was right clicked, in your case this would be the relavant 
                // picture box.
                pozicija = menu.SourceControl.PointToClient(screenPoint);
            }
        }

        private void imageBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                int index = -1;
                for (int i = 0; i < kvadrateki.Count; i++)
                {
                    if (x >= kvadrateki[i].getx1() && x <= kvadrateki[i].getx2() && y >= kvadrateki[i].gety1() && y <= kvadrateki[i].gety2())
                    {
                        index = i;
                    }
                }

                if (index != -1)
                {
                    nasoZaporedje.izbrisi(index);
                }
                narisi();
            }           
        }

        private void narisi()
        {
            Image<Gray, byte> kopija = notnoCrtovje.Copy();

            int stevecx = 10;
            int stevecy = 0;
            List<Znak> zaporedje = nasoZaporedje.getZaporedje();
            kvadrateki = new List<kvadrat>();
            foreach (Znak trenutni in zaporedje)
            {
                if ((690 - stevecx) < trenutni.getSirina())
                {
                    stevecx = 10;
                    stevecy += 100;
                }
                double trajanje = trenutni.getTrajanje();

                if (trenutni.getFrekvenca() != 0)
                {
                    int koordinatay = trenutni.getKoordinataY();

                    if (trenutni.getZvisana())
                    {
                        stevecx += 10;
                        kopija.Draw(new LineSegment2D(new Point(stevecx - 5, koordinatay + stevecy - 2), new Point(stevecx + 5, koordinatay + stevecy - 2)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx - 5, koordinatay + stevecy + 2), new Point(stevecx + 5, koordinatay + stevecy + 2)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx - 2, koordinatay + stevecy - 5), new Point(stevecx - 3, koordinatay + stevecy + 5)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 3, koordinatay + stevecy - 5), new Point(stevecx + 2, koordinatay + stevecy + 5)), new Gray(0), 2);
                        stevecx += 5;
                    }

                    if(koordinatay<30)
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 1, 20 + stevecy), new Point(stevecx + 19, 20 + stevecy)), new Gray(0), 2);

                    if (koordinatay<15)
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 1, 10 + stevecy), new Point(stevecx + 19, 10 + stevecy)), new Gray(0), 2);

                    if (koordinatay > 70)
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 1, 80 + stevecy), new Point(stevecx + 19, 80 + stevecy)), new Gray(0), 2);

                    if (koordinatay > 85)
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 1, 90 + stevecy), new Point(stevecx + 19, 90 + stevecy)), new Gray(0), 2);

                    if (trajanje == 1)
                    {
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 5), new Gray(0), 2);
                    }
                    else if (trajanje == 0.5)
                    {
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 5), new Gray(0), 2);
                        if (koordinatay >= 50)
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 15, koordinatay + stevecy), new Point(stevecx + 15, koordinatay + stevecy - 20)), new Gray(0), 2);
                        }
                        else
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 5, koordinatay + stevecy), new Point(stevecx + 5, koordinatay + stevecy + 20)), new Gray(0), 2);
                        }
                    }
                    else if (trajanje == 0.25)
                    {
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 5), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 4), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 3), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 2), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 1), new Gray(0), 2);
                        if (koordinatay >= 50)
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 15, koordinatay + stevecy), new Point(stevecx + 15, koordinatay + stevecy - 20)), new Gray(0), 2);
                        }
                        else
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 5, koordinatay + stevecy), new Point(stevecx + 5, koordinatay + stevecy + 20)), new Gray(0), 2);
                        }
                    }
                    else if (trajanje == 0.125)
                    {
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 5), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 4), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 3), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 2), new Gray(0), 2);
                        kopija.Draw(new CircleF(new PointF(stevecx + 10, koordinatay + stevecy), 1), new Gray(0), 2);
                        if (koordinatay >= 50)
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 15, koordinatay + stevecy), new Point(stevecx + 15, koordinatay + stevecy - 20)), new Gray(0), 2);
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 15, koordinatay + stevecy - 20), new Point(stevecx + 25, koordinatay + stevecy - 10)), new Gray(0), 2);
                        }
                        else
                        {
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 5, koordinatay + stevecy), new Point(stevecx + 5, koordinatay + stevecy + 20)), new Gray(0), 2);
                            kopija.Draw(new LineSegment2D(new Point(stevecx + 5, koordinatay + stevecy + 20), new Point(stevecx + 15, koordinatay + stevecy + 10)), new Gray(0), 2);
                        }
                    }
                }
                else
                {
                    if (trajanje == 1)
                    {
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 41 + stevecy), new Point(stevecx + 22, 41 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 42 + stevecy), new Point(stevecx + 22, 42 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 43 + stevecy), new Point(stevecx + 22, 43 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 44 + stevecy), new Point(stevecx + 22, 44 + stevecy)), new Gray(0), 2);
                    }
                    else if (trajanje == 0.5)
                    {
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 49 + stevecy), new Point(stevecx + 22, 49 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 48 + stevecy), new Point(stevecx + 22, 48 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 47 + stevecy), new Point(stevecx + 22, 47 + stevecy)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 8, 46 + stevecy), new Point(stevecx + 22, 46 + stevecy)), new Gray(0), 2);
                    }
                    else if (trajanje == 0.25)
                    {
                        kopija.Draw(new LineSegment2D(new Point(stevecx +16, stevecy+60), new Point(stevecx + 9, stevecy+40)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 9, stevecy + 40), new Point(stevecx + 15, stevecy + 42)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 15, stevecy + 42), new Point(stevecx + 21, stevecy + 40)), new Gray(0), 2);
                    }
                    else if (trajanje == 0.125)
                    {
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 14, stevecy + 60), new Point(stevecx + 21, stevecy + 40)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 9, stevecy + 40), new Point(stevecx + 15, stevecy + 42)), new Gray(0), 2);
                        kopija.Draw(new LineSegment2D(new Point(stevecx + 15, stevecy + 42), new Point(stevecx + 21, stevecy + 40)), new Gray(0), 2);
                    }
                }

                kvadrat novi = new kvadrat(stevecx, stevecx + trenutni.getSirina(), 10 + stevecy, 90 + stevecy);
                kvadrateki.Add(novi);
                if (trenutni.getZvisana())
                    stevecx += trenutni.getSirina() - 15;
                else
                    stevecx += trenutni.getSirina();
            }

            imageBox1.Image = kopija;
        }

        private void comboTempo_SelectedIndexChanged(object sender, EventArgs e)
        {
            nasoZaporedje.setTempo(Convert.ToInt32(comboTempo.SelectedItem));
            labelInfo.Text = nasoZaporedje.getPorocilo();
        }

        private void comboTaktStevec_SelectedIndexChanged(object sender, EventArgs e)
        {
            nasoZaporedje.setTakt(Convert.ToInt32(comboTaktStevec.SelectedItem), Convert.ToInt32(comboTaktImenovalec.SelectedItem));
            labelInfo.Text = nasoZaporedje.getPorocilo();
        }

        private void comboTaktImenovalec_SelectedIndexChanged(object sender, EventArgs e)
        {
            nasoZaporedje.setTakt(Convert.ToInt32(comboTaktStevec.SelectedItem), Convert.ToInt32(comboTaktImenovalec.SelectedItem));
            labelInfo.Text = nasoZaporedje.getPorocilo();
        }
    }
}
