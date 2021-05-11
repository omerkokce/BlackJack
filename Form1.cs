using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void sifirla() 
        {
            sayac = 0;
            Atoplam = 0;
            Btoplam = 0;

            lblA1.Text = "";
            lblA2.Text = "";
            lblA3.Text = "";
            lblA4.Text = "";
            lblA5.Text = "";
            lblA6.Text = "";
            lblA7.Text = "";
            lblA8.Text = "";
            lblAToplam.Text = "0";

            lblB1.Text = "";
            lblB2.Text = "";
            lblB3.Text = "";
            lblB4.Text = "";
            lblB5.Text = "";
            lblB6.Text = "";
            lblB7.Text = "";
            lblB8.Text = "";
            lblBToplam.Text = "0";

            btnKart.Enabled = false;
            btnYeniden.Enabled = false;
            btnDur.Enabled = false;
            btnDagit.Enabled = true;
        }
        Random sayi = new Random();
        int para = 1000, bahis = 0;
        int sayac = 0, Atoplam = 0, Btoplam = 0;
        int a1, a2, a3, a4, a5, a6, a7, a8, b1, b2, b3, b4, b5, b6, b7, b8;
        private void btnDagit_Click(object sender, EventArgs e)
        {
            if (bahis == 0)
            {
                MessageBox.Show("Lütfen Bahis Yatırın");
                return;
            }
            btnDagit.Enabled = false;
            btnKart.Enabled = true;
            btnDur.Enabled = true;
            btn10.Enabled = false;
            btn25.Enabled = false;
            btn50.Enabled = false;
            btn100.Enabled = false;
            btn500.Enabled = false;
            btnSifirla.Enabled = false;
            sayac++;
            if (sayac == 1)
            {
                a1 = sayi.Next(1, 11);
                a2 = sayi.Next(1, 11);
                b1 = sayi.Next(1, 11);
                b2 = sayi.Next(1, 11);

                lblA1.Text = a1.ToString();
                lblA2.Text = a2.ToString();
                lblB1.Text = b1.ToString();
                lblB2.Text = b2.ToString();

                Atoplam += a1 + a2;
                lblAToplam.Text = Atoplam.ToString();
                Btoplam += b1 + b2;
                lblBToplam.Text = Btoplam.ToString();
            }
            
        }

        private void btnKart_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {
                a3 = sayi.Next(1, 11);

                lblA3.Text = a3.ToString();

                Atoplam += a3;
                lblAToplam.Text = Atoplam.ToString();
            }
            else if (sayac == 3)
            {
                a4 = sayi.Next(1, 11);

                lblA4.Text = a4.ToString();

                Atoplam += a4;
                lblAToplam.Text = Atoplam.ToString();
            }
            else if (sayac == 4)
            {
                a5 = sayi.Next(1, 11);

                lblA5.Text = a5.ToString();

                Atoplam += a5;
                lblAToplam.Text = Atoplam.ToString();
            }
            else if (sayac == 5)
            {
                a6 = sayi.Next(1, 11);

                lblA6.Text = a6.ToString();

                Atoplam += a6;
                lblAToplam.Text = Atoplam.ToString();
            }
            else if (sayac == 6)
            {
                a7 = sayi.Next(1, 11);

                lblA7.Text = a7.ToString();

                Atoplam += a7;
                lblAToplam.Text = Atoplam.ToString();
            }
            else if (sayac == 7)
            {
                a8 = sayi.Next(1, 11);

                lblA8.Text = a4.ToString();

                Atoplam += a8;
                lblAToplam.Text = Atoplam.ToString();
            }
            if (Atoplam > 21)
            {
                MessageBox.Show("Kaybettiniz");
                btnKart.Enabled = false;
                btnYeniden.Enabled = true;
                btnDur.Enabled = false;
                btnDagit.Enabled = true;
                btn10.Enabled = true;
                btn25.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
                btn500.Enabled = true;
                btnSifirla.Enabled = true;

                bahis = 0;
                lblBahis.Text = "0";
                if (para == 0)
                {
                    MessageBox.Show("GAME OVER BİTCH !!!");
                    btn10.Enabled = false;
                    btn25.Enabled = false;
                    btn50.Enabled = false;
                    btn100.Enabled = false;
                    btn500.Enabled = false;
                    btnSifirla.Enabled = false;
                    btnDagit.Enabled = false;
                    btnDur.Enabled = false;
                    btnKart.Enabled = false;
                    btnYeniden.Enabled = true;
                }
            } 
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            btnKart.Enabled = false;
            btnDur.Enabled = false;
            btnYeniden.Enabled = true;
            btnDagit.Enabled = true;

            sayac = 0;

            if (Btoplam < 17)
            {
                b3 = sayi.Next(1, 11);
                lblB3.Text = b3.ToString();

                Btoplam += b3;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam < 17)
            {
                b4 = sayi.Next(1, 11);
                lblB4.Text = b4.ToString();

                Btoplam += b4;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam < 17)
            {
                b5 = sayi.Next(1, 11);
                lblB5.Text = b5.ToString();

                Btoplam += b5;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam < 17)
            {
                b6 = sayi.Next(1, 11);
                lblB3.Text = b6.ToString();

                Btoplam += b6;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam < 17)
            {
                b7 = sayi.Next(1, 11);
                lblB3.Text = b7.ToString();

                Btoplam += b7;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam < 17)
            {
                b8 = sayi.Next(1, 11);
                lblB3.Text = b8.ToString();

                Btoplam += b8;
                lblBToplam.Text = Btoplam.ToString();
            }
            if (Btoplam > 21)
            {
                MessageBox.Show("Kazandınız");
                para += bahis * 2;
                bahis = 0;
                lblBahis.Text = bahis.ToString();
                lblPara.Text = para.ToString();
                btn10.Enabled = true;
                btn25.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
                btn500.Enabled = true;
                btnSifirla.Enabled = true;
            }
            else if (Atoplam < Btoplam)
            {
                MessageBox.Show("Kaybettiniz");
                bahis = 0;
                lblBahis.Text = bahis.ToString();
                btn10.Enabled = true;
                btn25.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
                btn500.Enabled = true;
                btnSifirla.Enabled = true;
            }
            else if (Atoplam == Btoplam)
            {
                MessageBox.Show("Beraberlik");
                para += bahis;
                bahis = 0;
                lblBahis.Text = bahis.ToString();
                lblPara.Text = para.ToString();
                btn10.Enabled = true;
                btn25.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
                btn500.Enabled = true;
                btnSifirla.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kazandınız");
                para += bahis * 2;
                bahis = 0;
                lblBahis.Text = bahis.ToString();
                lblPara.Text = para.ToString();
                btn10.Enabled = true;
                btn25.Enabled = true;
                btn50.Enabled = true;
                btn100.Enabled = true;
                btn500.Enabled = true;
                btnSifirla.Enabled = true;
            }
            if (para == 0)
            {
                MessageBox.Show("GAME OVER BİTCH !!!");
                btn10.Enabled = false;
                btn25.Enabled = false;
                btn50.Enabled = false;
                btn100.Enabled = false;
                btn500.Enabled = false;
                btnSifirla.Enabled = false;
                btnDagit.Enabled = false;
                btnDur.Enabled = false;
                btnKart.Enabled = false;
                btnYeniden.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKart.Enabled = false;
            btnYeniden.Enabled = false;
            btnDur.Enabled = false;
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            sifirla();
            para = 1000;
            bahis = 0;
            lblBahis.Text = bahis.ToString();
            lblPara.Text = para.ToString();
            btn10.Enabled = true;
            btn25.Enabled = true;
            btn50.Enabled = true;
            btn100.Enabled = true;
            btn500.Enabled = true;
            btnSifirla.Enabled = true;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (para >= 10)
            {
                para -= 10;
                lblPara.Text = para.ToString();

                bahis += 10;
                lblBahis.Text = bahis.ToString();
            }
            else
            {
                MessageBox.Show("Bankanızda Yeterli Para Bulunmamaktadır!!");
            }
            sifirla();
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (para >= 25)
            {
                para -= 25;
                lblPara.Text = para.ToString();

                bahis += 25;
                lblBahis.Text = bahis.ToString();
            }
            else
            {
                MessageBox.Show("Bankanızda Yeterli Para Bulunmamaktadır!!");
            }
            sifirla();
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (para >= 50)
            {
                para -= 50;
                lblPara.Text = para.ToString();

                bahis += 50;
                lblBahis.Text = bahis.ToString();
            }
            else
            {
                MessageBox.Show("Bankanızda Yeterli Para Bulunmamaktadır!!");
            }
            sifirla();
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (para >= 100)
            {
                para -= 100;
                lblPara.Text = para.ToString();

                bahis += 100;
                lblBahis.Text = bahis.ToString();
            }
            else
            {
                MessageBox.Show("Bankanızda Yeterli Para Bulunmamaktadır!!");
            }
            sifirla();
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (para >= 500)
            {
                para -= 500;
                lblPara.Text = para.ToString();

                bahis += 500;
                lblBahis.Text = bahis.ToString();
            }
            else
            {
                MessageBox.Show("Bankanızda Yeterli Para Bulunmamaktadır!!");
            }
            sifirla();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            para += bahis;
            bahis = 0;
            lblBahis.Text = bahis.ToString();
            lblPara.Text = para.ToString();
        }

    }
}
