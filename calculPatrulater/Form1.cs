using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculPatrulater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Graphics g;
        Font f;
        Pen p;
        Brush b;


        private void Form1_Load(object sender, EventArgs e)
        {


            g = CreateGraphics();
            f = Font;
            p = new Pen(Color.Black, 2);
            b = new SolidBrush(Color.Black);



        }


        public int Min(int a, int b)
        {
            if (a < b) return a;
            else return b;
        }
        public double fdistanta(Label l, dotControl a, dotControl b)
        {
            try
            {

                l.Left = 20 + Min(a.Left, b.Left) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Left - b.Left), 2)) / 2);
                l.Top = Min(a.Top, b.Top) + Convert.ToInt16(Math.Sqrt(Math.Pow(Math.Abs(a.Top - b.Top), 2)) / 2);

            }
            catch { }
            return Math.Sqrt(Math.Abs(a.Left - b.Left) * Math.Abs(a.Left - b.Left) + Math.Abs(a.Top - b.Top) * Math.Abs(a.Top - b.Top));
        }


        


        public double unghiul(dotControl a, dotControl b)
        {
            double degrees;
            if (b.Left - a.Left == 0)
            {
                if (b.Top > a.Top)
                {
                    degrees = 90;
                }
                else
                {
                    degrees = 270;
                }
            }
            else
            {
                double riseoverrun = Convert.ToDouble(Math.Abs((b.Top - a.Top)) / Convert.ToDouble(Math.Abs(b.Left - a.Left)));
                double radians = Math.Atan(riseoverrun);
                degrees = radians * Convert.ToDouble(180 / Math.PI);
            }
            if (Math.Abs(b.Left - a.Left) < 0 || Math.Abs(b.Top - a.Top) < 0)
            {
                degrees += 180;
            }
            if (Math.Abs(b.Left - a.Left) > 0 && Math.Abs(b.Top - a.Top) < 0)
            {
                degrees -= 180;
            }
            if (degrees < 0)
            {
                degrees += 360;
            }



            return degrees;

        }


        public void drawPatrat()
        {
            g.Clear(Color.White);
            g.DrawLine(p, dotControl1.Left, dotControl1.Top, dotControl2.Left, dotControl2.Top);
            g.DrawLine(p, dotControl2.Left, dotControl2.Top, dotControl3.Left, dotControl3.Top);
            g.DrawLine(p, dotControl3.Left, dotControl3.Top, dotControl1.Left, dotControl1.Top);

            //g.Clear(BackColor);
            label1.Text = fdistanta(label1, dotControl1, dotControl2).ToString();
            label1.Text += " : " + unghiul(dotControl1, dotControl2);
            g.DrawLine(p, dotControl1.Left, dotControl1.Top, dotControl2.Left, dotControl2.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl1.Left.ToString() + " : " + dotControl1.Top.ToString(), f, b, dotControl1.Left, dotControl1.Top);
            g.DrawString(dotControl2.Left.ToString() + " : " + dotControl2.Top.ToString(), f, b, dotControl2.Left, dotControl2.Top);


            //g.Clear(BackColor);
            label2.Text = fdistanta(label2, dotControl2, dotControl3).ToString();
            label2.Text += " : " + unghiul(dotControl2, dotControl3);
            g.DrawLine(p, dotControl2.Left, dotControl2.Top, dotControl3.Left, dotControl3.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl3.Left.ToString() + " : " + dotControl3.Top.ToString(), f, b, dotControl3.Left, dotControl3.Top);
            g.DrawString(dotControl2.Left.ToString() + " : " + dotControl2.Top.ToString(), f, b, dotControl2.Left, dotControl2.Top);



            //g.Clear(BackColor);
            label3.Text = fdistanta(label3, dotControl4, dotControl3).ToString();
            label3.Text += " : " + unghiul(dotControl4, dotControl3);
            g.DrawLine(p, dotControl3.Left, dotControl3.Top, dotControl4.Left, dotControl4.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl4.Left.ToString() + " : " + dotControl4.Top.ToString(), f, b, dotControl4.Left, dotControl4.Top);
            g.DrawString(dotControl3.Left.ToString() + " : " + dotControl3.Top.ToString(), f, b, dotControl3.Left, dotControl3.Top);


            //g.Clear(BackColor);
            label4.Text = fdistanta(label4, dotControl4, dotControl1).ToString();
            label4.Text += " : " + unghiul(dotControl4, dotControl1);
            g.DrawLine(p, dotControl4.Left, dotControl4.Top, dotControl1.Left, dotControl1.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(dotControl4.Left.ToString() + " : " + dotControl4.Top.ToString(), f, b, dotControl4.Left, dotControl4.Top);
            g.DrawString(dotControl1.Left.ToString() + " : " + dotControl1.Top.ToString(), f, b, dotControl1.Left, dotControl1.Top);

            drawCerc();

            // updatepositions(dotControl1, dotControl2, dotControl3);
        }

        public void drawCerc()
        {
            g.DrawEllipse(p, dotControl5.Left, dotControl5.Top, dotControl6.Left, dotControl7.Top);
            label5.Text = fdistanta(label5, dotControl5, dotControl6).ToString();
            label6.Text = fdistanta(label6, dotControl5, dotControl7).ToString();
        }

        public void draLineAB(Label a, dotControl A, dotControl B)
        {
            //g.Clear(BackColor);
            a.Text = fdistanta(a, A, B).ToString();
            a.Text += " : " + unghiul(A, B);
            g.DrawLine(p, A.Left, A.Top, B.Left, B.Top);
            //g.DrawLine(pen0, dotctrl1.Left+10, dotctrl1.Top+10, dotctrl2.Left+10, dotctrl2.Top+10);
            //g.DrawLine(pen0, dotctrl1.Left - 10, dotctrl1.Top - 10, dotctrl2.Left - 10, dotctrl2.Top - 10);
            g.DrawString(A.Left.ToString() + " : " + A.Top.ToString(), f, b, A.Left, A.Top);
            g.DrawString(B.Left.ToString() + " : " + B.Top.ToString(), f, b, B.Left, B.Top);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            drawPatrat();
        }


    }
}
