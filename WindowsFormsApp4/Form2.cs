using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int pTrb=0, aTrb=0, pSam=0, aSam=0, pGal=0, aGal=0, pBjk=0, aBjk=0;

        private void button4_Click(object sender, EventArgs e)
        {
            if (pTrb > pSam && pTrb > pGal && pTrb > pBjk)//ts şampiyon
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\Oguz\\Downloads\\tsdikoyna.mp3";
                MessageBox.Show("ŞAMPİYON TRABZOONNNN");
               
            }
            if (pSam > pTrb && pSam > pGal && pSam > pBjk)//sam şampiyon
            {
                MessageBox.Show("ŞAMPİYON SAMSUN");
            }
            if (pBjk > pSam && pBjk > pGal && pBjk > pTrb)//bjk şampiyon
            {
                MessageBox.Show("ŞAMPİYON BEŞİKTAŞ");
            }
            if (pGal > pSam && pGal > pTrb && pGal > pBjk)//gs şampiyon
            {
                MessageBox.Show("ŞAMPİYON GALATASARAY");
            }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            int a = rnd.Next(3, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(0, 6);
            if (a == b)//ts sam maçı
            {
                pTrb += 1; pSam += 1;
            }
            else if (a > b)
            {
                pTrb += 3; aTrb += a - b; aSam += b - a;
            }
            else if (a < b)
            {
                pSam += 3; aTrb += a - b; aSam += b - a;
            }
            //
            if (c == d)//gs bjk
            {
                pGal += 1; pBjk += 1;
            }
            else if (c > d)
            {
                pGal += 3; aGal += c - d; aBjk += d - c;
            }
            else if (c < d)
            {
                pBjk += 3; aBjk += c - d; aGal += d - c;
            }
            label13.Text = a.ToString();//ts
            label14.Text = b.ToString();//sam
            label15.Text = c.ToString();//gal
            label16.Text = d.ToString();//bjk
            label36.Text = pTrb.ToString();
            label35.Text = pSam.ToString();
            label34.Text = pGal.ToString();
            label33.Text = pBjk.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            int a = rnd.Next(0, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(5, 6);

            if (a == b)//bjk sam maçı
            {
                pBjk += 1; pSam += 1;
            }
            else if (a > b)
            {
                pBjk += 3; aBjk += a - b; aSam += b - a;
            }
            else if (a < b)
            {
                pSam += 3; aBjk += a - b; aSam += b - a;
            }
            //
            if (c == d)//gs ts
            {
                pGal += 1; pTrb += 1;
            }
            else if (c > d)
            {
                pGal += 3; aGal += c - d; aTrb += d - c;
            }
            else if (c < d)
            {
                pTrb += 3; aTrb += d -c; aGal += c-d;
            }

            label17.Text = a.ToString();//bjk
            label18.Text = b.ToString();//sam
            label19.Text = c.ToString();//gal
            label20.Text = d.ToString();//ts
            label36.Text = pTrb.ToString();
            label35.Text = pSam.ToString();
            label34.Text = pGal.ToString();
            label33.Text = pBjk.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            int a = rnd.Next(3, 6);
            int b = rnd.Next(0, 6);
            int c = rnd.Next(0, 6);
            int d = rnd.Next(0, 6);

            if (a == b)//ts bjk maçı
            {
                pBjk += 1; pTrb += 1;
            }
            else if (a > b)
            {
                pTrb += 3; aTrb += a - b; aBjk += b - a;
            }
            else if (a < b)
            {
                pBjk += 3; aTrb += a - b; aBjk += b - a;
            }
            //
            if (c == d)//gs sam
            {
                pGal += 1; pSam += 1;
            }
            else if (c > d)
            {
                pGal += 3; aGal += c - d; aSam += d - c;
            }
            else if (c < d)
            {
                pSam += 3; aSam += d - c; aGal += c - d;
            }

            label21.Text = a.ToString();//ts
            label22.Text = b.ToString();//bjk
            label23.Text = c.ToString();//gal
            label24.Text = d.ToString();//sam
            label36.Text = pTrb.ToString();
            label35.Text = pSam.ToString();
            label34.Text = pGal.ToString();
            label33.Text = pBjk.ToString();
        }
        
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
