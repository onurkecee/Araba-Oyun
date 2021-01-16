using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Araba_Oyun
{
    public partial class Araba_Oyun : Form
    {
        public Araba_Oyun()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SeritGecisi(oyunhizi);
            Engeller(5);
            Coins(oyunhizi);
            AltinTopla();
            GameOver();

        }

        int toplananaltin = 0;
        Random r = new Random();
        int x, y;
        void Engeller(int hiz)
        {
            if (engel1.Top >= 500)
            {
                x = r.Next(0, 200);
                engel1.Location = new Point(x, 0);
            }
            else
            {
                engel1.Top += hiz;
            }

            if (engel2.Top >= 500)
            {
                x = r.Next(0, 400);
                engel2.Location = new Point(x, 0);
            }
            else
            {
                engel2.Top += hiz;
            }

            if (engel3.Top >= 500)
            {
                x = r.Next(200, 350);
                engel3.Location = new Point(x, 0);
            }
            else
            {
                engel3.Top += hiz;
            }
        }
        void Coins(int hiz)
        {
            if (altin1.Top >= 500)
            {
                x = r.Next(0, 200);
                altin1.Location = new Point(x, 0);
            }
            else
            {
                altin1.Top += hiz;
            }
            if (altin2.Top >= 500)
            {
                x = r.Next(0, 200);
                altin2.Location = new Point(x, 0);
            }
            else
            {
                altin2.Top += hiz;
            }
            if (altin3.Top >= 500)
            {
                x = r.Next(50, 300);
                altin3.Location = new Point(x, 0);
            }
            else
            {
                altin3.Top += hiz;
            }
            if (altin4.Top >= 500)
            {
                x = r.Next(0, 400);
                altin4.Location = new Point(x, 0);
            }
            else
            {
                altin4.Top += hiz;
            }
        }
        void GameOver()
        {
            if (araba.Bounds.IntersectsWith(engel1.Bounds))
            {
                timer1.Enabled = false;
                panel1.Visible = true;
            }
            if (araba.Bounds.IntersectsWith(engel2.Bounds))
            {
                timer1.Enabled = false;
                panel1.Visible = true;
            }
            if (araba.Bounds.IntersectsWith(engel3.Bounds))
            {
                timer1.Enabled = false;
                panel1.Visible = true;
            }
            lblSonucCoins.Text = lblCoins.Text;

        }
        void SeritGecisi(int hiz)
        {
            if (cizgi1.Top >= 500)
            {
                cizgi1.Top = 0;
            }
            else
            {
                cizgi1.Top += hiz;
            }

            if (cizgi2.Top >= 500)
            {
                cizgi2.Top = 0;
            }
            else
            {
                cizgi2.Top += hiz;
            }

            if (cizgi3.Top >= 500)
            {
                cizgi3.Top = 0;
            }
            else
            {
                cizgi3.Top += hiz;
            }

            if (cizgi4.Top >= 500)
            {
                cizgi4.Top = 0;
            }
            else
            {
                cizgi4.Top += hiz;
            }

        }
        void AltinTopla()
        {
            if (araba.Bounds.IntersectsWith(altin1.Bounds))
            {
                toplananaltin++;
                lblCoins.Text = toplananaltin.ToString();
                x = r.Next(0, 200);
                altin1.Location = new Point(x, 0);
            }
            if (araba.Bounds.IntersectsWith(altin2.Bounds))
            {
                toplananaltin++;
                lblCoins.Text = toplananaltin.ToString();
                x = r.Next(0, 200);
                altin2.Location = new Point(x, 0);
            }
            if (araba.Bounds.IntersectsWith(altin3.Bounds))
            {
                toplananaltin++;
                lblCoins.Text = toplananaltin.ToString();
                x = r.Next(0, 200);
                altin3.Location = new Point(x, 0);
            }
            if (araba.Bounds.IntersectsWith(altin4.Bounds))
            {
                toplananaltin++;
                lblCoins.Text = toplananaltin.ToString();
                x = r.Next(0, 200);
                altin4.Location = new Point(x, 0);
            }
        }
        void HizArttir()
        {
            int hiz = 0;
            hiz++;
            lblHiz.Text = hiz.ToString();
            
        }
        void HizAzalt()
        {
            int hiz = 0;
            hiz--;
            lblHiz.Text = hiz.ToString();
        }

        int oyunhizi = 0;

        private void btnTekrarOyna_Click(object sender, EventArgs e)
        {
            Araba_Oyun araba = new Araba_Oyun();
            araba.Show();
            this.Hide();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (araba.Left > 0)
                {
                    araba.Left += -oyunhizi;
                }
            }
            if (e.KeyCode == Keys.Right)
            {
                if (araba.Right < 380)
                {
                    araba.Left += oyunhizi;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (oyunhizi < 21)
                {
                    oyunhizi++;
                    HizArttir();
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (oyunhizi > 0)
                {
                    oyunhizi--;
                    HizAzalt();
                }
            }

        }
    }
}
