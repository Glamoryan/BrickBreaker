﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int basla = 1;
        int raket = 1;
        int puan=0;
        Graphics g;
        int left_borderx = 10, left_bordery = 70, left_borderW = 2, left_borderH = 530; //Sol Kenar
        int right_borderx = 525, right_bordery = 70, right_borderW = 2, right_borderH = 530; // Sağ Kenar
        int top_borderx = 10, top_bordery = 67, top_borderW = 517, top_borderH = 2; //Üst Kenar
        int bot_borderx = 10, bot_bordery = 599, bot_borderW = 517, bot_borderH = 2; //Alt kenar
        int topx = 265, topy = 530, topW = 15, topH = 15; // Top
        
        bool yukari = true,sol=true;



        private void lbSkorSayac_Click(object sender, EventArgs e)
        {
            //D'Care
           
        }

        int r_xsol = 235, r_ytop = 550, raketW = 75, raketH = 10; // Raket
        


        SolidBrush firca_top = new SolidBrush(Color.Blue);
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Hileler
            if (e.KeyCode == Keys.K)
            {
                puan = 21;
                

            }

            // Raket Hareketi 
            SolidBrush top_sil = new SolidBrush(this.BackColor);
            g.FillEllipse(top_sil, topx, topy, topW, topH);
            SolidBrush raket_sil = new SolidBrush(this.BackColor);
            g.FillRectangle(raket_sil, r_xsol, r_ytop, raketW, raketH);
            if (raket == 2)
            {
                if (e.KeyCode == Keys.Left && r_xsol > 20)
                {
                    r_xsol -= 8;

                }
                if (e.KeyCode == Keys.Right && r_xsol < 438)
                {
                    r_xsol += 8;

                }
            }

            SolidBrush firca_raket = new SolidBrush(Color.Red);
            g.FillRectangle(firca_raket, r_xsol, r_ytop, raketW, raketH);

            g.FillEllipse(firca_top, topx, topy, topW, topH);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Geri Sayım
        int i = 3;
        private void slow_Tick(object sender, EventArgs e)
        {

            i--;
            if (i == 3)
            {
                lbSay.Text = "3";
            }
            else if (i == 2)
            {
                lbSay.Text = "2";
                lbSay.ForeColor = Color.Red;
            }
            else if (i == 1)
            {
                lbSay.Text = "1";
                lbSay.ForeColor = Color.HotPink;

            }
            else if (i == 0)
            {
                lbSay.Text = "0";
                lbSay.ForeColor = Color.LimeGreen;
                timer1.Enabled = true;
                raket = 2;
            }
            else
            {
                lbSay.Visible = false;
                slow.Enabled = false;
            }




        }

       
        private void lbNext_Click(object sender, EventArgs e)
        {
            
            level2 lev = new level2();            
            this.Hide();
            lev.Show();



        }


           

        private void label3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

  

        private void lbTekrar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        // Level 1 Dizayn
        int h1x = 35, h1y = 120, h1W = 30, h1H = 15;
        int h2x = 55, h2y = 150, h2W = 30, h2H = 15;
        int h3x = 75, h3y = 180, h3W = 30, h3H = 15;
        int h4x = 95, h4y = 210, h4W = 30, h4H = 15;
        int h5x = 115, h5y = 240, h5W = 30, h5H = 15;
        int h6x = 135, h6y = 270, h6W = 30, h6H = 15;
        int h7x = 155, h7y = 300, h7W = 30, h7H = 15;
        int h8x = 175, h8y = 330, h8W = 30, h8H = 15;
        int h9x = 195, h9y = 360, h9W = 30, h9H = 15;
        int h10x = 215, h10y = 390, h10W = 30, h10H = 15;
        int h11x = 255, h11y = 390, h11W = 30, h11H = 15;
        int h12x = 295, h12y = 390, h12W = 30, h12H = 15;
        int h13x = 315, h13y = 360, h13W = 30, h13H = 15;
        int h14x = 335, h14y = 330, h14W = 30, h14H = 15;
        int h15x = 355, h15y = 300, h15W = 30, h15H = 15;
        int h16x = 375, h16y = 270, h16W = 30, h16H = 15;
        int h17x = 395, h17y = 240, h17W = 30, h17H = 15;
        int h18x = 415, h18y = 210, h18W = 30, h18H = 15;
        int h19x = 425, h19y = 180, h19W = 30, h19H = 15;
        int h20x = 445, h20y = 150, h20W = 30, h20H = 15;
        int h21x = 465, h21y = 120, h21W = 30, h21H = 15;
        

     


        private void lbBasla_MouseHover(object sender, EventArgs e)
        {
            lbBasla.ForeColor = Color.LimeGreen;
            label1.ForeColor = Color.White;
            
        }

        private void lbBasla_MouseLeave(object sender, EventArgs e)
        {
            lbBasla.ForeColor = Color.White;
            label1.ForeColor = Color.LimeGreen;
        }

        private void lbCik_MouseHover(object sender, EventArgs e)
        {
            lbCik.ForeColor = Color.Lime;
            label2.ForeColor = Color.White;
        }

        private void lbCik_MouseLeave(object sender, EventArgs e)
        {
            lbCik.ForeColor = Color.White;
            label2.ForeColor = Color.LimeGreen;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Yandın
            if (topy >= 595)
            {
                SolidBrush yandinBorder = new SolidBrush(Color.Red);
                g.FillRectangle(yandinBorder, 13, 597, 620, 8);
                timer1.Enabled = false;                                
                Form.ActiveForm.BackColor = Color.Black;               
                lbSon.Text = "Yandınız \n Skorunuz \n  " + lbSkorSayac.Text;
                lbSon.Visible = true;
                raket = 1; //Raket off
                basla = 1; //Oyun off
                label3.Visible = true;
                lbTekrar.Visible = true;             






            }
            // Kazandın
            else if (puan == 21)
            {
                lbSon.Visible = true;
                lbNext.Visible = true;
                lbSon.Text = "Tebrikler \n Skorunuz \n" + puan.ToString();                                
                Form.ActiveForm.BackColor = Color.Black;                
                timer1.Enabled = false;
                raket = 1; //Raket off
                basla = 1; //Oyun off
                label3.Visible = false;
            }

            /* X,Y Koordinatları
            loc.Visible = true;
            Point p = this.PointToClient(Cursor.Position);
            loc.Text = (p.ToString()); */
           

            lbSkorSayac.Text = puan.ToString();

            int tophiz = 2;
            SolidBrush top_sil = new SolidBrush(this.BackColor);
            g.FillEllipse(top_sil, topx, topy, topW, topH);
            // Top Hareketi
            if (sol == true) topx -= tophiz;
            
            if (sol == false) topx += tophiz;

            if (yukari == true) topy -= tophiz;
            
            if (yukari == false) topy += tophiz;

            // Kenarlara çarpma
            if (topx >= 500) sol = true;
            if (topx <= 15) sol = false;
            if (topy <= 90) yukari = false;
            if (topy >= 600)yukari = true;

            //Top RAKETE çarparsa
            if (topx >= r_xsol && topy <= r_ytop) //=> Raketin altından sekme ve rakete çarpmadan sekme sorunu
            {
                if (Math.Abs(topx - r_xsol) <= 75 && Math.Abs(topy - r_ytop) <= 18)yukari = true; 
            }
            g.FillEllipse(firca_top, topx, topy, topW, topH);


            //-----------------------------------------
            SolidBrush hedefsil = new SolidBrush(this.BackColor);

            
            // Hedefler Vurulduğunda
            int boy = 19;
            int yboy = 19;
            if (Math.Abs(topx - h1x) <= boy && Math.Abs(topy - h1y) <= yboy) { if (topx <= h1x) { sol = true; } else { sol = false; } if (topy <= h1y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h1x, h1y, h1W, h1H); h1x = 1000; h1y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h2x) <= boy && Math.Abs(topy - h2y) <= yboy) { if (topx <= h2x) { sol = true; } else { sol = false; } if (topy <= h2y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h2x, h2y, h2W, h2H); h2x = 1000; h2y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h3x) <= boy && Math.Abs(topy - h3y) <= yboy) { if (topx <= h3x) { sol = true; } else { sol = false; } if (topy <= h3y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h3x, h3y, h3W, h3H); h3x = 1000; h3y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h4x) <= boy && Math.Abs(topy - h4y) <= yboy) { if (topx <= h4x) { sol = true; } else { sol = false; } if (topy <= h4y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h4x, h4y, h4W, h4H); h4x = 1000; h4y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h5x) <= boy && Math.Abs(topy - h5y) <= yboy) { if (topx <= h5x) { sol = true; } else { sol = false; } if (topy <= h5y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h5x, h5y, h5W, h5H); h5x = 1000; h5y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h6x) <= boy && Math.Abs(topy - h6y) <= yboy) { if (topx <= h6x) { sol = true; } else { sol = false; } if (topy <= h6y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h6x, h6y, h6W, h6H); h6x = 1000; h6y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h7x) <= boy && Math.Abs(topy - h7y) <= yboy) { if (topx <= h7x) { sol = true; } else { sol = false; } if (topy <= h7y) { yukari = true; } else { yukari = false; }; g.FillRectangle(hedefsil, h7x, h7y, h7W, h7H); h7x = 1000; h7y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h8x) <= boy && Math.Abs(topy - h8y) <= yboy) { if (topx <= h8x) { sol = true; } else { sol = false; } if (topy <= h8y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h8x, h8y, h8W, h8H); h8x = 1000; h8y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h9x) <= boy && Math.Abs(topy - h9y) <= yboy) { if (topx <= h9x) { sol = true; } else { sol = false; } if (topy <= h9y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h9x, h9y, h9W, h9H); h9x = 1000; h9y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h10x) <= boy && Math.Abs(topy - h10y) <= yboy) { if (topx <= h10x) { sol = true; } else { sol = false; } if (topy <= h10y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h10x, h10y, h10W, h10H); h10x = 1000; h10y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h11x) <= boy && Math.Abs(topy - h11y) <= yboy) { if (topx <= h11x) { sol = true; } else { sol = false; } if (topy <= h11y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h11x, h11y, h11W, h11H); h11x = 1000; h11y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h12x) <= boy && Math.Abs(topy - h12y) <= yboy) { if (topx <= h12x) { sol = true; } else { sol = false; } if (topy <= h12y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h12x, h12y, h12W, h12H); h12x = 1000; h12y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h13x) <= boy && Math.Abs(topy - h13y) <= yboy) { if (topx <= h13x) { sol = true; } else { sol = false; } if (topy <= h13y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h13x, h13y, h13W, h13H); h13x = 1000; h13y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h14x) <= boy && Math.Abs(topy - h14y) <= yboy) { if (topx <= h14x) { sol = true; } else { sol = false; } if (topy <= h14y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h14x, h14y, h14W, h14H); h14x = 1000; h14y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h15x) <= boy && Math.Abs(topy - h15y) <= yboy) { if (topx <= h15x) { sol = true; } else { sol = false; } if (topy <= h15y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h15x, h15y, h15W, h15H); h15x = 1000; h15y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h16x) <= boy && Math.Abs(topy - h16y) <= yboy) { if (topx <= h16x) { sol = true; } else { sol = false; } if (topy <= h16y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h16x, h16y, h16W, h16H); h16x = 1000; h16y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h17x) <= boy && Math.Abs(topy - h17y) <= yboy) { if (topx <= h17x) { sol = true; } else { sol = false; } if (topy <= h17y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h17x, h17y, h17W, h17H); h17x = 1000; h17y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h18x) <= boy && Math.Abs(topy - h18y) <= yboy) { if (topx <= h18x) { sol = true; } else { sol = false; } if (topy <= h18y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h18x, h18y, h18W, h18H); h18x = 1000; h18y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h19x) <= boy && Math.Abs(topy - h19y) <= yboy) { if (topx <= h19x) { sol = true; } else { sol = false; } if (topy <= h19y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h19x, h19y, h19W, h19H); h19x = 1000; h19y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h20x) <= boy && Math.Abs(topy - h20y) <= yboy) { if (topx <= h20x) { sol = true; } else { sol = false; } if (topy <= h20y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h20x, h20y, h20W, h20H); h20x = 1000; h20y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);
            if (Math.Abs(topx - h21x) <= boy && Math.Abs(topy - h21y) <= yboy) { if (topx <= h21x) { sol = true; } else { sol = false; } if (topy <= h21y) { yukari = true; } else { yukari = false; } g.FillRectangle(hedefsil, h21x, h21y, h21W, h21H); h21x = 1000; h21y = 1000; puan++; }
            g.FillEllipse(firca_top, topx, topy, topW, topH);



        }

        private void lbCik_Click(object sender, EventArgs e)
        {
            // Çıkış
            System.Windows.Forms.Application.Exit();
        }

        private void lbBasla_Click_1(object sender, EventArgs e)
        {
            // Menu Labelları -------------------
            label1.Visible = false;
            label2.Visible = false;
            
            //------------------------------


            lbBasla.Visible = false;
            basla = 2;
            lbCik.Visible = false;
            slow.Enabled = true;
            lbSay.Visible = true;
   
            lbScore.Visible = true;
            lbLevel.Visible = true;
            lbSkorSayac.Visible = true;
            
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (basla == 2)
            {
                g = this.CreateGraphics();

                //Raket
                SolidBrush firca_raket = new SolidBrush(Color.Red);
                g.FillRectangle(firca_raket, r_xsol, r_ytop, raketW, raketH);

                //Top
                
                g.FillEllipse(firca_top, topx, topy, topW, topH);

                // Hedefler
                SolidBrush hedefler = new SolidBrush(Color.Yellow);
                g.FillRectangle(hedefler, h1x, h1y, h1W, h1H);
                g.FillRectangle(hedefler, h2x, h2y, h2W, h2H);
                g.FillRectangle(hedefler, h3x, h3y, h3W, h3H);
                g.FillRectangle(hedefler, h4x, h4y, h4W, h4H);
                g.FillRectangle(hedefler, h5x, h5y, h5W, h5H);
                g.FillRectangle(hedefler, h6x, h6y, h6W, h6H);
                g.FillRectangle(hedefler, h7x, h7y, h7W, h7H);
                g.FillRectangle(hedefler, h8x, h8y, h8W, h8H);
                g.FillRectangle(hedefler, h9x, h9y, h9W, h9H);
                g.FillRectangle(hedefler, h10x, h10y, h10W, h10H);
                g.FillRectangle(hedefler, h11x, h11y, h11W, h11H);
                g.FillRectangle(hedefler, h12x, h12y, h12W, h12H);
                g.FillRectangle(hedefler, h13x, h13y, h13W, h13H);
                g.FillRectangle(hedefler, h14x, h14y, h14W, h14H);
                g.FillRectangle(hedefler, h15x, h15y, h15W, h15H);
                g.FillRectangle(hedefler, h16x, h16y, h16W, h16H);
                g.FillRectangle(hedefler, h17x, h17y, h17W, h17H);
                g.FillRectangle(hedefler, h18x, h18y, h18W, h18H);
                g.FillRectangle(hedefler, h19x, h19y, h19W, h19H);
                g.FillRectangle(hedefler, h20x, h20y, h20W, h20H);
                g.FillRectangle(hedefler, h21x, h21y, h21W, h21H);

                // Borderlar
                Pen border = new Pen(Color.LimeGreen, left_borderW);
                g.DrawRectangle(border, left_borderx, left_bordery, left_borderW,left_borderH);
                g.DrawRectangle(border, right_borderx, right_bordery, right_borderW, right_borderH);
                g.DrawRectangle(border, top_borderx, top_bordery, top_borderW, top_borderH);

                // Alt Kenar ---------------------------------------------------------------
                Pen bottom_border_sil = new Pen(this.BackColor,left_borderW);
                g.DrawRectangle(bottom_border_sil, bot_borderx, bot_bordery, bot_borderW, bot_borderH);
                
            }
        }
    }
}

