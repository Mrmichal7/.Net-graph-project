using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wykres
{
    public partial class wndWykres : Form
    {
        public wndWykres()
        {
            InitializeComponent();
        }

        private void pnWykres_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = pnWykres.PointToClient(Cursor.Position);
            lbTemp2.Text = string.Format("X: {0} , Y: {1}", point.X, point.Y);

        }

        private void btRysuj_Click(object sender, EventArgs e)
        {
            
            modelDanych.InterpretujX1(tbX1.Text);
            modelDanych.InterpretujX2(tbX2.Text);
            float x1 = (float)modelDanych.X1;
            float x2 = (float)modelDanych.X2;
            if (!modelDanych.InterpretujX1(tbX1.Text))
            {
                MessageBox.Show("Niewłaściwa wartość współczynnika x1");
                return;
            }
            if (!modelDanych.InterpretujX2(tbX2.Text))
            {
                MessageBox.Show("Niewłaściwa wartość współczynnika x2");
                return;
            }

            
            

            Graphics g = pnWykres.CreateGraphics();
            Pen Black = new Pen(new SolidBrush(System.Drawing.Color.Black), 2);
            Pen Gray = new Pen(new SolidBrush(System.Drawing.Color.Gray), 1);
            Pen Blue = new Pen(new SolidBrush(System.Drawing.Color.Blue), 1);
            Brush Czcionka_black = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            Font Czcionka = new Font("Arial", 10);
            g.Clear(Color.White);

            lbTitle.Text = tbTytul.Text;
            lbOY.Text = tbY.Text;
            lbOX.Text = tbX.Text;
            

            int przesuniecie_x =50;
            int przesuniecie_y =30;

            PointF[] wartosci = new PointF[200];
            wartosci = modelDanych.valuesY();
            float Ymin = wartosci[0].Y;
            float Ymax = wartosci[0].Y;
            //szukanie min i max funkcji
            for (int i = 0; i < 200; i++)
            {
                if (wartosci[i].Y > Ymax)
                {
                    Ymax = wartosci[i].Y;
                }
                if (wartosci[i].Y < Ymin)
                {
                    Ymin = wartosci[i].Y;
                }
            }
            float roznicaY = (float)Math.Abs(Ymax - Ymin);

            float siatka_x = ((float)pnWykres.Width-przesuniecie_x) / 200;
            PointF[] punkty_wykres=new PointF[200];
            for (int  i = 0;  i <200;  i++)
            {
                float dy =(float)Math.Abs(wartosci[i].Y - Ymin);
                float krok_y = dy / roznicaY;
                punkty_wykres[i] = new PointF((siatka_x * i)+przesuniecie_x, -(krok_y * (pnWykres.Height-przesuniecie_y)+przesuniecie_y) + pnWykres.Height);
                Console.WriteLine(punkty_wykres[i]+" ".ToString());
            }
            g.DrawCurve(Blue, punkty_wykres);

            //markery
            double logY = Math.Floor(Math.Log10(Ymax - Ymin));
            double logX = Math.Floor(Math.Log10(x2 - x1));
            int MarkerY = 4;
            int MarkerX = 4;
            double[] podstawy = { 1, 2, 2.5, 10 };
            for (int i = 0; i < podstawy.Length; i++)
            {
                if (roznicaY * (podstawy[i] * Math.Pow(10, logY)) > 5 && roznicaY * (podstawy[i] * Math.Pow(10, logY)) < 9)
                {
                    MarkerY = Convert.ToInt32((Ymax - Ymin) * (podstawy[i] * Math.Pow(10, logY)));
                }
                if ((x2-x1) * (podstawy[i] * Math.Pow(10, logX)) > 5 && roznicaY * (podstawy[i] * Math.Pow(10, logX)) < 9)
                {
                    MarkerX = Convert.ToInt32(roznicaY * (podstawy[i] * Math.Pow(10, logX)));
                }
            }

            double wartosc_x_wykres = (x2 - x1)/pnWykres.Width;
            double wartosc_y_wykres = (Ymax - Ymin)/(pnWykres.Height-przesuniecie_y);
            double Offset_X = (x2 - x1) / MarkerX;
            double Offset_Y = Math.Abs((Ymax - Ymin) / MarkerY);
            for (int i = 0; i < MarkerY+1; i++)
            {
                double liczba = Ymax - (Offset_Y * i);
                double czesc_calkowita  = Math.Truncate(liczba);
                int y = Convert.ToInt32(((Offset_Y * i) / wartosc_y_wykres));
                if (chbHorizontal.Checked)
                {
                    g.DrawLine(Gray, new Point(przesuniecie_y, y), new Point(pnWykres.Width - 2, y));

                    if (Math.Abs(czesc_calkowita - liczba) < 0.09 && czesc_calkowita != 0)
                    {
                        g.DrawString(Math.Round(liczba, 2).ToString(), Czcionka, Czcionka_black, 0, y);
                    }

                    else if (Math.Abs(czesc_calkowita - liczba) < 0.09 && czesc_calkowita == 0)
                    {
                        g.DrawString(Math.Round(liczba, 0).ToString(), Czcionka, Czcionka_black, 0, y);
                    }
                    else if (Math.Abs(czesc_calkowita - liczba) < 0.9)
                    {
                        g.DrawString(Math.Round(liczba, 1).ToString(), Czcionka, Czcionka_black, 0, y);
                    }
                    else
                    {
                        g.DrawString(Math.Round(liczba, 0).ToString(), Czcionka, Czcionka_black, 0, y);
                    }
                        
                }

            }

            for (int i = 0; i < MarkerX+1; i++)
            {
                int x = Convert.ToInt32(Offset_X * i / wartosc_x_wykres);

                if (chbVertical.Checked)
                {
                    double liczba = x1 + (Offset_X * i);

                    double czesc_calkowita = Math.Truncate(liczba);

                    g.DrawLine(Gray, new Point(x+przesuniecie_x, 0), new Point(x+przesuniecie_x, pnWykres.Height-15));
                    if (i != MarkerX)
                    {
                        if (Math.Abs(czesc_calkowita - liczba) != 0)
                        {
                            if (Math.Abs(czesc_calkowita - liczba) < 0.09)
                            {
                                g.DrawString(Math.Round(liczba, 2).ToString(), Czcionka, Czcionka_black, x + 45, pnWykres.Height - 15);
                            }
                            else
                            {
                                g.DrawString(Math.Round(liczba, 1).ToString(), Czcionka, Czcionka_black, x + 45, pnWykres.Height - 15);
                            }
                        }
                        else
                        {
                            g.DrawString(Math.Round((liczba), 0).ToString(), Czcionka, Czcionka_black, x+45, pnWykres.Height - 15);
                        }

                    }
                    else
                    {
                        if (Math.Abs(Math.Truncate(x2) - x2) != 0)
                        {
                            if (Math.Abs(czesc_calkowita - liczba) < 0.09)
                            {
                                g.DrawString(x2.ToString(), Czcionka, Czcionka_black, x - 35, pnWykres.Height - 15);
                            }
                            else
                            {
                                g.DrawString(x2.ToString(), Czcionka, Czcionka_black, x - 25, pnWykres.Height - 15);
                            }
                        }
                        else
                        {
                            g.DrawString(x2.ToString(), Czcionka, Czcionka_black, x - 10, pnWykres.Height - 15);
                        }
                    }

                }
            }

        }
       
        private void tbWzor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
