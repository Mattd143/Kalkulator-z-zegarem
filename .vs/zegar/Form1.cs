﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zegar
{
    public partial class Form1 : Form
    {
        int cx;
        int cy;
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
           
            
        }
        Bitmap bmp;
        Graphics g;
        int secHand = 140;
        int minHand = 110;
        int hourHand = 80;
        int width = 300;
        int height = 300;

        private void Form1_Load(object sender, EventArgs e)
        {
            //deklaracja rozpoczecia pracy timera, ustawienie kordów bitmapy i środka zegara
            timer1.Start();
            bmp = new Bitmap(Width + 1, Height + 1);
            cx = width / 2;
            cy = height / 2;
            tarcza.Visible = false;

        }

        private void data_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            godzina_minuta.Text = DateTime.Now.ToString("HH:mm:ss");

            data.Text = DateTime.Now.ToString("dd.MM.yyyy");
            dzien.Text = DateTime.Now.ToString("dddd");
            //rysowansko
            g = Graphics.FromImage(bmp);
            //pobranie czasu
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] handcoord = new int[2];
            //czysczenie mapy i wypelnianie jej kolorem, każdy tik zegara czyści pictureboxa i rysuje na nowo tarcze ze wskazowkami
            g.Clear(Color.Peru);
            //rysowanie tarczy
            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, 300, 300);
           
            Font font = new Font("Arial", 12);
            Brush brush = Brushes.Black;

            // Rysowanie cyfr, wykorzystanie trygonometrii 
            for (int i = 1; i <= 12; i++)
            {
                double angle = Math.PI / 6 * (i - 3); // Przesunięcie, bo 12 = 0° na górze
                int x = (int)(cx + secHand * Math.Cos(angle)) - 10;
                int y = (int)(cy + secHand * Math.Sin(angle)) - 10;
                g.DrawString(i.ToString(), font, brush, new PointF(x, y));
            }


            //wskazowka sekund
            handcoord = msCoord(ss,secHand);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));
            //wskazowka minut
            handcoord = msCoord(mm, minHand);
            g.DrawLine(new Pen(Color.Blue, 2f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));
            //wskazówka godzin
            handcoord = hrCoord(hh%12,mm, hourHand);
            g.DrawLine(new Pen(Color.Black, 3f), new Point(cx, cy), new Point(handcoord[0], handcoord[1]));
            //załadowanie bitmapy do pictureboxa
            tarcza.Image = bmp;
            this.Text = "Aktualny czas-" + hh + ":" + mm + ":" + ss;
            //zwolnienie pamieci
            g.Dispose();
        }
        
        
        // kordy na wskazowki minuty i sekundy
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            //kazda sekunda to 6 stopni
            val *= 6;

            if(val>=0 && val<=180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        //kordy na wskazowke godziny
        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

           //1 godzina to 30 stopni, 1 minuta to 0.5 stopni
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));
            }
            return coord;
        }

        private void przycisk_zamiana_Click(object sender, EventArgs e)
        {
            godzina_minuta.Visible = !godzina_minuta.Visible;
            tarcza.Visible = !tarcza.Visible;
        }
    }

}






